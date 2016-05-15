using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Tripgo.App_Start
{
    public class SiteGlobal
    {
        static public string RootTitle { get; set; }

        /// <summary>
        /// Header prefix on root page.
        /// </summary>
        static public string RootPrefix { get; set; }

        /// <summary>
        /// Header main part on root page.
        /// </summary>
        static public string RootHeader { get; set; }

        /// <summary>
        /// Main site Url with http://.
        /// </summary>
        static public string BaseUrl { get; set; }

        static SiteGlobal()
        {
            // Cache all these values in static properties.
            RootTitle = WebConfigurationManager.AppSettings["SiteTitle"];
            RootPrefix = WebConfigurationManager.AppSettings["SitePrefix"];
            RootHeader = WebConfigurationManager.AppSettings["SiteHeader"];
            BaseUrl = WebConfigurationManager.AppSettings["BaseUrl"];
        }
    }
}