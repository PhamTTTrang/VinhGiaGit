﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inc-tao-chungtuxuathang-cungpo.aspx.cs" Inherits="inc_tao_chungtuxuathang_cungpo" %>
<%@ Register src="jqGrid.ascx" tagname="jqGrid" tagprefix="uc1" %>
<script>
    $(document).ready(function() {
        // level 1
        $('#layout-center-chungtuxuathang-cungpo').parent().layout({
            south: {
                size: "50%"
            }
        });

        // level 2
        $('#layout-south-chungtuxuathang-cungpo').layout({
            west: {
                size: "30%"
                , onresize_end: function() {
                    var o = $("#layout-west-phieuxuat-cungpo");
                    var h = o.height();
                    var w = o.width();
                    $("#grid_ds_pocungphieuxuat").setGridHeight(h - 90);
                    $("#grid_ds_pocungphieuxuat").setGridWidth(w);
                }
            }
        });

        // level 3
        $('#layout-center-phieuxuat-cungpo').layout({
            south: {
                size: "50%"
                , onresize_end: function() {
                    var o = $("#layout-south-soanthao-cungpo");
                    var h = o.height();
                    var w = o.width();
                    $("#grid_ds_chitietxuatkho_cungpo").setGridHeight(h - 73);
                    $("#grid_ds_chitietxuatkho_cungpo").setGridWidth(w);
                }
            }
            , center: {
                onresize_end: function() {
                    var o = $("#layout-center-soanthao-cungpo");
                    var h = o.height();
                    var w = o.width();
                    $("#grid_ds_xuatkho_cungpo").setGridHeight(h - 73);
                    $("#grid_ds_xuatkho_cungpo").setGridWidth(w);
                }
            }
        });

        $('.submit button').button();

        $('#txtNgayLap').datepicker({ changeMonth: true, changeYear: true, dateFormat: 'dd/mm/yy' });
        $('#txtNgayLap').datepicker('setDate', new Date());

        $('#txtNgayVanDon').datepicker({ changeMonth: true, changeYear: true, dateFormat: 'dd/mm/yy' });
        $('#txtNgayVanDon').datepicker('setDate', new Date());
    });
</script>

