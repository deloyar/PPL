using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRP.PPL.Data.MIS.MasterDetail2
{
    public abstract class NotifyPropertyChanged: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetField<T>(T item, ref T field, T value)
        {
            field = value;
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(item)));
            }
        }
    }
}
