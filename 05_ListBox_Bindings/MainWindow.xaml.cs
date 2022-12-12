using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _05_ListBox_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students = new ObservableCollection<Student>() ;
        public MainWindow()
        {
            InitializeComponent();
            students = new ObservableCollection<Student>()
            {
                new Student(){Name = "Bob", Age = 30},
                new Student(){Name = "Will", Age = 35},
                new Student(){Name = "Tom", Age = 10},
                new Student(){Name = "Jack", Age = 17},
            };
            list.Items.Clear();
            list.ItemsSource = students;
            list.DisplayMemberPath = nameof(Student.FullInfo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student() { Name = "New", Age = 100 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
                students.Remove(list.SelectedItem as Student);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(list.SelectedItem != null)
            {
                Student s = list.SelectedItem as Student;
                s.Name = "New Name";
                s.Age++;
            }

        }
    }
}
