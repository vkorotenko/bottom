#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bottom.ViewModels
{
    /// <summary>
    /// About view model
    /// </summary>
    public class AboutViewModel : BaseViewModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://vkorotenko.ru")));
        }
        /// <summary>
        /// Open me home site page
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }
}