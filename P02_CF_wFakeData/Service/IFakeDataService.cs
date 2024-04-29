using P02_CF_wFakeData.Models;

namespace P02_CF_wFakeData.Service
{
    public interface IFakeDataService
    {
        public List<List<Product>> GetFakeProductList();
    }
}
