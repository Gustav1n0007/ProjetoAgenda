using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.VariableGlobal
{
    public static class UserSession
    {
        private static string _usuario = null;
        private static string _senha = null;

        public static string usuario
        {
            get
            {
                return _usuario;
            }
            set 
            {
                _usuario = value;
            }
        }

        public static string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        
    }
}
