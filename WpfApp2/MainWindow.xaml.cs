using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            db.Database.EnsureCreated();
            db.Employments.Load();
            DataContext= db.Employments.Local.ToObservableCollection();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmploymentWindow EmploymentWindow = new EmploymentWindow(new Employment());
            if (EmploymentWindow.ShowDialog() == true)
            {
                Employment Employment = EmploymentWindow.Employment;
                db.Employments.Add(Employment);
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Employment? employment = employmentsList.SelectedItem as Employment;
            if (employment is null) return;

            EmploymentWindow EmploymentWindow = new EmploymentWindow(new Employment
            {
                Id = employment.Id,
                Surname = employment.Surname,
                Name = employment.Name,
                Patronymic = employment.Patronymic,
                DateOfBirth = employment.DateOfBirth,
                ContactNumber = employment.ContactNumber,
                Department = employment.Department
            });

            if(EmploymentWindow.ShowDialog() == true)
            {
                employment = db.Employments.Find(EmploymentWindow.Employment.Id);
                if(employment != null)
                {
                    employment.Id = EmploymentWindow.Employment.Id;
                    employment.Surname = EmploymentWindow.Employment.Surname;
                    employment.Name = EmploymentWindow.Employment.Name;
                    employment.Patronymic = EmploymentWindow.Employment.Patronymic;
                    employment.DateOfBirth = EmploymentWindow.Employment.DateOfBirth;
                    employment.ContactNumber = EmploymentWindow.Employment.ContactNumber;
                    employment.Department = EmploymentWindow.Employment.Department;

                    db.SaveChanges();
                    employmentsList.Items.Refresh();
                }
             }

            }
        private void Delete_Click(object sender, EventArgs e)
        {
            Employment? employment = employmentsList.SelectedItem as Employment;
            if (employment is null) return;
            db.Employments.Remove(employment);
            db.SaveChanges();
        }

        private void Info_Click(object sender,RoutedEventArgs e)
        {
            Employment? employment = employmentsList.SelectedItems as Employment;
            if (employment is null) return;

            InfoWindow InfoWindow = new InfoWindow(employment);
            if (InfoWindow.ShowDialog() == true)
            {
                employment = db.Employments.Find(InfoWindow.Employment.Id);
                if (employment != null)
                {
                    employmentsList.Items.Refresh();
                }
            }
        
        }

        private void employmentsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Employment employment  = (sender as ListBox).SelectedItem as Employment;
            InfoWindow InfoWindow = new InfoWindow(employment);
            if (InfoWindow.ShowDialog() == true)
            {
                employment = db.Employments.Find(InfoWindow.Employment.Id);
                if (employment != null)
                {
                    employmentsList.Items.Refresh();
                }
            }
        }
    }


}

