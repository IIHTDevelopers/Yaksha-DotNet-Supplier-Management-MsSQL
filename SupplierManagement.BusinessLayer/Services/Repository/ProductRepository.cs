﻿using SupplierManagement.BusinessLayer.ViewModels;
using SupplierManagement.DataLayer;
using SupplierManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagement.BusinessLayer.Services.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SupplierDbContext _supplierDbContext;
        public ProductRepository(SupplierDbContext supplierDbContext)
        {
            _supplierDbContext = supplierDbContext;
        }

        public async Task<ProductData> AddProduct(ProductData productData)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<ProductData> FindProductById(int productId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<ProductData> UpdateProduct(ProductViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductData>> ListAllProducts()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<ProductData> DeleteProductById(int productId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}