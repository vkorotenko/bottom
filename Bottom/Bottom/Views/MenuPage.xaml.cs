#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using Bottom.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bottom.Views
{
    /// <summary>
    /// Menu page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        static MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> _menuItems;
        /// <summary>
        /// Initialize menu and select first item.
        /// </summary>
        public MenuPage()
        {
            InitializeComponent();

            _menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = _menuItems;

            ListViewMenu.SelectedItem = _menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}