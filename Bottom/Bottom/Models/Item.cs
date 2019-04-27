#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
namespace Bottom.Models
{
    /// <summary>
    /// Element class, represent item on main screen
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Element title
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Element description
        /// </summary>
        public string Description { get; set; }
    }
}