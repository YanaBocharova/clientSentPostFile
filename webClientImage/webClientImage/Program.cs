using System;
using System.IO;
using System.Net;

namespace webClientImage
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestToServer();
        }

        private static void RequestToServer()
        {
            var url = "http://localhost:5000/api/filemanager/";

            string localPath = @"C:\Users\hp\Desktop\img10.png";

            var pathN = @"C:\Users\hp\Desktop\ResponseImage.png";

            using (WebClient client = new WebClient())
            {
                var responceByte = client.UploadFile(url, localPath);

                using (FileStream fs = new FileStream(pathN, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(responceByte, 0, responceByte.Length);
                }
            }
        }
    }
}
