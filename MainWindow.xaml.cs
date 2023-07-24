using Proyecto_Final_23AM.Context;
using Proyecto_Final_23AM.Entities;
using Proyecto_Final_23AM.Vista;
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

namespace Proyecto_Final_23AM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Password;

            // Validar el usuario y la contraseña
            if (ValidateLogin(username, password))
            {
                
                MessageBox.Show("Inicio de sesión exitoso. Bienvenido " + username);
                Sistema sistema = new Sistema();
                sistema.Show();
                Close();
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intenta nuevamente.");
            }   
        }
        private bool ValidateLogin(string username, string password)
        {
            using (var context = new ApplicationDbContext())
            {
                
                Usuario user = context.Usuarios.FirstOrDefault(u => u.Username == username && u.Password == password);

                return (user != null); 
            }
        }

        private void BtnAbrir_Click(object sender, RoutedEventArgs e)
        {
            Inventario inven = new Inventario();
            inven.Show();
        }
    }
}
