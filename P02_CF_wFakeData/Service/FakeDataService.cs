using Bogus;
using P02_CF_wFakeData.Models;

using P02_CF_wFakeData.Models;

namespace P02_CF_wFakeData.Service
{
    public class FakeDataService : IFakeDataService
    {
        public List<List<Product>> GetFakeProductList()
        {
			try
			{
				var faker = new Faker<Product>();

				faker.RuleFor(p => p.ProductName, pd => pd.Commerce.ProductName());

				faker.RuleFor(p => p.ProductBarCode, pd => pd.Commerce.Ean13());

				faker.RuleFor(p => p.ProductPrice, pd => pd.Random.Decimal(1, 1000));


				var products = faker.Generate(1000);

				var batches=products
					.Select((p,i) => (Product:p,Index:i))
					.GroupBy(x => x.Index / 100 )
					.Select(g=> g.Select(x=> x.Product).ToList())
					.ToList();

				return batches;

			}
			catch (Exception)
			{

			}

			return null;
        }
    }
}