<!-- Level 1  South -->
<div class="ui-layout-south ui-widget-content" id="layout-south-chungtuxuathang-cungpo">    
    
    <!-- Level 2 West -->
    <div class="ui-layout-west ui-widget-content" id="layout-west-phieuxuat-cungpo">
           <uc1:jqGrid  ID="grid_ds_pocungphieuxuat"
                Caption="Đơn Hàng" 
                SortName="c_donhang_id" 
                UrlFileAction="Controllers/DonHangCoPhieuXuatController.ashx"
                ColNames="['c_nhapxuat_id', 'Số Chứng Từ']"
                RowNumbers="true"
                ColModel = "[
                {
                    fixed: true, name: 'c_donhang_id'
                    , index: 'dh.c_donhang_id'
                    , width: 100
                    , hidden: true 
                    , editable:true
                    , edittype: 'text'
                    , key: true
                },
                {
                     fixed: true, name: 'sochungtu'
                     , index: 'dh.sochungtu'
                     , editable: true
                     , width: 180
                     , edittype: 'text'
                }
                ]"
                FilterToolbar="true"
                GridComplete = "var o = $(this).parent().parent().parent().parent().parent(); $(this).setGridHeight($(o).height() - 90);"
                Height = "170"
                MultiSelect = "false" 
                OnSelectRow = "function(ids) {
		                    if(ids == null) {
			                    ids=0;
			                    if($('#grid_ds_xuatkho_cungpo').jqGrid('getGridParam','records') &gt; 0 )
			                    {
				                    $('#grid_ds_xuatkho_cungpo').jqGrid('setGridParam',{url:'Controllers/XuatKhoByPOController.ashx?&poId='+ids,page:1});
				                    $('#grid_ds_xuatkho_cungpo').jqGrid().trigger('reloadGrid');
				                } 
				            } else {
			                    $('#grid_ds_xuatkho_cungpo').jqGrid('setGridParam',{url:'Controllers/XuatKhoByPOController.ashx?&poId='+ids,page:1});
			                    $('#grid_ds_xuatkho_cungpo').jqGrid().trigger('reloadGrid');			
		                    } }"
                runat="server" />
    </div>
    <!-- Level 2 West -->
    
    <!-- Level 2 Center -->
    <div class="ui-layout-center ui-widget-content" id="layout-center-phieuxuat-cungpo">
        
        <!-- Level 3  South -->
        <div class="ui-layout-south ui-widget-content" id="layout-south-soanthao-cungpo">
            <uc1:jqGrid  ID="grid_ds_chitietxuatkho_cungpo" 
			Caption = "Chi Tiết Xuất Kho"
            SortName="dnx.c_dongnhapxuat_id" 
            UrlFileAction="Controllers/DongNhapXuatController.ashx" 
            ColNames="['c_dongnhapxuat_id', 'Nhập Xuất', 'Chi Tiết Đơn Hàng', 'STT', 'Mã Sản Phẩm', 'Mã Sản Phẩm', 'Mô Tả Tiếng Việt', 'Đơn Vị Tính', 'Số Lượng Phải Nhập/Xuất', 'Số Lượng Thực Nhập/Xuất', 'Đơn Giá', 'Số Kiện Thực Tế', 'Ngày Tạo', 'Người Tạo', 'Ngày Cập Nhật', 'Người Cập Nhật', 'Mô tả', 'Hoạt động']"
            RowNumbers="true"
            ColModel = "[
            {
                fixed: true, name: 'c_dongnhapxuat_id'
                , index: 'c_dongnhapxuat_id'
                , width: 100
                , hidden: true 
                , editable:true
                , edittype: 'text'
                , key: true
            },
            {
                 fixed: true, name: 'c_nhapxuat_id'
                 , index: 'c_nhapxuat_id'
                 , editable: true
                 , width: 100
                 , edittype: 'text'
                 , hidden : true
            },
            {
                fixed: true, name: 'c_dongdonhang_id'
                , index: 'c_dongdonhang_id'
                , width: 100
                , edittype: 'text'
                , editable:true
                , hidden: true
            },
            {
                fixed: true, name: 'line'
                , index: 'line'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'sanpham_id'
                , index: 'sanpham_id'
                , width: 100
                , hidden: true 
                , editable:true
                , edittype: 'text'
            },
            {
                fixed: true, name: 'tensp'
                , index: 'tensp'
                , width: 100
                , edittype: 'text'
                , editable:true
                , editoptions: { 
                    dataInit : function (elem) { 
                        $(elem).combogrid({
                            searchIcon: true,
                            width: '480px',
                            url: 'Controllers/ProductController.ashx?action=getcombogrid',
                            colModel: [
                                { 'columnName': 'md_sanpham_id', 'width': '0', 'label': 'ID', hidden:true }
                              , { 'columnName': 'ma_sanpham', 'width': '50', 'label': 'Mã Sản Phẩm', 'align':'left'}
                              , { 'columnName': 'mota_tiengviet', 'width': '50', 'label': 'Mô Tả Tiếng Việt' , 'align':'left'}],
                              select: function(event, ui) {
                                    $(elem).val(ui.item.ma_sanpham);
                                    $('#sanpham_id').val(ui.item.md_sanpham_id);
                                    return false;
                              }
                        });
                    } 
                }
            },
            {
                fixed: true, name: 'mota_tiengviet'
                , index: 'mota_tiengviet'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'md_donvitinh_id'
                , index: 'md_donvitinh_id'
                , width: 100
                , edittype: 'select'
                , editable:true
                , editoptions: { dataUrl: 'Controllers/UnitController.ashx?action=getoption' }
            },
            {
                fixed: true, name: 'slphai_nhapxuat'
                , index: 'slphai_nhapxuat'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'slthuc_nhapxuat'
                , index: 'slthuc_nhapxuat'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'dongia'
                , index: 'dongia'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'sokien_thucte'
                , index: 'sokien_thucte'
                , width: 100
                , edittype: 'text'
                , editable:true
            },
            {
                fixed: true, name: 'ngaytao'
                , index: 'ngaytao'
                , width: 100
                , editable:false
                , edittype: 'text'
                , hidden: true 
                , editrules:{ edithidden : true }
            },
            {
                fixed: true, name: 'nguoitao'
                , index: 'nguoitao'
                , width: 100
                , editable:false
                , edittype: 'text'
                , hidden: true 
                , editrules:{ edithidden : true }
            },
            {
                fixed: true, name: 'ngaycapnhat'
                , index: 'ngaycapnhat'
                , width: 100
                , editable:false
                , edittype: 'text'
                , hidden: true 
                , editrules:{ edithidden : true }
            },
            {
                fixed: true, name: 'nguoicapnhat'
                , index: 'nguoicapnhat'
                , width: 100
                , editable:false
                , edittype: 'text'
                , hidden: true 
                , editrules:{ edithidden : true }
            },
            {
                fixed: true, name: 'mota'
                , index: 'mota'
                , width: 100
                , editable:true
                , edittype: 'textarea'
            },
            {
                fixed: true, name: 'hoatdong', hidden: true
                , index: 'hoatdong'
                , width: 100
                , editable:true
                , edittype: 'checkbox'
                , editoptions:{ defaultValue: 'True' }
                , editrules:{ edithidden : true }
            }
            ]"
            GridComplete = "var o = $(this).parent().parent().parent().parent().parent(); $(this).setGridHeight($(o).height()+ 4 - 77);"
            Height = "150"
            MultiSelect = "false" 
            runat="server" />
        </div>
        <!-- # Level 3  South -->
        
        <!-- Level 3  Center -->
        <div class="ui-layout-center ui-widget-content" id="layout-center-soanthao-cungpo">
                <uc1:jqGrid  ID="grid_ds_xuatkho_cungpo"
                Caption="Xuất Kho" 
                SortName="c_nhapxuat_id" 
                UrlFileAction="Controllers/XuatKhoByPOController.ashx"
                ColNames="['c_nhapxuat_id', 'Đơn Hàng', 'Số Phiếu', 'Số Phiếu NX', 'Ngày Giao Nhận', 'Đối Tác', 'Người Giao', 'Người Nhập', 'Số Phiếu Khách', 'Ngày Phiếu', 'Kho', 'Số Seal', 'Số Container', 'Loại Cont', 'Trạng Thái', 'Loại Chứng Từ', 'Ngày Tạo', 'Người Tạo', 'Ngày Cập Nhật', 'Người Cập Nhật', 'Mô tả', 'Hoạt động']"
                RowNumbers="true"
                ColModel = "[
                {
                    fixed: true, name: 'c_nhapxuat_id'
                    , index: 'c_nhapxuat_id'
                    , width: 100
                    , hidden: true 
                    , editable:true
                    , edittype: 'text'
                    , key: true
                },
                {
                     fixed: true, name: 'c_donhang_id'
                     , index: 'c_donhang_id'
                     , editable: true
                     , width: 100
                     , edittype: 'select'
                     , editoptions: { dataUrl: 'Controllers/DonHangController.ashx?action=getoption' }
                     , hidden: true 
                },  
                {
                     fixed: true, name: 'sophieu'
                     , index: 'sophieu'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'sophieunx'
                     , index: 'sophieunx'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                     , hidden:true
                },
                {
                     fixed: true, name: 'ngay_giaonhan'
                     , index: 'ngay_giaonhan'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                     , editoptions: { dataInit : function (elem) { $(elem).datepicker({ changeMonth: true, changeYear: true, dateFormat: 'dd/mm/yy' }); }, defaultValue: function(){ var currentTime = new Date(); var month = parseInt(currentTime.getMonth() + 1);     month = month &lt;= 9 ? '0' + month : month; var day = currentTime.getDate(); day = day &lt;= 9 ? '0'+ day : day; var year = currentTime.getFullYear(); return day + '/' + month + '/' + year; } }
                },
                {
                     fixed: true, name: 'md_doitackinhdoanh_id'
                     , index: 'md_doitackinhdoanh_id'
                     , editable: true
                     , width: 100
                     , edittype: 'select'
                     , editoptions: { dataUrl: 'Controllers/PartnerController.ashx?action=getoption' }
                },
                {
                     fixed: true, name: 'nguoigiao'
                     , index: 'nguoigiao'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'nguoinhan'
                     , index: 'nguoinhan'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'sophieukhach'
                     , index: 'sophieukhach'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'ngay_phieu'
                     , index: 'ngay_phieu'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                     , editoptions: { dataInit : function (elem) { $(elem).datepicker({ changeMonth: true, changeYear: true, dateFormat: 'dd/mm/yy' }); }, defaultValue: function(){ var currentTime = new Date(); var month = parseInt(currentTime.getMonth() + 1);     month = month &lt;= 9 ? '0' + month : month; var day = currentTime.getDate(); day = day &lt;= 9 ? '0'+ day : day; var year = currentTime.getFullYear(); return day + '/' + month + '/' + year; } }
                },
                {
                     fixed: true, name: 'nhapxuat_kho_id'
                     , index: 'nhapxuat_kho_id'
                     , editable: true
                     , width: 100
                     , edittype: 'select'
                     , editoptions: { dataUrl: 'Controllers/WarehouseController.ashx?action=getoption' }
                     , hidden:true
                },
                {
                     fixed: true, name: 'soseal'
                     , index: 'soseal'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'socontainer'
                     , index: 'socontainer'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'loaicont'
                     , index: 'loaicont'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                },
                {
                     fixed: true, name: 'md_trangthai_id'
                     , index: 'nx.md_trangthai_id'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                     , hidden:true
                },
                {
                     fixed: true, name: 'md_loaichungtu_id'
                     , index: 'md_loaichungtu_id'
                     , editable: true
                     , width: 100
                     , edittype: 'text'
                     , hidden:true
                },
                {
                    fixed: true, name: 'ngaytao'
                    , index: 'ngaytao'
                    , width: 100
                    , editable:false
                    , edittype: 'text'
                    , hidden: true 
                    , editrules:{ edithidden : true }
                },
                {
                    fixed: true, name: 'nguoitao'
                    , index: 'nguoitao'
                    , width: 100
                    , editable:false
                    , edittype: 'text'
                    , hidden: true 
                    , editrules:{ edithidden : true }
                },
                {
                    fixed: true, name: 'ngaycapnhat'
                    , index: 'ngaycapnhat'
                    , width: 100
                    , editable:false
                    , edittype: 'text'
                    , hidden: true 
                    , editrules:{ edithidden : true }
                },
                {
                    fixed: true, name: 'nguoicapnhat'
                    , index: 'nguoicapnhat'
                    , width: 100
                    , editable:false
                    , edittype: 'text'
                    , hidden: true 
                    , editrules:{ edithidden : true }
                },
                {
                    fixed: true, name: 'mota'
                    , index: 'mota'
                    , width: 100
                    , editable:true
                    , edittype: 'textarea'
                },
                {
                    fixed: true, name: 'hoatdong', hidden: true
                    , index: 'hoatdong'
                    , width: 100
                    , editable:true
                    , edittype: 'checkbox'
                    , align: 'center'
                    , editoptions:{ value:'True:False', defaultValue: 'True' }
                    , formatter: 'checkbox'
                }
                ]"
                GridComplete = "var o = $(this).parent().parent().parent().parent().parent(); $(this).setGridHeight($(o).height()+ 4 - 77);"
                Height = "170"
                MultiSelect = "true" 
                OnSelectRow = "function(ids) {
		                    if(ids == null) {
			                    ids=0;
			                    if($('#grid_ds_chitietxuatkho_cungpo').jqGrid('getGridParam','records') &gt; 0 )
			                    {
				                    $('#grid_ds_chitietxuatkho_cungpo').jqGrid('setGridParam',{url:'Controllers/DongNhapXuatController.ashx?&whId='+ids,page:1});
				                    $('#grid_ds_chitietxuatkho_cungpo').jqGrid().trigger('reloadGrid');
				                } 
				            } else {
			                    $('#grid_ds_chitietxuatkho_cungpo').jqGrid('setGridParam',{url:'Controllers/DongNhapXuatController.ashx?&whId='+ids,page:1});
			                    $('#grid_ds_chitietxuatkho_cungpo').jqGrid().trigger('reloadGrid');			
		                    } }"
                runat="server" />
        </div>
        <!-- # Level 3  Center -->
        
    </div>
    <!-- # Level 2 Center -->
    
