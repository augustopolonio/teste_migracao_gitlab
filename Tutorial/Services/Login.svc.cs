using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tutorial.EDM;

namespace Tutorial.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Login.svc or Login.svc.cs at the Solution Explorer and start debugging.
    public class Login : ILogin
    {
        static TutorialEntities db = new TutorialEntities();

        public void DoWork()
        {
        }

        public static void CreateUser()
        {
            USUARIOS user = new USUARIOS();
            user.NOME = "Augusto Polonio 3";
            user.SENHA = "202CB962AC59075B964B07152D234B70";
            user.EMAIL = "augustodrp@gmail.com";
            user.DATA_NASCIMENTO = DateTime.Now;
            db.USUARIOS.Add(user);
            db.SaveChanges();
        }

        public static void ReadUser()
        {
            USUARIOS user = db.USUARIOS.Single(c => c.ID == 1);
            USUARIOS[] users = db.USUARIOS.ToArray();
        }

        public static void UpdateUser(int id)
        {
            USUARIOS user = db.USUARIOS.Single(c => c.ID == id);
            user.NOME = "Augusto Polonio 1 (Editado)";
            db.SaveChanges();
        }

        public static void DeleteUser(int id)
        {
            USUARIOS user = db.USUARIOS.Single(c => c.ID == id);
            user.DATA_EXCLUSAO = DateTime.Now;
            db.SaveChanges();
        }
    }
}
