using Autofac;
using Business.Abstract;
using Business.Abstract.Authentication;
using Business.Concrete;
using Business.Concrete.Authentication;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//.NET tabanlı framework için geliştirilmiş IOC (Inversion Of Control) container’dır.


namespace Business.DependencyResolves.Autofac
{
    //autofac'i program.cs ye eklememiz gerekir.
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //ben IProductService istersem bana ProductManager'i getir.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>().SingleInstance();
        }
    }
}
