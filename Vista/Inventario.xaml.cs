using Proyecto_Final_23AM.Entities;
using Proyecto_Final_23AM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ClosedXML.Excel;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Win32;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace Proyecto_Final_23AM.Vista
{
    /// <summary>
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
            GetInventarioTable();
            InventarioTable.Visibility=Visibility.Collapsed;    
        }

        Registro registro = new Registro();
        Eliminar elim = new Eliminar();
        Modificar mod = new Modificar();

        InventarioServices services = new InventarioServices();
        private void Btn_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void bt_Alta_Click(object sender, RoutedEventArgs e)
        {
            registro.Show();
            GetInventarioTable();
            InventarioTable.Visibility = Visibility.Visible;
        }

        private void bt_Baja_Click(object sender, RoutedEventArgs e)
        {
            elim.Show();
            GetInventarioTable();
            InventarioTable.Visibility = Visibility.Visible;
        }
        private void bt_Modificar_Click(object sender, RoutedEventArgs e)
        {
            mod.Show();
            InventarioTable.Visibility = Visibility.Visible;
        }

        private void bt_Busqueda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Informe_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar informe de inventario";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Inventario");

                        // Obtener los datos del DataGrid
                        var inventarioData = InventarioTable.ItemsSource.Cast<inventario>().ToList();

                        // Escribir los datos en el archivo Excel
                        for (int row = 1; row <= inventarioData.Count; row++)
                        {
                            worksheet.Cell(row + 1, 1).Value = inventarioData[row - 1].PkAlimento;
                            worksheet.Cell(row + 1, 2).Value = inventarioData[row - 1].Nombre;
                            worksheet.Cell(row + 1, 3).Value = inventarioData[row - 1].Cantidad;
                            worksheet.Cell(row + 1, 4).Value = inventarioData[row - 1].Proveedor;
                        }

                        // Guardar el archivo Excel en la ubicación seleccionada
                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Informe de inventario guardado exitosamente", "Guardar informe", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el informe de inventario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe Registrado");
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void GetInventarioTable()
        {
            InventarioTable.ItemsSource = services.GetAlimento();
        }

        private void Btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            GetInventarioTable();
            InventarioTable.Visibility = Visibility.Visible;
        }
    }
}
