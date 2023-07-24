using Proyecto_Final_23AM.Entities;
using Proyecto_Final_23AM.Services;
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
using System.Windows.Shapes;

namespace Proyecto_Final_23AM.Vista
{
    /// <summary>
    /// Lógica de interacción para Eliminar.xaml
    /// </summary>
    public partial class Eliminar : Window
    {
        public Eliminar()
        {
            InitializeComponent();
            Alimentos();
        }
        InventarioServices services = new InventarioServices();

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            inventario alimentoSeleccionado = SelectAlimento.SelectedItem as inventario;

            if (alimentoSeleccionado != null)
            {
                try
                {
                    services.DeleteAlimento(alimentoSeleccionado);
                    Alimentos();

                    MessageBox.Show("Alimento eliminado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el alimento: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alimento antes de hacer clic en Eliminar.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            WindowState = WindowState.Minimized;
        }

        private void Alimentos()
        {
            try
            {
                List<inventario> inven = services.GetAlimento();
                SelectAlimento.ItemsSource = inven;
                SelectAlimento.DisplayMemberPath = "Nombre";
                SelectAlimento.SelectedValuePath = "PkAlimento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de roles: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bt_min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void bt_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
