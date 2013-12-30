﻿using System;
using System.Collections.Generic;
using System.Linq;
using NewLife.CMX.Config;
using NewLife.CMX.TemplateEngine;
using XCode;

namespace NewLife.CMX.Web
{
    public class LeftMenuContent
    {
        /// <summary>获取菜单内容</summary>
        /// <returns></returns>
        public static String GetContent(Channel channel, Int32 CategoryID)
        {
            //var channel = Channel.FindBySuffix(Suffix);
            var dic = new Dictionary<String, String>();
            //var classname = channel.Model.ClassName;
            var id = "0";

            //var eop = EntityFactory.CreateOperate(classname);
            var eop = EntityFactory.CreateOperate(channel.Model.Provider.TitleType);

            if (CategoryID != 0)
            {
                var entity = eop.Find("ID", CategoryID) as IEntityTree;
                if (entity != null && entity.Parent != null) id = entity.Parent["ID"].ToString();
            }

            var list = eop.FindAll("ParentID", 0);

            dic.Add("ModelAddress", channel.ListTemplate);
            dic.Add("SelectedCategory", id);
            dic.Add("MenuTitle", channel.Name);

            var engine = new CMXEngine(TemplateConfig.Current, WebSettingConfig.Current);
            engine.ListCategory = list.ToList().OrderBy(e => e["ID"]).ToList().ConvertAll<IEntityTree>(e => e as IEntityTree);
            engine.ArgDic = dic;
            engine.Suffix = channel.Suffix;

            return engine.Render(TemplateConfig.Current.LeftAddress);
        }
    }
}