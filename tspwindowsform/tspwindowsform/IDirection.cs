using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    interface IDirection
    {
        float GetDistance();
        void DisplayOnBrowser();
        void SaveImage();
    }
}
