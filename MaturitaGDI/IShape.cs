using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaGDI
{
    public interface IShape
    {
        Point Point { get; set; }
        Pen Pen { get; set; }
        SolidBrush SolidBrush { get; set; }
        void Draw(params object[] objects);
    }
}
