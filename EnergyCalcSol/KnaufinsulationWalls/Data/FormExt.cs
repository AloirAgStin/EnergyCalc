using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnaufinsulationWalls.Data
{
    public class FormExt :  Form
    {
        public FormExt() : base()
        {
            DoubleBuffered = true;
        }

        public virtual void AfterShow() { }       

    }
}
