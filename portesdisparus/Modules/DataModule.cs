using System;
using Autofac;
using PeopLost.Data;
using PeopLost.Core.Data;
using portesdisparus.Controllers;
using PeopLost.Service;
using Autofac.Core;
using WebGrease;
using PeopLost.Service.Alertes;
using PeopLost.Service.Maps;
using PeopLost.Service.Persons;
using PeopLost.Service.Comments;
using PeopLost.Service.Pictures;
using PeopLost.Service.Members;


namespace PeopLost.Web
{
    class DataModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new PeopLostObjectContext()).As<IDbContext>().InstancePerRequest();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<AlertService>().As<IAlertService>().InstancePerRequest();
            builder.RegisterType<CommentService>().As<ICommentService>().InstancePerRequest();
            builder.RegisterType<PersonService>().As<IPersonService>().InstancePerRequest();
            builder.RegisterType<MemberService>().As<IMemberService>().InstancePerRequest(); 
            builder.RegisterType<PersonPointGeoService>().As<IPersonPointGeoService>().InstancePerRequest();
            builder.RegisterType<PictureService>().As<IPictureService>().InstancePerRequest();
            //builder.RegisterType<AlertController>()
              //  .WithParameter(ResolvedParameter.ForNamed<ICacheManager>()); ;

            base.Load(builder);
        }
    }
}
