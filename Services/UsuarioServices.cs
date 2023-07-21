using Microsoft.EntityFrameworkCore;
using Proyecto_Final_23AM.Context;
using Proyecto_Final_23AM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_Final_23AM.Services
{
    public class UsuarioServices
    {
        public void AddUser(Usuario request)
        {
            try
            {
                if (request != null)
                {
                    using(var _context = new ApplicationDbContext())
                    {
                        Usuario res =new Usuario();
                        res.Nombre = request.Nombre;
                        res.Username = request.Username;
                        res.Password = request.Password;
                        res.FkRol=request.FkRol;
                        _context.Usuarios.Add(res);
                        _context.SaveChanges();
                    }
                }    
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error" + ex.Message);
            }
        }
        public List<Usuario> GetUsuarios()
        {
            try
            {
                using(var _context=new ApplicationDbContext())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    usuarios=_context.Usuarios.Include(x => x.Roles).ToList();
                    return usuarios;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedió un error" + ex.Message);
            }
        }
        public List<Rol> GetRoles()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Rol> roles = _context.Roles.ToList();
                    return roles;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }

        }
        public void DeleteUser(Usuario usuario)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                   
                    Usuario userToDelete = _context.Usuarios.FirstOrDefault(u => u.PkUsuario == usuario.PkUsuario);
                    if (userToDelete != null)
                    {
                        _context.Usuarios.Remove(userToDelete);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void SaveUserChanges(Usuario usuario)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Usuario userToUpdate = _context.Usuarios.FirstOrDefault(u => u.PkUsuario == usuario.PkUsuario);
                    if (userToUpdate != null)
                    {
                        // Actualizar los valores del usuario existente con los nuevos valores
                        userToUpdate.Nombre = usuario.Nombre;
                        userToUpdate.Username = usuario.Username;
                        userToUpdate.Password = usuario.Password;
                        userToUpdate.FkRol = usuario.FkRol;
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios del usuario: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }




    }
}

