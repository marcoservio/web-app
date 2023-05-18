using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.ByteBank.WebApp.T.Util
{
    public static class Helper
    {
        public static string CaminhoDriverNavegador()=> Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
    }
}
