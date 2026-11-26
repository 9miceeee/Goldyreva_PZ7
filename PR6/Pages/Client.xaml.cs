using PR6.models;
using System.Windows.Controls;

namespace PR6.Pages
{
    public partial class Client : Page
    {
        public Client(Users user, string role)
        {
            InitializeComponent();

            if (user != null)
            {
                tbWelcome.Text = $"Добро пожаловать, {user.Login}!";
                tbUserInfo.Text = $"Роль: {role}";
            }
            else
            {
                tbWelcome.Text = "Вы вошли как гость";
                tbUserInfo.Text = "Роль: Гость";
            }
        }
    }
}