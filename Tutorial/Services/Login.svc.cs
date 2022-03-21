using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tutorial.UsuariosSR;

namespace Tutorial.Services
{
    public class Login : ILogin
    {
        UsuariosClient usuarios = new UsuariosClient();        

        public void DoWork()
        {
            USUARIOS[] users = usuarios.GetAllUsers();
        }
    }
}
