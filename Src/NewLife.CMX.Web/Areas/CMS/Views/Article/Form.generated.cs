﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
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
    
    #line 1 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using NewLife.CMX.Web;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Article/Form.cshtml")]
    public partial class _Areas_CMS_Views_Article_Form_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_CMS_Views_Article_Form_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\CMS\Views\Article\Form.cshtml"
  
    var fact = EntityFactory.CreateOperate(ViewData.ModelMetadata.ModelType);
    var fields = ViewBag.Fields as List<FieldItem>;
    var isNew = (Model as IEntity).IsNullKey;
    var entity = Model as IEntity;
    var article = Model as IArticle;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Areas\CMS\Views\Article\Form.cshtml"
        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\CMS\Views\Article\Form.cshtml"
         if (ViewBag.StatusMessage != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-success alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                <strong>");

            
            #line 19 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n            </div>\r\n");

            
            #line 21 "..\..\Areas\CMS\Views\Article\Form.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 22 "..\..\Areas\CMS\Views\Article\Form.cshtml"
         using (Html.BeginForm((isNew ? "Add" : "Edit"), null, new { id = Model[fact.Unique.Name] }))
        {
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">标题</label>\r\n                <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(Article._.Title, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    &nbsp;\r\n");

            
            #line 31 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                     if (!isNew)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1329), Tuple.Create("\"", 1357)
            
            #line 33 "..\..\Areas\CMS\Views\Article\Form.cshtml"
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(this.GetUrl(article)
            
            #line default
            #line hidden
, 1336), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                            预览\r\n                        </a>\r\n");

            
            #line 36 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 40 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                  var item = Article._.CategoryID;
            
            #line default
            #line hidden
WriteLiteral("\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                      
            var data = new SelectList(ArticleCategory.Root.AllChilds, "ID", "TreeNodeText", article.CategoryID);
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.DropDownList(item.Name, data, new { @class = "multiselect" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">访问量</label>\r\n                    <span>");

            
            #line 50 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                     Write(article.Views);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">版本</label>\r\n                    <span>");

            
            #line 52 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                     Write(article.Version);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">来源</label>\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForDropDownList(Article._.SourceID, Source.FindAllVisible(), null, false));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                    名称：");

            
            #line 61 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                  Write(Html.ForEditor(Article._.SourceName, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                    地址：");

            
            #line 64 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                  Write(Html.ForEditor(Article._.SourceUrl, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">内容</label>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3026), Tuple.Create("\"", 3067)
, Tuple.Create(Tuple.Create("", 3032), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ueditor/ueditor.config.js")
, 3032), false)
);

WriteLiteral("></script>\r\n                    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3107), Tuple.Create("\"", 3149)
, Tuple.Create(Tuple.Create("", 3113), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ueditor/ueditor.all.min.js")
, 3113), false)
);

WriteLiteral("></script>\r\n                    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3189), Tuple.Create("\"", 3232)
, Tuple.Create(Tuple.Create("", 3195), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ueditor/lang/zh-cn/zh-cn.js")
, 3195), false)
);

WriteLiteral("></script>\r\n                    <script");

WriteLiteral(" id=\"ContentText\"");

WriteLiteral(" name=\"ContentText\"");

WriteLiteral(" type=\"text/plain\"");

WriteLiteral(" style=\"width:800px;height:400px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 74 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   Write(Html.Raw(article.ContentText));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </script>\r\n                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                        //实例化编辑器
                        //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
                        var ue = UE.getEditor('ContentText');
                    </script>
                </div>
            </div>
");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">摘要</label>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 86 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.TextArea(Article._.Remark, article.Remark, 5, 100, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 90 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   item = Article._.Top;
            
            #line default
            #line hidden
WriteLiteral("\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 91 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(item, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 95 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                
            
            #line default
            #line hidden
            
            #line 95 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   item = Article._.Recommend;
            
            #line default
            #line hidden
WriteLiteral("\r\n                <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">");

            
            #line 96 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 98 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(item, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 100 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                
            
            #line default
            #line hidden
            
            #line 100 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   item = Article._.Hot;
            
            #line default
            #line hidden
WriteLiteral("\r\n                <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">");

            
            #line 101 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 103 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(item, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 105 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                
            
            #line default
            #line hidden
            
            #line 105 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                   item = Article._.Slide;
            
            #line default
            #line hidden
WriteLiteral("\r\n                <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">");

            
            #line 106 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <div");

WriteLiteral(" class=\"col-md-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(item, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">封面</label>\r\n                <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 114 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(Article._.Cover, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">发布时间</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2 input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 120 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForEditor(Article._.PublishTime, entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 123 "..\..\Areas\CMS\Views\Article\Form.cshtml"
            
            
            #line default
            #line hidden
            
            #line 123 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.Partial("_UserTime", Model as IEntity));

            
            #line default
            #line hidden
            
            #line 123 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                        
            
            
            #line default
            #line hidden
            
            #line 124 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.Partial("_Form_Action", isNew));

            
            #line default
            #line hidden
            
            #line 124 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
