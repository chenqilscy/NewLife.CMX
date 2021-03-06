﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.CMX
{
    /// <summary>产品</summary>
    [Serializable]
    [DataObject]
    [Description("产品")]
    [BindIndex("IX_Product_InfoID", false, "InfoID")]
    [BindTable("Product", Description = "产品", ConnName = "CMX", DbType = DatabaseType.SqlServer)]
    public partial class Product : IProduct
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 10)]
        [BindColumn(1, "ID", "编号", null, "int", 10, 0, false)]
        public virtual Int32 ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private Int32 _InfoID;
        /// <summary>标题</summary>
        [DisplayName("标题")]
        [Description("标题")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn(2, "InfoID", "标题", null, "int", 10, 0, false)]
        public virtual Int32 InfoID
        {
            get { return _InfoID; }
            set { if (OnPropertyChanging(__.InfoID, value)) { _InfoID = value; OnPropertyChanged(__.InfoID); } }
        }

        private Decimal _Price;
        /// <summary>价格</summary>
        [DisplayName("价格")]
        [Description("价格")]
        [DataObjectField(false, false, true, 19)]
        [BindColumn(3, "Price", "价格", null, "money", 0, 0, false)]
        public virtual Decimal Price
        {
            get { return _Price; }
            set { if (OnPropertyChanging(__.Price, value)) { _Price = value; OnPropertyChanged(__.Price); } }
        }

        private String _PhotoPath;
        /// <summary>图片路径</summary>
        [DisplayName("图片路径")]
        [Description("图片路径")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn(4, "PhotoPath", "图片路径", null, "nvarchar(200)", 0, 0, true)]
        public virtual String PhotoPath
        {
            get { return _PhotoPath; }
            set { if (OnPropertyChanging(__.PhotoPath, value)) { _PhotoPath = value; OnPropertyChanged(__.PhotoPath); } }
        }

        private String _Specification;
        /// <summary>规格参数</summary>
        [DisplayName("规格参数")]
        [Description("规格参数")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn(5, "Specification", "规格参数", null, "ntext", 0, 0, true)]
        public virtual String Specification
        {
            get { return _Specification; }
            set { if (OnPropertyChanging(__.Specification, value)) { _Specification = value; OnPropertyChanged(__.Specification); } }
        }

        private String _Feature;
        /// <summary>功能特点</summary>
        [DisplayName("功能特点")]
        [Description("功能特点")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn(6, "Feature", "功能特点", null, "ntext", 0, 0, true)]
        public virtual String Feature
        {
            get { return _Feature; }
            set { if (OnPropertyChanging(__.Feature, value)) { _Feature = value; OnPropertyChanged(__.Feature); } }
        }

        private String _App;
        /// <summary>推荐应用</summary>
        [DisplayName("推荐应用")]
        [Description("推荐应用")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn(7, "App", "推荐应用", null, "ntext", 0, 0, true)]
        public virtual String App
        {
            get { return _App; }
            set { if (OnPropertyChanging(__.App, value)) { _App = value; OnPropertyChanged(__.App); } }
        }

        private String _Fitting;
        /// <summary>相关配件</summary>
        [DisplayName("相关配件")]
        [Description("相关配件")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn(8, "Fitting", "相关配件", null, "ntext", 0, 0, true)]
        public virtual String Fitting
        {
            get { return _Fitting; }
            set { if (OnPropertyChanging(__.Fitting, value)) { _Fitting = value; OnPropertyChanged(__.Fitting); } }
        }

        private String _Video;
        /// <summary>产品视频</summary>
        [DisplayName("产品视频")]
        [Description("产品视频")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn(9, "Video", "产品视频", null, "ntext", 0, 0, true)]
        public virtual String Video
        {
            get { return _Video; }
            set { if (OnPropertyChanging(__.Video, value)) { _Video = value; OnPropertyChanged(__.Video); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.InfoID : return _InfoID;
                    case __.Price : return _Price;
                    case __.PhotoPath : return _PhotoPath;
                    case __.Specification : return _Specification;
                    case __.Feature : return _Feature;
                    case __.App : return _App;
                    case __.Fitting : return _Fitting;
                    case __.Video : return _Video;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.InfoID : _InfoID = Convert.ToInt32(value); break;
                    case __.Price : _Price = Convert.ToDecimal(value); break;
                    case __.PhotoPath : _PhotoPath = Convert.ToString(value); break;
                    case __.Specification : _Specification = Convert.ToString(value); break;
                    case __.Feature : _Feature = Convert.ToString(value); break;
                    case __.App : _App = Convert.ToString(value); break;
                    case __.Fitting : _Fitting = Convert.ToString(value); break;
                    case __.Video : _Video = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得产品字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary>标题</summary>
            public static readonly Field InfoID = FindByName(__.InfoID);

            ///<summary>价格</summary>
            public static readonly Field Price = FindByName(__.Price);

            ///<summary>图片路径</summary>
            public static readonly Field PhotoPath = FindByName(__.PhotoPath);

            ///<summary>规格参数</summary>
            public static readonly Field Specification = FindByName(__.Specification);

            ///<summary>功能特点</summary>
            public static readonly Field Feature = FindByName(__.Feature);

            ///<summary>推荐应用</summary>
            public static readonly Field App = FindByName(__.App);

            ///<summary>相关配件</summary>
            public static readonly Field Fitting = FindByName(__.Fitting);

            ///<summary>产品视频</summary>
            public static readonly Field Video = FindByName(__.Video);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得产品字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary>编号</summary>
            public const String ID = "ID";

            ///<summary>标题</summary>
            public const String InfoID = "InfoID";

            ///<summary>价格</summary>
            public const String Price = "Price";

            ///<summary>图片路径</summary>
            public const String PhotoPath = "PhotoPath";

            ///<summary>规格参数</summary>
            public const String Specification = "Specification";

            ///<summary>功能特点</summary>
            public const String Feature = "Feature";

            ///<summary>推荐应用</summary>
            public const String App = "App";

            ///<summary>相关配件</summary>
            public const String Fitting = "Fitting";

            ///<summary>产品视频</summary>
            public const String Video = "Video";

        }
        #endregion
    }

    /// <summary>产品接口</summary>
    public partial interface IProduct
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>标题</summary>
        Int32 InfoID { get; set; }

        /// <summary>价格</summary>
        Decimal Price { get; set; }

        /// <summary>图片路径</summary>
        String PhotoPath { get; set; }

        /// <summary>规格参数</summary>
        String Specification { get; set; }

        /// <summary>功能特点</summary>
        String Feature { get; set; }

        /// <summary>推荐应用</summary>
        String App { get; set; }

        /// <summary>相关配件</summary>
        String Fitting { get; set; }

        /// <summary>产品视频</summary>
        String Video { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}