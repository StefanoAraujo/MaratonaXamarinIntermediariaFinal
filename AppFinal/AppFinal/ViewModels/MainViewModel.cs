using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _textProperty = "Initial Text";

        public string TextProperty
        {
            get { return _textProperty; }
            set
            {
                _textProperty = value;
                OnPropertyChanged();
            }
        }
    }
}
