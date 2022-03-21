using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Tutorial.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Login.svc or Login.svc.cs at the Solution Explorer and start debugging.
    public class Login : ILogin
    {
        public void DoWork()
        {
        }

        public static void CreateUser()
        {
            TUTORIALEntities context = new TUTORIALEntities();

            USUARIOS user = new USUARIOS();
            user.NOME = "Augusto Polonio 2";
            user.SENHA = "202CB962AC59075B964B07152D234B70";
            user.EMAIL = "augustodrp@gmail.com";
            user.DATA_NASCIMENTO = DateTime.Now;
            context.USUARIOS.Add(user);
            context.SaveChanges();
        }

        public static void ReadUser()
        {
            TUTORIALEntities context = new TUTORIALEntities();

            USUARIOS user = context.USUARIOS.Single(c => c.ID == 1);

            USUARIOS[] users = context.USUARIOS.ToArray();
        }

        public static void UpdateUser(int id)
        {
            TUTORIALEntities context = new TUTORIALEntities();
            USUARIOS user = context.USUARIOS.Single(c => c.ID == id);

            user.NOME = "Augusto Polonio 1 (Editado)";
            context.SaveChanges();
        }

        public static void DeleteUser(int id)
        {
            TUTORIALEntities context = new TUTORIALEntities();
            USUARIOS user = context.USUARIOS.Single(c => c.ID == id);

            user.DATA_EXCLUSAO = DateTime.Now;
            context.SaveChanges();
        }
    }
}
