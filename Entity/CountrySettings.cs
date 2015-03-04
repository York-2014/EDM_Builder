using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDM_Builder.Entity
{
    public class CountrySettings
    {
        /// <summary>
        /// 邮件地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 网站地址
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 货币符号
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Logo图片地址
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Support WebSite
        /// </summary>
        public string Support { get; set; }

        /// <summary>
        /// Twitter Link
        /// </summary>
        public string Twitter { get; set; }

        /// <summary>
        /// Facebook Link
        /// </summary>
        public string Facebook { get; set; }

        /// <summary>
        /// Unsubscribe Link
        /// </summary>
        public string Unsubscribe { get; set; }

        public string ViewMoreImgPath { get; set; }

        public string ViewDealString { get; set; }

        public string FootStringLineOne { get; set; }

        public string FootStringLineTwo { get; set; }

        public string UnsubscribeString { get; set; }
    }
}
