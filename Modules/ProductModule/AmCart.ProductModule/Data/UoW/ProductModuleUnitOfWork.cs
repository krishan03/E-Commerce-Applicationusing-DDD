using AmCart.Core.Data.Transaction;
using AmCart.Core.ExceptionManagement;
using AmCart.ProductModule.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCart.ProductModule.Data.UoW
{
   public  class ProductModuleUnitOfWork : UnitOfWork, IProductModuleUnitOfWork
    {
        /// <summary>
        /// The service provider
        /// </summary>
        private readonly IServiceProvider ServiceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyProjectUnitOfWork"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductModuleUnitOfWork(ProductModuleDataContext dbContext, IExceptionManager exceptionManager)
            : base(dbContext, exceptionManager)
        {
            //ServiceProvider = serviceProvider;
        }

        ///// <summary>
        ///// BookRepository holder
        ///// </summary>
        //private ProductRepository productRepository;

        ///// <summary>
        ///// Gets the BookRepository repository.
        ///// </summary>
        ///// <value>
        ///// The BookRepository repository.
        ///// </value>
        //IProductRepository IApplicationUnitOfWork.ProductRepository
        //{
        //    get
        //    {
        //        return ServiceProvider.GetService<IProductRepository>();
        //    }
        //}

    }
}
