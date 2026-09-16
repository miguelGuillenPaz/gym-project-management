using System.Configuration;

namespace GyM.ProjectManagement.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {                
                return ConfigurationManager.ConnectionStrings["GyMAdo"].ToString();
            }

        }
    }
}