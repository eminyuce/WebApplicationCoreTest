using System.Collections.Generic;
using WebApplicationCoreTest.Data.Entities;

namespace WebApplicationCoreTest.Services.DB.Repositories
{
    public interface IProductRepository
    {
        void DeleteNwmProduct(int id);
        NwmProduct GetNwmProduct(int id);
        List<NwmProduct> GetNwmProducts();
        int SaveOrUpdateNwmProduct(NwmProduct item);
    }
}