using Proyecto_Final_23AM.Entities;
using Proyecto_Final_23AM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_Final_23AM.Vista
{
    /// <summary>
    /// Lógica de interacción para Sistema.xaml
    /// </summary>
    public partial class Sistema : Window
    {

        public Sistema()
        {
            InitializeComponent();
            GetUserTable();
            Roles();

        }
        private Usuario usuarioActual;

        UsuarioServices services = new UsuarioServices();

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "" || txtPassword.Text == "" || txtUserName.Text
                == "")
            {
                MessageBox.Show("Datos vacíos no puedes agregar un usuario");
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Username = txtUserName.Text;
                usuario.Password = txtPassword.Text;
                usuario.FkRol=int.Parse(SelectRol.SelectedValue.ToString());
                services.AddUser(usuario);

                txtNombre.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                GetUserTable();
            }
            
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            BtnAdd.IsEnabled=false;
            if (sender is Button button && button.DataContext is Usuario usuario)
            {
                BtnSave.IsEnabled = true;
                // Mostrar los datos del usuario en los campos de texto
                TxtPkUser.Text = usuario.PkUsuario.ToString();
                txtNombre.Text = usuario.Nombre;
                txtUserName.Text = usuario.Username;
                txtPassword.Text = usuario.Password;
                Rol selectedRol = SelectRol.Items.Cast<Rol>().FirstOrDefault(rol => rol.PkRol == usuario.FkRol);
                SelectRol.SelectedItem = selectedRol;



                usuarioActual = usuario;
            }

        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Usuario usuario)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    // Llamar al método para eliminar el usuario de la base de datos
                    services.DeleteUser(usuario);
                    GetUserTable();
                }
            }
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (usuarioActual != null)
            {
                // Actualizar los datos del usuario 
                usuarioActual.Nombre = txtNombre.Text;
                usuarioActual.Username = txtUserName.Text;
                usuarioActual.Password = txtPassword.Text;
                usuarioActual.FkRol = int.Parse(SelectRol.SelectedValue.ToString());

                // Llamar al método para guardar los cambios en la base de datos
                services.SaveUserChanges(usuarioActual);

                // Limpiar los campos de texto
                txtNombre.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                TxtPkUser.Clear();

                // Limpiar la referencia al usuario actual
                usuarioActual = null;

                // Actualizar la tabla después de guardar los cambios
                GetUserTable();
                BtnSave.IsEnabled = false;
                BtnAdd.IsEnabled = true;   
            }
        }




        public void GetUserTable()
        {
          UserTable.ItemsSource=services.GetUsuarios();
        }
       
        private void Roles()
        {
            try
            {
                List<Rol> roles = services.GetRoles();
                SelectRol.ItemsSource = roles;
                SelectRol.DisplayMemberPath = "Nombre";
                SelectRol.SelectedValuePath = "PkRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de roles: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
