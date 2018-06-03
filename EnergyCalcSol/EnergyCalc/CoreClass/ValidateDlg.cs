﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyCalc.CoreClass
{
    public class ValidateDlg : Form
    {
        public ValidateDlg() : base()
        {
            DoubleBuffered = true;
        }

        public virtual bool CheckControls() { return true; }

        public virtual void SaveData() { }

        public CalcForm GetPrent() { return (CalcForm) Parent.Parent;  }

    }
}