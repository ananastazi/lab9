using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    interface IParallelogramView
    {
        void SetHeight(double height);
        void SetSquare(double square);
        void DisplayError(string message);
    }
}
