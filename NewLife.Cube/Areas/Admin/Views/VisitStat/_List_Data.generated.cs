﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/VisitStat/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_VisitStat__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.VisitStat>>
    {
        public _Areas_Admin_Views_VisitStat__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as List<FieldItem>;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 22 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 781), Tuple.Create("\"", 820)
            
            #line 23 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 788), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 788), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 873), Tuple.Create("\"", 914)
            
            #line 24 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Year"))
            
            #line default
            #line hidden
, 880), false)
);

WriteLiteral(">年</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 966), Tuple.Create("\"", 1008)
            
            #line 25 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Month"))
            
            #line default
            #line hidden
, 973), false)
);

WriteLiteral(">月</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1060), Tuple.Create("\"", 1100)
            
            #line 26 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1067), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Day"))
            
            #line default
            #line hidden
, 1067), false)
);

WriteLiteral(">日</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1152), Tuple.Create("\"", 1193)
            
            #line 27 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1159), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Page"))
            
            #line default
            #line hidden
, 1159), false)
);

WriteLiteral(">页面</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1246), Tuple.Create("\"", 1288)
            
            #line 28 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Title"))
            
            #line default
            #line hidden
, 1253), false)
);

WriteLiteral(">标题</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1341), Tuple.Create("\"", 1383)
            
            #line 29 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Times"))
            
            #line default
            #line hidden
, 1348), false)
);

WriteLiteral(">次数</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1436), Tuple.Create("\"", 1478)
            
            #line 30 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Users"))
            
            #line default
            #line hidden
, 1443), false)
);

WriteLiteral(">用户</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1531), Tuple.Create("\"", 1571)
            
            #line 31 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1538), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("IPs"))
            
            #line default
            #line hidden
, 1538), false)
);

WriteLiteral(">IP</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1624), Tuple.Create("\"", 1666)
            
            #line 32 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1631), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Error"))
            
            #line default
            #line hidden
, 1631), false)
);

WriteLiteral(">错误</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1719), Tuple.Create("\"", 1760)
            
            #line 33 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1726), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Cost"))
            
            #line default
            #line hidden
, 1726), false)
);

WriteLiteral(">耗时</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1813), Tuple.Create("\"", 1860)
            
            #line 34 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1820), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1820), false)
);

WriteLiteral(">创建时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1915), Tuple.Create("\"", 1962)
            
            #line 35 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1922), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1922), false)
);

WriteLiteral(">更新时间</a></th>\r\n");

            
            #line 36 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
             if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 39 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 43 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
         foreach (var entity in Model)
        {
            var y = entity.Year > 0 ? entity.Year + "" : "全部";
            var m = entity.Month > 0 ? entity.Month + "" : "";
            var d = entity.Day > 0 ? entity.Day + "" : "";

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 49 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2605), Tuple.Create("\"", 2623)
            
            #line 51 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2613), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2613), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 52 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 53 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(y);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 55 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(m);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 56 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(d);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 57 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Page);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 58 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Times.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Users.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 61 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.IPs.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 62 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Error.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 63 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                                  Write(entity.Cost.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(" ms</td>\r\n                <td>");

            
            #line 64 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 65 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 66 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                 if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 69 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 71 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 73 "..\..\Areas\Admin\Views\VisitStat\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
