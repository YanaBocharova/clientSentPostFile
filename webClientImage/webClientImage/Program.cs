using System;

namespace webClientImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Post13();
            Console.WriteLine("Hello World!");
        }

        private static void Post13()
        {
            var url = "http://localhost:5000/api/filemanager/";

            string localPath = @"C:\Users\hp\Desktop\img10.png";

            var pathN = @"C:\Users\hp\Desktop\ResponseImage.png";

            using (WebClient cl = new WebClient())
            {
                var responceByte = cl.UploadFile(url, localPath);

                using (FileStream fs = new FileStream(pathN, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(responceByte, 0, responceByte.Length);
                }

                // err

                //using (Image image = Image.FromStream(new MemoryStream(responceByte)))
                //{
                //    image.Save(@"C:\Users\hp\Desktop\output1.png", ImageFormat.Png);  // Or Png
                //}
            }
        }
    }
}
}
