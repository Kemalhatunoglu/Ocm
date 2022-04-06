using Autofac;
using Ocm.Business.Abstract;
using Ocm.Business.Concrete;
using Ocm.DataAccess.Abstract;
using Ocm.DataAccess.Concrete;

namespace Ocm.Business.DependencyResolvers.Autofac
{
    public class RegisterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<OrderTransactionManager>().As<IOrderTransactionService>();
            builder.RegisterType<EfOrderTransactionDal>().As<IOrderTransactionDal>();

            builder.RegisterType<ShipmentManager>().As<IShipmentService>();
            builder.RegisterType<EfShipmentDal>().As<IShipmentDal>();
        }
    }
}
