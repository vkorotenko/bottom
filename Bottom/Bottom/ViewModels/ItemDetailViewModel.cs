#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using Bottom.Models;

namespace Bottom.ViewModels
{
    /// <summary>
    /// Detail view model
    /// </summary>
    public class ItemDetailViewModel : BaseViewModel
    {
        /// <summary>
        /// Item
        /// </summary>
        public Item Item { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="item">Element</param>
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
