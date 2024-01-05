using System.Security.Cryptography;
using System.Text;

namespace SistemBiblioteca.Services
{
    public class Utilitario
    {
        public static string EncriptarClave (string clave) 
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesclaves = Encoding.UTF8.GetBytes (clave);
                byte[] hashbytes = sha256.ComputeHash (bytesclaves);

                StringBuilder sb = new StringBuilder ();

                foreach (byte b in hashbytes)
                {
                    sb.Append (b.ToString("X2"));
                }

                return sb.ToString ();
            }
        }
    }
}
