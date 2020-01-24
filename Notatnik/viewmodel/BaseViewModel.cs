using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Notatnik.viewmodel
{
    public class BaseViewModel
    {
        internal void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
