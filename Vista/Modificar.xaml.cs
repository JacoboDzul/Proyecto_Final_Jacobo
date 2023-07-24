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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
            Alimento();
        }
        InventarioServices services = new InventarioServices();
        private void SelectAlimentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectAlimentos.SelectedItem != null)
            {
                // Obtén el objeto "inventario" seleccionado en el ComboBox
                inventario selectedAlimento = (inventario)SelectAlimentos.SelectedItem;
                Txt_Proveedor.IsEnabled = true;
                Txt_NombreAlimento.IsEnabled = true;
                Txt_Cantidad.IsEnabled = true;
                btn_GuardarRegistro.IsEnabled = true;

                // Asigna los valores del objeto a los TextBox
                Txt_NombreAlimento.Text = selectedAlimento.Nombre;
                Txt_Cantidad.Text = selectedAlimento.Cantidad.ToString();
                Txt_Proveedor.Text = selectedAlimento.Proveedor;
            }
        }
        private void Alimento()
        {
            try
            {
                List<inventario> inven = services.GetAlimento();
                SelectAlimentos.ItemsSource = inven;
                SelectAlimentos.DisplayMemberPath = "Nombre";
                SelectAlimentos.SelectedValuePath = "PkAlimento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de roles: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bt_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Bt_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_GuardarRegistro_Click(object sender, RoutedEventArgs e)
        {
            if (SelectAlimentos.SelectedItem != null)
            {
                try
                {
                    // Obtén el objeto "inventario" seleccionado en el ComboBox
                    inventario selectedAlimento = (inventario)SelectAlimentos.SelectedItem;

                    // Actualiza los valores del objeto con los datos modificados de los TextBox
                    selectedAlimento.Nombre = Txt_NombreAlimento.Text;
                    selectedAlimento.Cantidad = int.Parse(Txt_Cantidad.Text);
                    selectedAlimento.Proveedor = Txt_Proveedor.Text;

                    // Llama al servicio para guardar los cambios en la base de datos
                    services.SaveAlimentoChanges(selectedAlimento);
                    Close();
                    // Muestra un mensaje de éxito
                    MessageBox.Show("Datos modificados y guardados correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos modificados: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}