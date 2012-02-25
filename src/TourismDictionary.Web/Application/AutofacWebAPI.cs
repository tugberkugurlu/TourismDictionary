using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Http;
using Autofac.Integration.Mvc;
using System.Collections;
using TourismDictionary.Data.DataAccess.SqlServer;
using TourismDictionary.Data.DataAccess.Infrastructure;

namespace TourismDictionary.Web.Application {

    internal class AutofacWebAPI {

        public static void Initialize() {
            var builder = new ContainerBuilder();
            GlobalConfiguration.Configuration.ServiceResolver.SetResolver(
                new AutofacWebAPIDependencyResolver(RegisterServices(builder))
            );
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterType<WordRepository>().As<IWordRepository>();
            builder.RegisterType<MeaningRepository>().As<IMeaningRepository>();

            return
                builder.Build();
        }
    }
}