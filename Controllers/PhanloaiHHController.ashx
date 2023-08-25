﻿<%@ WebHandler Language="C#" Class="PhanloaiHHController" %>

using System;
using System.Web;
using System.Data.Linq;
using System.Linq;
using System.Data;

public class PhanloaiHHController : IHttpHandler
{
    private LinqDBDataContext db = new LinqDBDataContext();

    public void ProcessRequest(HttpContext context)
    {
        String action, oper;
        action = context.Request.QueryString["action"];
        oper = context.Request.Form["oper"];
        switch (action)
        {
            case "getoption":
                this.getSelectOption(context);
                break;
            case "getcolorref":
                this.getAllColor(context);
                break;
            default:
                switch (oper)
                {
                    case "del":
                        this.del(context);
                        break;
                    case "edit":
                        this.edit(context);
                        break;
                    case "add":
                        this.add(context);
                        break;
                    default:
                        this.load(context);
                        break;
                }
                break;
        }
    }

    public void getAllColor(HttpContext context) { 
        LinqDBDataContext db = new LinqDBDataContext();
        string hehangid = context.Request.Form["hehang"].ToString();
        var chungloai = db.md_phanloaihhs.Single(p => p.md_phanloaihh_id.Equals(hehangid));
        var hh = db.md_chungloais.Single(h => h.md_chungloai_id.Equals(chungloai.md_chungloai_id));
        string sql = @"select distinct code_mau, code_mau + ' || '+ ta_ngan from md_mausac where code_cl = '" + hh.code_cl + "' order by code_mau";

        DataTable data = mdbc.GetData(sql);
        string res = "";
        foreach (DataRow item in data.Rows)
        {
            res += "<option value=\""+item[0].ToString()+"\">"+item[1].ToString()+"</option>";
        }
        context.Response.Write(res);
    }
    
    public void getSelectOption(HttpContext context)
    {
        String sql = "select md_chungloai_id, code_cl from md_chungloai where hoatdong = 1 order by code_cl desc";
        SelectHtmlControl s = new SelectHtmlControl(sql);
        context.Response.Write(s.ToString());
    }
    
    
    public void edit(HttpContext context)
    {
        String h = context.Request.Form["hoatdong"].ToLower();
        bool hd = false;
        if (h.Equals("on") || h.Equals("true"))
        { hd = true; }
        
        String phanloai_id = context.Request.Form["id"];
        String code_pl = context.Request.Form["code_pl"];
        
        
        var lst = (from o in db.md_phanloaihhs
                  where o.code_pl.Equals(code_pl) && !o.md_phanloaihh_id.Equals(phanloai_id)
                  select new { o.md_phanloaihh_id });
        
        if (lst.Count() != 0)
        {
            jqGridHelper.Utils.writeResult(0, "Đã có code chủng loại này!");
        }
        else
        {
            md_phanloaihh m = db.md_phanloaihhs.Single(p => p.md_phanloaihh_id.Equals(phanloai_id));
            m.code_pl = context.Request.Form["code_pl"];
            //m.tv_ngan = context.Request.Form["tv_ngan"];
            m.ta_ngan = context.Request.Form["ta_ngan"];
            //m.tv_dai = context.Request.Form["tv_dai"];
            m.ta_dai = context.Request.Form["ta_dai"];
            m.cangbiensx = context.Request.Form["cangbiensx"];
            m.md_chungloai_id = context.Request.Form["md_chungloai_id"];
            m.mota = context.Request.Form["mota"];
            m.hoatdong = hd;
            m.nguoicapnhat = UserUtils.getUser(context);
            m.ngaycapnhat = DateTime.Now;
            db.SubmitChanges();
        }
    }

    public void add(HttpContext context)
    {
        String h = context.Request.Form["hoatdong"].ToLower();
        bool hd = false;
        if (h.Equals("on") || h.Equals("true"))
        { hd = true; }
        
        String code_pl = context.Request.Form["code_pl"];
        var lst = from o in db.md_phanloaihhs where o.code_pl.Equals(code_pl) select o;
        if (lst.Count() != 0)
        {
            jqGridHelper.Utils.writeResult(0, "Đã tồn tại code này trong danh mục!");
        }
        else
        {
            md_phanloaihh mnu = new md_phanloaihh
            {
                md_phanloaihh_id = Security.EncodeMd5Hash(DateTime.Now.ToString("yyyyMMddddhhmmss")),
                code_pl = context.Request.Form["code_pl"],
                //tv_ngan = context.Request.Form["tv_ngan"],
                ta_ngan = context.Request.Form["ta_ngan"],
                //tv_dai = context.Request.Form["tv_dai"],
                ta_dai = context.Request.Form["ta_dai"],
                md_chungloai_id = context.Request.Form["md_chungloai_id"],
                cangbiensx = context.Request.Form["cangbiensx"],
                mota = context.Request.Form["mota"],
                hoatdong = hd,
                nguoitao = UserUtils.getUser(context),
                nguoicapnhat = UserUtils.getUser(context),
                ngaytao = DateTime.Now,
                ngaycapnhat = DateTime.Now
            };

            db.md_phanloaihhs.InsertOnSubmit(mnu);
            db.SubmitChanges();
        }
    }


