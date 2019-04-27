using Bottom.Models;
using Bottom.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bottom.Views
{
    /// <summary>
    /// Items page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _vm;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _vm = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
        /// <summary>
        /// Handler to load page
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_vm.Items.Count == 0)
                _vm.LoadItemsCommand.Execute(null);
        }
    }
}