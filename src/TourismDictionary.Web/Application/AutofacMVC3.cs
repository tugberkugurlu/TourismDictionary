using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using TourismDictionary.Data.DataAccess.SqlServer;
using TourismDictionary.Data.DataAccess.Infrastructure;

namespace TourismDictionary.Web.Application {

    internal class AutofacMVC3 {

        public static void Initialize() {

            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterType<WordRepository>().As<IWordRepository>();
            builder.RegisterType<MeaningRepository>().As<IMeaningRepository>();

            return
                builder.Build();
        }
    }
}