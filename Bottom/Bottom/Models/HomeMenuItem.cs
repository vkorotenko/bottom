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
    /// Menu item enum
    /// </summary>
    public enum MenuItemType
    {
        /// <summary>Browse page</summary>
        Browse,
        /// <summary>About page</summary>
        About
    }
    /// <summary>
    /// Home menu item.
    /// </summary>
    public class HomeMenuItem
    {
        /// <summary>
        /// Element id
        /// </summary>
        public MenuItemType Id { get; set; }

        /// <summary>
        /// Menu item title
        /// </summary>
        public string Title { get; set; }
    }
}
