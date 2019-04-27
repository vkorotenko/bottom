#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion

using Bottom.Models;
using Bottom.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bottom.Views
{
    /// <summary>
    /// Detail page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel _vm;

        /// <summary>
        /// Constructor with view model
        /// </summary>
        /// <param name="viewModel">View model</param>
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this._vm = viewModel;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            _vm = new ItemDetailViewModel(item);
            BindingContext = _vm;
        }
    }
}