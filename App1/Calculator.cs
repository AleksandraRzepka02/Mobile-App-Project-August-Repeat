using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Calculator : INotifyPropertyChanged
    {
        private String firstName;
        private String secondName;

        public event PropertyChangedEventHandler PropertyChanged;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }   // FirstName

        public String SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }   // SecondName

        public String Love
        {
            get { return firstName + " " + secondName; }
        }   // Sum

        private void OnPropertyChanged(String info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
    }   // Calculator
}   // App1
