namespace SalesMKDE.Backend.Models
{
    using SalesMKDE.Domain.Models;
    
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<SalesMKDE.Common.Models.Product> Products { get; set; }
    }
    
}