    public void del(HttpContext context)
    {
        String id = context.Request.Form["id"];
        id = id.Insert(0, "'");
        id = id.Insert(id.Length, "'");
        id = id.Replace(",", "','");
        String sql = "delete md_phanloaihh where md_phanloaihh_id IN (" + id + ")";
        mdbc.ExcuteNonQuery(sql);
    }

    public void load(HttpContext context)
    {
        context.Response.ContentType = "text/xml";
        context.Response.Charset = "UTF-8";

        //// filter
        String filter = "";
        bool _search = bool.Parse(context.Request.QueryString["_search"]);
        if (_search)
        {
            String _filters = context.Request.QueryString["filters"];
            jqGridHelper.Filter f = jqGridHelper.Filter.CreateFilter(_filters);
            filter = f.ToScript();
        }
        
        String sqlCount = "SELECT COUNT(*) AS count FROM md_phanloaihh pl where 1=1 {0} ";
        sqlCount = string.Format(sqlCount, filter);
        
        int page = int.Parse(context.Request.QueryString["page"]);
        int limit = int.Parse(context.Request.QueryString["rows"]);
        String sidx = context.Request.QueryString["sidx"];
        String sord = context.Request.QueryString["sord"];
        int total_page;
        int count = (int)mdbc.ExecuteScalar(sqlCount);
        int start, end;

        if (count > 0)
        {
            total_page = (int)Math.Ceiling(1.0 * count / limit);
        }
        else
        {
            total_page = 0;
        }

        if (page > total_page) page = total_page;
        start = limit * page - limit;
        end = (page * limit) + 1;

        if (sidx.Equals("") || sidx == null)
        {
            sidx = "pl.code_pl";
        }

        string strsql = "select * from( " +
            " select pl.md_phanloaihh_id, pl.code_pl, cl.code_cl, pl.ta_ngan, pl.ta_dai " +
            " , pl.cangbiensx, pl.ngaytao, pl.nguoitao, pl.ngaycapnhat, pl.nguoicapnhat, pl.hoatdong " +
            " , ROW_NUMBER() OVER (ORDER BY " + sidx + " " + sord + ") as RowNum " +
            " FROM md_phanloaihh pl, md_chungloai cl where pl.md_chungloai_id = cl.md_chungloai_id and 1=1 {0} " +
            " )P where RowNum > @start AND RowNum < @end";
        strsql = string.Format(strsql, filter);
        
        System.Data.DataTable dt = mdbc.GetData(strsql, "@start", start, "@end", end);
        string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
        xml += "<rows>";
        xml += "<page>" + page + "</page>";
        xml += "<total>" + total_page + "</total>";
        xml += "<records>" + count + "</records>";
        foreach (System.Data.DataRow row in dt.Rows)
        {
            xml += "<row>";
            xml += "<cell><![CDATA[" + row["md_phanloaihh_id"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["code_pl"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["code_cl"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["ta_ngan"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["ta_dai"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["cangbiensx"] + "]]></cell>";
            xml += "<cell><![CDATA[" + DateTime.Parse(row["ngaytao"].ToString()).ToString("dd/MM/yyyy") + "]]></cell>";
            xml += "<cell><![CDATA[" + row["nguoitao"] + "]]></cell>";
            xml += "<cell><![CDATA[" + DateTime.Parse(row["ngaycapnhat"].ToString()).ToString("dd/MM/yyyy") + "]]></cell>";
            xml += "<cell><![CDATA[" + row["nguoicapnhat"] + "]]></cell>";
            xml += "<cell><![CDATA[" + row["hoatdong"] + "]]></cell>";
            xml += "</row>";
        }
        xml += "</rows>";
        context.Response.Write(xml);
    }

    public bool IsReusable
    {
        get { return false; }
    }
}
