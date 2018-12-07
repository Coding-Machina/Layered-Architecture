using Application.Abstracts;
using Application.MongoOperations;
using Application.SqlOperations;
using Application.TransferOperations;
using DataAccess.Abstract;
using Domain.Abstracts;
using Domain.MongoOperations;
using Domain.SqlOperations;
using Domain.TransferOperations;
using ElasticSearchOperations;
using MongoDataOperations;
using Ninject;
using SqlDataOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class BindingClass
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IDataAccessSqlMethods>().To<DataAccessSqlMethods>();
            kernel.Bind<IDataAccessMongoMethods>().To<DataAccessMongoMethods>();
            kernel.Bind<IDatatAccessElasticMethods>().To<DataAccessElasticMethods>();

            kernel.Bind<IDomainSqlMethods>().To<DomainSqlMethods>();
            kernel.Bind<IDomainMongoMethods>().To<DomainMongoMethods>();
            kernel.Bind<IDomainTransferMethods>().To<DomainTransferMethods>();

            kernel.Bind<IApplicationSqlMethods>().To<ApplicationSqlMethods>();
            kernel.Bind<IApplicationMongoMethods>().To<ApplicationMongoMethods>();
            kernel.Bind<IApplicationTransferMethods>().To<ApplicationTransferMethods>();
        }
    }
}