</div>
<!-- Level 1 South -->

<!-- Level 1 Center -->
<div class="ui-layout-center ui-widget-content" id="layout-center-chungtuxuathang-cungpo" style="text-align:center; background:#F4F0EC; overflow:auto !important">
<div class="ui-widget-header" style="padding:8px">Thông tin packing list - invoice</div>
<style>
    .frm-packinglist{ padding-top:5px}
    .frm-packinglist tr td
    {
        padding:3px;	
    }
</style>
<script>
    $(document).ready(function() {


        $('#btn_add_from_po').click(function() {
			var id = "create_pkl_po";
            var title = "Tạo Packing List - Invoice Cùng PO";
			var form = "#frmFromPO";
			
			//if($(form + " #txtSoPackingList").val() == "" || $(form + " #txtSoPackingList").val() == " ")
			//{
			//	alert("Số Packing Lit/Invoice không được bỏ trống!");
			//}
            //else
			if ($(form + " #txtSoTau").val() == "" || $(form + " #txtSoTau").val() == " ")
			{
				alert("Số Tàu(M/V) không được bỏ trống!");
			}
			else if($(form + " #txtNoiDen").val() == "" || $(form + " #txtNoiDen").val() == " ")
			{
				alert("Nơi Đến(To) không được bỏ trống!");
			}
			else
			{
				$('body').append("<div title='" + title + "' id='" + id + "'>" +
                    "<h3 style='padding:10px' class='ui-state-highlight ui-corner-all'>" + "<div style='display:none' id='wait'><img style='width:30px; height:30px' src='iconcollection/loading.gif'/></div><div id='dialog_caution'>Có phải bạn muốn tạo Packing List - Invoice?</div></h3></div>");
				$("#create_pkl_po").dialog({
					modal: true
					, open: function(event, ui) {
						//hide close button.
						$(this).parent().children().children('.ui-dialog-titlebar-close').hide();
					}
					, buttons:
					[
						{
							id: "btn_po",
							text: "Có",
							click: function() {
								let data = new Object();
								//data["txtSoPackingList"] = $(form + " #txtSoPackingList").val();
								data["txtSoInvoice"] = $(form + " #txtSoInvoice").val();
								data["txtNgayLap"] = $(form + " #txtNgayLap").val();
								data["txtSoTau"] = $(form + " #txtSoTau").val();
								//data["selNoiDi"] = $(form + " #selNoiDi").val();
								data["txtNoiDen"] = $(form + " #txtNoiDen").val();
								data["txtSoVanDon"] = $(form + " #txtSoVanDon").val();
								data["txtNgayVanDon"] = $(form + " #txtNgayVanDon").val();
								data["txtHangHoa"] = $(form + " #txtHangHoa").val();
								data["txtHangHoaVn"] = $(form + " #txtHangHoaVn").val();
								data["txtDienGiaiCongThem"] = $(form + " #txtDienGiaiCongThem").val();
								data["txtGiaTriCongThem"] = $(form + " #txtGiaTriCongThem").val();
								data["txtDienGiaiTruLai"] = $(form + " #txtDienGiaiTruLai").val();
								data["txtGiaTriTruLai"] = $(form + " #txtGiaTriTruLai").val();
								data["arrayPhieuXuat"] = $('#grid_ds_xuatkho_cungpo').getGridParam('selarrrow').join(", ");

								$("#wait").css("display", "block");
								$("#btn_po").button("disable");
								$("#btn_close").button("disable");

								$.ajax({
									url: "Controllers/TaoPackingListController.ashx",
									type: "POST",
									data: { p: data },
									error: function (rs) {
									    $("#wait").css("display", "none");
										Popup("Error", 450, 300, rs.responseText);
									},
									success: function (rs) {
									    $("#wait").css("display", "none");
									    $("#btn_close span").text("Thoát");
									    $("#btn_close").button("enable");
										$('#create_pkl_po').find('#dialog_caution').html(rs);
									}
								});

							}
						},
						{
							id: "btn_close",
							text: "Không",
							click: function() {
								$(this).dialog("destroy").remove();
							}
						}
					]
				});
			}
        });
    });
