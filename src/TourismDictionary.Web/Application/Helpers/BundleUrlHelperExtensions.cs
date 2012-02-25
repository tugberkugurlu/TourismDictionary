using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourismDictionary.Web.Application.Helpers {

    public static class BundleUrlHelperExtensions {

        public static string Bundle(this UrlHelper @this, string bundleVirtualPath) {

            return
                System.Web.Optimization.BundleTable.Bundles.ResolveBundleUrl(bundleVirtualPath);
        }
    }
}