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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public event EventHandler RegistroClosed;

        public Registro()
        {
            InitializeComponent();
        }
        InventarioServices services = new InventarioServices();

       

        private void btn_GuardarRegistro_Click(object sender, RoutedEventArgs e)
        {
            inventario alimento = new inventario();
            alimento.Nombre = Txt_NombreAlimento.Text;
            alimento.Cantidad = int.Parse(Txt_Cantidad.Text);
            alimento.Proveedor = Txt_Proveedor.Text;
            services.AddAlimento(alimento);
            Txt_Proveedor.Clear();
            Txt_NombreAlimento.Clear();
            Txt_Cantidad.Clear();
            WindowState = WindowState.Minimized;

        }

        private void bt_Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Bt_Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
       
    }
}
