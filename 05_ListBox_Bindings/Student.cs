using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_ListBox_Bindings
{
    internal class Student : INotifyPropertyChanged
    {
        private string name;
        private int age;
        public string Name 
        {
            get { return name; }

            set 
            { 
                name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            } 
        }       
        public int Age
        {
            get { return age; }
            set 
            {
                age = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }
        public string FullInfo => Name + " : " + Age;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
           
            return $" {Name } : {Age}";
        }
    }
}
