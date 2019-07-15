using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfValueConversion
{
    // Main Data bound class
    public class MainDataClass : ObservableObject
    {
        private string _color;

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                if (value.ToUpper() != _color)
                {
                    _color = value.ToUpper().Trim();
                    OnPropertyChanged();
                }
            }
        }
    }
}
