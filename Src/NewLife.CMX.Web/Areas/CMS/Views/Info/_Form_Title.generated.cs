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
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 4 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    using NewLife.CMX.Web;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Info/_Form_Title.cshtml")]
    public partial class _Areas_CMS_Views_Info__Form_Title_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IInfo>
    {
        public _Areas_CMS_Views_Info__Form_Title_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var fields = ViewBag.Fields as List<FieldItem>;
    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;


    var inf = Model as IInfo;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-2 col-md-2 col-lg-2\"");

WriteLiteral(">标题</label>\r\n    <div");

WriteLiteral(" class=\"col-xs-5 col-sm-5 col-md-5 col-lg-5\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
   Write(Html.ForEditor("Title", inf.Title, typeof(String)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 20 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
     if (!isNew && Model.Category != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-2 col-sm-2 col-md-2 col-lg-2\"");

WriteLiteral("></div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"col-xs-1 col-sm-1 col-md-1 col-lg-1\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 753), Tuple.Create("\"", 777)
            
            #line 24 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
, Tuple.Create(Tuple.Create("", 760), Tuple.Create<System.Object, System.Int32>(this.GetUrl(inf)
            
            #line default
            #line hidden
, 760), false)
);

WriteLiteral(" class=\"btn btn-info btn-sm\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"glyphicon glyphicon-search\"");

WriteLiteral("></i>\r\n                预览\r\n            </a>\r\n        </div>\r\n");

            
            #line 29 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-2 col-sm-2 col-md-2 col-lg-2\"");

WriteLiteral(">分类</label>\r\n    <div");

WriteLiteral(" class=\"col-xs-4 col-sm-4 col-md-4 col-lg-4\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
          
            var data = new SelectList(Category.Root.AllChilds, "ID", "TreeNodeText", inf.CategoryID);
        
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 37 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
   Write(Html.DropDownList("CategoryID", data, new { @class = "multiselect" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-xs-3 col-sm-3 col-md-3 col-lg-3\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">访问量</label>\r\n        <span>");

            
            #line 41 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
         Write(inf.Views);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">版本</label>\r\n        <span>");

            
            #line 43 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
         Write(inf.Version);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-xs-2 col-md-2\"");

WriteLiteral(">编码</label>\r\n    <div");

WriteLiteral(" class=\"col-xs-5 col-sm-5 col-md-5 col-lg-5\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 49 "..\..\Areas\CMS\Views\Info\_Form_Title.cshtml"
   Write(Html.ForEditor("Code", inf.Code, typeof(String)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591