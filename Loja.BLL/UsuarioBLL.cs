using System;
using System.Collections.Generic;
using System.Text;
using Loja.DTO;
using Loja.DAL;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().insereUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int editaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().editaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().deletaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
