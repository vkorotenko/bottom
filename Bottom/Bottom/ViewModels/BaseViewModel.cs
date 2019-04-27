#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  16.04.2019 21:27
#endregion
using Bottom.Models;
using Bottom.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Bottom.ViewModels
{
    /// <summary>
    /// Base implementation of viewmodel's in application
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Data store of view model
        /// </summary>
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

        bool _isBusy = false;
        /// <summary>
        /// Model temporary busy
        /// </summary>
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        string _title = string.Empty;
        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        
        /// <summary>
        /// Magic of data binding
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="backingStore">Where to store value</param>
        /// <param name="value">Value</param>
        /// <param name="propertyName">Property name</param>
        /// <param name="onChanged">Handler</param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Handler for <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Property name</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
