using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _04_List_Controls_Collection_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //INotifyCollectionChanged
        ObservableCollection<Person> people = null;
        public MainWindow()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>()
            {
                new Person(){ Name="Bogdan", SurName="Bogdan", Birth = new DateTime(1990,7,21)},
                new Person(){ Name="Victoria", SurName="Ivanchuk", Birth = new DateTime(2000,9,30)},
                new Person(){ Name="Sasha", SurName="Popchyk", Birth = new DateTime(1989,8,12)}
            };
            comboBox.Items.Clear();
            //foreach (var p in people)
            //{
            //    comboBox.Items.Add(p);
            //}
            comboBox.ItemsSource = people;
            //comboBox.DisplayMemberPath = "Name";
            //comboBox.DisplayMemberPath = "SurName";
            comboBox.DisplayMemberPath = nameof(Person.FullName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newperson = new Person() { Name = "New Name", SurName = "Mew Surname", Birth = new DateTime(1990, 7, 21) };
            people.Add(newperson);
           // comboBox.Items.Add(newperson);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex != -1)
                people.RemoveAt(comboBox.SelectedIndex);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            people.Clear();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           if(comboBox.SelectedItem != null)
                MessageBox.Show(comboBox.SelectedItem.ToString());
        }
    }
}
