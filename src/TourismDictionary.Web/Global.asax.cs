using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TourismDictionary.Web.Application;
using Autofac;
using TourismDictionary.Data.DataAccess.Infrastructure;
using TourismDictionary.Data.DataAccess.SqlServer;
using System.Collections;
using Ninject;

namespace TourismDictionary.Web {

    public class MvcApplication : System.Web.HttpApplication {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "default", action = "index", id = UrlParameter.Optional }
            );
        }

        private void Configure(HttpConfiguration httpConfiguration) {

            httpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void RegisterDependenciesViaNinject(HttpConfiguration httpConfiguration) {

            var kernel = new StandardKernel();
            kernel.Bind<IWordRepository>().To<WordRepository>();
            kernel.Bind<IMeaningRepository>().To<MeaningRepository>();

            httpConfiguration.ServiceResolver.SetResolver(
                t => kernel.TryGet(t),
                t => kernel.GetAll(t));
        }

        private void RegisterBundles(BundleCollection bundleCollection) {

            #region _global js bundle

            var globalJsBundle = new Bundle("~/assets/js/global", new JsMinify());

            globalJsBundle.AddFile("~/assets/js/jquery-1.7.1.min.js");
            globalJsBundle.AddFile("~/assets/js/jquery.validate.min.js");
            globalJsBundle.AddFile("~/assets/js/jquery.validate.unobtrusive.min.js");
            globalJsBundle.AddFile("~/assets/js/knockout-2.0.0.js");
            globalJsBundle.AddFile("~/assets/js/bootstrap.min.js");

            bundleCollection.Add(globalJsBundle);

            #endregion

            #region _modernizr js bundle

            var modernizrJsBundle = new Bundle("~/assets/js/modernizr", new JsMinify());

            modernizrJsBundle.AddFile("~/assets/js/modernizr-2.5.2.js");

            bundleCollection.Add(modernizrJsBundle);

            #endregion

            #region _global css bundle

            var globalCSSBundle = new Bundle("~/assets/css/global", new CssMinify());

            globalCSSBundle.AddFile("~/assets/css/bootstrap.css");
            globalCSSBundle.AddFile("~/assets/css/screen.css");
            globalCSSBundle.AddFile("~/assets/css/forms.css");
            globalCSSBundle.AddFile("~/assets/css/bootstrap-responsive.css");
            globalCSSBundle.AddFile("~/assets/css/responsive.css");
            //globalCSSBundle.AddFile("~/assets/css/print.css");

            bundleCollection.Add(globalCSSBundle);


            #endregion
        }

        protected void Application_Start() {

            Configure(GlobalConfiguration.Configuration);
            //RegisterDependenciesViaNinject(GlobalConfiguration.Configuration);
            AutofacWebAPI.Initialize();

            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            RegisterBundles(BundleTable.Bundles);
        }

    }
}