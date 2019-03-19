using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dcompras.Models;

namespace dcompras.Services
{
    public class MockDataStore : IDataStore<Purchase>
    {
        List<Purchase> purchases;

        public MockDataStore()
        {
            purchases = new List<Purchase>();
            var mockItems = new List<Purchase>
            {
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
                new Purchase { IdPurchase = Guid.NewGuid().ToString(), Date = DateTime.Now, Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                purchases.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Purchase item)
        {
            purchases.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Purchase item)
        {
            var oldItem = purchases.Where((Purchase arg) => arg.IdPurchase == item.IdPurchase).FirstOrDefault();
            purchases.Remove(oldItem);
            purchases.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = purchases.Where((Purchase arg) => arg.IdPurchase == id).FirstOrDefault();
            purchases.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Purchase> GetItemAsync(string id)
        {
            return await Task.FromResult(purchases.FirstOrDefault(s => s.IdPurchase == id));
        }

        public async Task<IEnumerable<Purchase>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(purchases);
        }
    }
}