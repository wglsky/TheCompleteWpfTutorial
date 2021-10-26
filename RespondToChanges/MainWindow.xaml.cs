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

namespace RespondToChanges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();

            users.Add(new User { Name = "John Smith" });
            users.Add(new User { Name = "Jerry Chew" });
            users.Add(new User { Name = "Leotion King"});
            // Set the ItemsSource to users
            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User { Name = "Tom Cat" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                (lbUsers.SelectedItem as User).Name = "Changed Name";
            } else if (lbUsers.SelectedItem == null)
            {
                MessageBox.Show("Please selecte an Item for changing.");
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
