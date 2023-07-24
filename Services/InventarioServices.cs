using Microsoft.EntityFrameworkCore;
using Proyecto_Final_23AM.Context;
using Proyecto_Final_23AM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_Final_23AM.Services
{
    public class InventarioServices
    {
        public void AddAlimento(inventario request) 
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        inventario res = new inventario();
                        res.Nombre = request.Nombre;
                        res.Cantidad = request.Cantidad;
                        res.Proveedor=request.Proveedor;
                        _context.Inventarios.Add(res);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error" + ex.Message);
            }
        }
        public void DeleteAlimento(inventario Inventario)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    inventario AlimentoToDelete = _context.Inventarios.FirstOrDefault(u => u.PkAlimento == Inventario.PkAlimento);
                    if (AlimentoToDelete != null)
                    {
                        _context.Inventarios.Remove(AlimentoToDelete);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void SaveAlimentoChanges(inventario Inventario)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    inventario AlimentoToUpdate = _context.Inventarios.FirstOrDefault(u => u.PkAlimento == Inventario.PkAlimento);
                    if (AlimentoToUpdate != null)
                    {
                        // Actualizar los valores del alimento existente con los nuevos valores
                        AlimentoToUpdate.Nombre = Inventario.Nombre;
                        AlimentoToUpdate.Cantidad = Inventario.Cantidad;
                        AlimentoToUpdate.Proveedor = Inventario.Proveedor;
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios del usuario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public List<inventario> GetAlimento()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    List<inventario> inventarios = new List<inventario>();
                    inventarios = _context.Inventarios.ToList();
                    return inventarios;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedió un error" + ex.Message);
            }
        }
        public void GuardarDatosEnArchivo(List<inventario> datos, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in datos)
                    {
                        string linea = $"{item.PkAlimento}, {item.Nombre}, {item.Cantidad}, {item.Proveedor}";
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error aquí según tus necesidades
                throw new Exception("Error al guardar los datos en el archivo: " + ex.Message, ex);
            }
        }
    }
}
