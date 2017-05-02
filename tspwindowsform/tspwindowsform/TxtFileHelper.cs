using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class TxtFileHelper
    {
        public static string LoadText(string path)
        {
            string content = null;
            if(File.Exists(path)) content = File.ReadAllText(path);

            return content;
        }
    }
}
