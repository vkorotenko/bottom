#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bottom.Services
{
    /// <summary>
    /// Data store interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataStore<T>
    {
        /// <summary>
        /// Add element to datastore
        /// </summary>
        /// <param name="item">Added element</param>
        /// <returns></returns>
        Task<bool> AddItemAsync(T item);
        
        /// <summary>
        /// Update element
        /// </summary>
        /// <param name="item">Element</param>
        /// <returns></returns>
        Task<bool> UpdateItemAsync(T item);
        
        /// <summary>
        /// Delete element
        /// </summary>
        /// <param name="id">Element</param>
        /// <returns></returns>
        Task<bool> DeleteItemAsync(string id);

        /// <summary>
        /// Get element by primary key
        /// </summary>
        /// <param name="id">Key</param>
        /// <returns></returns>
        Task<T> GetItemAsync(string id);
        
        /// <summary>
        /// Get all elements
        /// </summary>
        /// <param name="forceRefresh">Forse refresh datasorce.</param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
