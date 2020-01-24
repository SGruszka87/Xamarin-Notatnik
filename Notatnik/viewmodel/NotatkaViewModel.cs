using Notatnik.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Notatnik.viewmodel
{
    public class NotatkaViewModel : BaseViewModel
    {

        private NotatkaModel _notatka;
        public NotatkaModel Notatka
        {
            get
            {
                return _notatka;
            }
            set
            {
                _notatka = value;
                RaisePropertyChanged(nameof(Notatka));
            }
        }
        public NotatkaViewModel()
        {
            if (Notatkas == null)
                Notatkas = new ObservableCollection<NotatkaModel>();

        }

        public bool DodajPozycje(string tytul, string opis)
        {

            Notatkas.Add(new NotatkaModel() 
            { 
                Tytul = tytul, 
                Opis = opis 
            });
            return true;
        }


        private ObservableCollection<NotatkaModel> _notatkas;
        public ObservableCollection<NotatkaModel> Notatkas
        {
            get
            {
                return _notatkas;
            }
            set
            {
                _notatkas = value;
                RaisePropertyChanged(nameof(Notatkas));
            }
        }
    }
}
