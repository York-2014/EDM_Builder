using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDM_Builder.Entity
{
    /// <summary>
    /// 模版A
    /// </summary>
    public class TemplateAEntity
    {
        /// <summary>
        /// 模版名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 模版Html路径
        /// </summary>
        public string HtmlPath { get; set; }
    }

    /// <summary>
    /// 模版A的Item
    /// </summary>
    public class TemplateA_ItemEntity
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 当前价格
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 原价格
        /// </summary>
        public string Trick { get; set; }

        /// <summary>
        /// 购买连接
        /// </summary>
        public string BuyNowLnk { get; set; }
    }
}
