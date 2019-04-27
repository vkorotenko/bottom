#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using Bottom.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Bottom
{
    /// <summary>
    /// Main application class
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }
        /// <summary>
        /// OnStart method. Best point to run you code
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }
        /// <summary>
        /// Handle when your app sleeps
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
        /// <summary>
        /// Handle when your app resumes
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
