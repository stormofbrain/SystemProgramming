using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dz_1
{
    class Bank : INotifyPropertyChanged
    {
        int money;
        string name;
        int percent;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            writeData();
        }
        public int Money
        {
            get { return money; }
            set
            {
                if (value != money)
                {
                    money = value;
                    OnPropertyChanged("Money");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public int Percent
        {
            get { return percent; }
            set
            {
                if (value != percent)
                {
                    percent = value;
                    OnPropertyChanged("Percent");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void writeData()
        {
            var myUniqueFileName = string.Format(@"{0}.txt", Guid.NewGuid());
            string[] data = {" Class Bank","\tmoney: " + money, "\tname: " + name , "\tpercent: " + percent};
            System.IO.File.WriteAllLines(@"C:\Users\User\Documents\Visual Studio 2012\Projects\HomeWorksALL\WpfApplication123\dz_1\Bank data\" + myUniqueFileName, data);
        }
    }
}
