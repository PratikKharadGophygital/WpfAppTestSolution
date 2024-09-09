using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserRepository _userRepository;
        public MainWindow()
        {
            InitializeComponent();  // Ensure this is present

            string connectionString = "Connection string";
            _userRepository = new UserRepository(connectionString);

            // Load system information
            MachineNameTextBlock.Text = $"Machine Name: {Environment.MachineName}";
            UserNameTextBlock.Text = $"User Name: {Environment.UserName}";
            OSVersionTextBlock.Text = $"OS Version: {Environment.OSVersion}";

            LoadSystemInfo();
            LoadUserData();

        }

        private void LoadSystemInfo()
        {
            string systemName = Environment.MachineName;
            string userName = Environment.UserName;

        }

        private void LoadUserData()
        {
            var users = _userRepository.GetAllUsers();
            UserDataGrid.ItemsSource = users;
        }


        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("All fields are required.", "Validation Error");
                return;
            }

            User user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };

            _userRepository.AddUser(user);
            LoadUserData();
            MessageBox.Show("User added successfully!", "Success");
        }





    }
}