</script>
    <div style="width:990px; margin:auto">
            <table id="frmFromPO" class="frm-packinglist" style="width:100%; text-align:left">
                <tr>
                    <%--<td>Số Packing List/Invoice<b style="color:red">(*)</b></td>
                    <td>:</td>--%>
                    <td><input id="txtSoPackingList" name="txtSoPackingList" type="hidden" /></td>
                    <%--<td>Số Invoice</td>
                    <td>:</td>--%>
                    <td><input id="txtSoInvoice" name="txtSoInvoice" type="hidden" required /></td>
                </tr>
                
                <tr>
                    <td>Ngày Lập</td>
                    <td>:</td>
                    <td>
                        <div class="datetime">
                            <input id="txtNgayLap" name="txtNgayLap" type="text"/>
                        </div>
                    </td>
                    <td>Số Tàu(M/V)<b style="color:red">(*)</b></td>
                    <td>:</td>
                    <td><input id="txtSoTau" name="txtSoTau" type="text" required /></td>
                </tr>
                
                <tr>
                    <td><%--Nơi Đi(From)--%></td>
                    <td></td>
                    <td>
                        <%--<% 
                            String selFrom = "select md_cangbien_id, ten_cangbien from md_cangbien order by ten_cangbien asc";
                            System.Data.SqlClient.SqlDataReader rdFrom = mdbc.ExecuteReader(selFrom);
                        %>
                        <select id="selNoiDi" name="selNoiDi">
                           <% if (rdFrom.HasRows)
                              {
                                  while (rdFrom.Read())
                                  {
                           %>     
                                <option value="<%= rdFrom[0] %>"><%= rdFrom[1]%></option>
                           <%     }
                              }
                              rdFrom.Close();
                           %>
                        </select>--%>
                    </td>
                    <td>Nơi Đến(To)<b style="color:red">(*)</b></td>
                    <td>:</td>
                    <td>
                         <input id="txtNoiDen" name="txtNoiDen" required />
                    </td>
                </tr>
                
                <tr>
                    <td>Số Vận Đơn(BL. No)</td>
                    <td>:</td>
                    <td><input id="txtSoVanDon" name="txtSoVanDon" type="text" /></td>
                    <td>Ngày Vận Đơn</td>
                    <td>:</td>
                    <td>
                        <div class="datetime">
                            <input id="txtNgayVanDon" name="txtNgayVanDon" type="text" />
                        </div>
                    </td>
                </tr>
                
                <%--<tr>
                    <td>Hàng Hóa(Commondity)</td>
                    <td>:</td>
                    <td><input id="txtHangHoa" name="txtHangHoa" type="text" /></td>
                    <td>Hàng Hóa VN</td>
                    <td>:</td>
                    <td><input id="txtHangHoaVn" name="txtHangHoaVn" type="text" /></td>
                </tr>--%>
                
                <tr>
                    <td>Diễn Giải Cộng Thêm</td>
                    <td>:</td>
                    <td><input id="txtDienGiaiCongThem" name="txtDienGiaiCongThem" type="text" /></td>
                    <td>Giá Trị Cộng Thêm</td>
                    <td>:</td>
                    <td><input id="txtGiaTriCongThem" name="txtGiaTriCongThem" type="text" value="0" /></td>
                </tr>
                
                <tr>
                    <td>Diễn Giải Trừ Lại</td>
                    <td>:</td>
                    <td><input id="txtDienGiaiTruLai" name="txtDienGiaiTruLai" type="text" /></td>
                    <td>Giá Trị Trừ Lại</td>
                    <td>:</td>
                    <td><input id="txtGiaTriTruLai" name="txtGiaTriTruLai" type="text" value="0" /></td>
                </tr>
                
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td rowspan="5" class="submit">
                        <button id="btn_add_from_po">Tạo Packing List - Invoice</button>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
    </div>
</div>
<!-- Level 1 Center -->


    