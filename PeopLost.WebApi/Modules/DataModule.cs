using System;
using Autofac;
using PeopLost.Data;
using PeopLost.Core.Data;
using PeopLost.WebApi.Controllers;
using PeopLost.Service;
using Autofac.Core;
using WebGrease;
using PeopLost.Service.Alertes;
using PeopLost.Service.Maps;
using PeopLost.Service.Comments;
using PeopLost.Service.Countries;
using PeopLost.Service.Persons;
using PeopLost.Service.Pictures;

namespace PeopLost.WebApi
{
    class DataModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            
            builder.Register(c => new PeopLostObjectContext()).As<IDbContext>().InstancePerRequest();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<AlertService>().As<IAlertService>().InstancePerLifetimeScope();
            builder.RegisterType<CommentService>().As<ICommentService>().InstancePerLifetimeScope();
            builder.RegisterType<PersonPointGeoService>().As<IPersonPointGeoService>().InstancePerRequest();
            builder.RegisterType<CountryService>().As<ICountryService>().InstancePerRequest();
            builder.RegisterType<PersonService>().As<IPersonService>().InstancePerRequest();
            builder.RegisterType<PictureService>().As<IPictureService>().InstancePerRequest();
            
            //    .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static")); ;

            base.Load(builder);
        }
    }
}
