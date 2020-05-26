using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svanTipuricZapisivanjeUTekstualniDokument
{
    class StreamWriter
    {
        using (StreamWriter writer = new StreamWriter(fullPath))  
        {  
         writer.WriteLine("Monica Rathbun");  
         writer.WriteLine("Vidya Agarwal");  
         writer.WriteLine("Mahesh Chand");  
         writer.WriteLine("Vijay Anand");  
         writer.WriteLine("Jignesh Trivedi");  
        }
        
          string readText = File.ReadAllText(fullPath);
          Console.WriteLine(readText);
    
    }
}
