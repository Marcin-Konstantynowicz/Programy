using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp9
{
    class RSAGenerator
    {
        public static void CreateNewRSAGenerator()
        {

            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

            string publicKeyString = GetKeyString(publicKey);
            string privateKeyString = GetKeyString(privateKey);

            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("KLUCZ PUBLICZNY: ");
            Console.WriteLine(publicKeyString);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("KLUCZ PRYWATNY: ");
            Console.WriteLine(privateKeyString);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string textToEncrypt = GenerateTestString();
            Console.WriteLine("TEKST DO ZASZYFROWANIA: ");
            Console.WriteLine(textToEncrypt);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");

            string encryptedText = Encrypt(textToEncrypt, publicKeyString); //Szyfrowanie za pomocą klucza publicznego
            Console.WriteLine("ZASZYFROWANY TEKST: ");
            Console.WriteLine(encryptedText);
            Console.WriteLine("-------------------------------------------");

            string decryptedText = Decrypt(encryptedText, privateKeyString); //Odszyfrowywanie za pomocą klucza prywatnego
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ODSZYFROWANY TEXT: ");
            Console.WriteLine(decryptedText);
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static string GetKeyString(RSAParameters publicKey)
        {

            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, publicKey);
            return stringWriter.ToString();
        }

        public static string Encrypt(string textToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decrypt(string textToDecrypt, string privateKeyString)
        {
            var bytesToDescrypt = Encoding.UTF8.GetBytes(textToDecrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {                 
                    rsa.FromXmlString(privateKeyString);

                    var resultBytes = Convert.FromBase64String(textToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private static string GenerateTestString()
        {
            Guid ID = Guid.NewGuid();
            Guid systemUserId = Guid.NewGuid();
           
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Identyfikator pracownika= {0}\n", ID.ToString());
            sb.AppendFormat("Identyfikator użytkownika systemu= {0}\n", systemUserId.ToString());
            sb.AppendFormat("Obecny czas={0}\n", currentTime);

            return sb.ToString();

            
        }

        
    }
}
