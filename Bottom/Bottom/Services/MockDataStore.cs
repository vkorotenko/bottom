#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using Bottom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bottom.Services
{
    /// <summary>
    /// Fake data source
    /// </summary>
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> _items;
        /// <summary>
        /// Default constructor. Fill datasorce 
        /// </summary>
        public MockDataStore()
        {
            _items = new List<Item>();


            for (int i = 0; i < 20; i++)
            {
                _items.Add(new Item
                {
                    Id = i.ToString(),
                    Text = $"Item {i}",
                    Description = $"This is description for runtime generated item with Id: {i}."
                });
            }            
        }
        
        /// <summary>
        ///  Add element to datasource
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<bool> AddItemAsync(Item item)
        {
            _items.Add(item);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Update element
        /// </summary>
        /// <param name="item">Element</param>
        /// <returns></returns>
        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = _items.FirstOrDefault(arg => arg.Id == item.Id);
            _items.Remove(oldItem);
            _items.Add(item);

            return await Task.FromResult(true);
        }
        /// <summary>
        /// Delete element
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _items.FirstOrDefault(arg => arg.Id == id);
            _items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        /// <summary>
        /// Get element by id
        /// </summary>
        /// <param name="id">Id of element</param>
        /// <returns></returns>
        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(_items.FirstOrDefault(s => s.Id == id));
        }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <param name="forceRefresh">Get data forse</param>
        /// <returns></returns>
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}