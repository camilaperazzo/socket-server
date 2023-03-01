using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Reflection;


namespace SocketServer
{
  
    public class clLog
    {
        //classe semaphore implantada

        Semaphore pool = new Semaphore(1,2);
        public string formatDate = "yyyy-MM-dd HH:mm:ss:fff";

        //Por enquanto...

        public string directory = Directory.GetCurrentDirectory();

        public string path;
        public string oldpath;

        public int freq;
        //Propriedades

        public int MaxFileLengh = 5000*1024;

        public string DefaultFileName = "DesafioDefault";
        
        public void WriteLog(string fpData/*, string fpFileName*/)
        {
            pool.WaitOne();

            path = "arquivo.log";
            oldpath = "arquivo_old.log";
            

            if (File.Exists(path))    
            {    
                   
                if ((new FileInfo(path).Length) >= MaxFileLengh) 
                {        
                    if (File.Exists(oldpath))            
                    {        
                       new FileInfo(oldpath).Delete();         
                    }        

                    File.Move(path, oldpath)       ;

                    File.Create(path).Close();

                    using (StreamWriter b = File.AppendText(path))
                    {
                        b.WriteLine($"{DateTime.Now.ToString(formatDate)} : {fpData}");
                        b.Close();
                    }

                }
                else
                {
                    using (StreamWriter b = File.AppendText(path))
                    {
                        b.WriteLine($"{DateTime.Now.ToString(formatDate)} : {fpData}");
                        b.Close();
                    }
                }
                        
            }
            else        
            {        
                 using (StreamWriter b = File.AppendText(path))  
                 {
                       b.WriteLine($"{DateTime.Now.ToString(formatDate)} : {fpData}");
                       b.Close();
                 }

            }           

            Thread.Sleep(freq);
            pool.Release();
        }    
    }
}