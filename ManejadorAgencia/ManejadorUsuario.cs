using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosAgencia;
using EntidadesAgencia;
using Crud;
using System.Windows.Forms;

namespace ManejadorAgencia
{
    public class ManejadorUsuario
    {
        private AccesoDatosUsuarios _accesoDatosUsuarios = new AccesoDatosUsuarios();
        private Grafico _grafico = new Grafico();

        public Usuario ingresarUsuario(string IdUsuario)
        {
            try
            {
                Usuario usuario= _accesoDatosUsuarios.buscarUsuario(IdUsuario);
                if (usuario!=null)
                {
                    _grafico.Mensaje(string.Format("Bievenido de vuelta {0}", usuario.Nombre), "Bievenido", MessageBoxIcon.Information);
                    return usuario;
                }
                else
                {
                    _grafico.Mensaje("El usuario no existe, pruebe otro o registrese", "Error al ingresar", MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al ingresar", MessageBoxIcon.Error);

            }
            return null;
        }

        public Usuario registrarUsuario(Usuario usuario)
        {
            try
            {
                _accesoDatosUsuarios.registrarUsuario(usuario);
                _grafico.Mensaje(string.Format("Bievenido {0}", usuario.Nombre), "Bievenido Nuevo Usuario", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al registrar", MessageBoxIcon.Error);
            }
            return _accesoDatosUsuarios.buscarUsuario(usuario.IdUsuario);
        }

        public Usuario modificarUsuario(Usuario usuario)
        {
            try
            {
                _accesoDatosUsuarios.modificarUsuario(usuario);
                _grafico.Mensaje(string.Format("{0} modificado", usuario.Nombre), "Modificando Usuario", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al modificar", MessageBoxIcon.Error);
            }
            
            return _accesoDatosUsuarios.buscarUsuario(usuario.IdUsuario);
        }

        public void borrarUsuario(Usuario usuario)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de borrar su usuario?", "Borrando usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult==DialogResult.Yes)
                {
                    _accesoDatosUsuarios.eliminarUsuario(usuario);
                    _grafico.Mensaje(string.Format("Lamentamos que te vayas {0}",usuario.Nombre),"Adios",MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al borrar", MessageBoxIcon.Error);
            }
        }
    }
}
