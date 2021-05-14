using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Connect6.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        #region notifyproperty
        public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(string propertyName)
        //{
        //    if(this.PropertyChanged != null)
        //    {
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
