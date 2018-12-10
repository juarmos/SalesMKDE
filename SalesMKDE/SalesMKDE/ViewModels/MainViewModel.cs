using System;
using System.Collections.Generic;
using System.Text;

namespace SalesMKDE.ViewModels
{
    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel(); 
        }
    }
}
