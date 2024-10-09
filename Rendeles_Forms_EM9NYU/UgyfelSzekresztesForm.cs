using Rendeles_Forms_EM9NYU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles_Forms_EM9NYU
{
    public partial class UgyfelSzekresztesForm : Form
    {

        public Ugyfel SzerkesztettUgyfel { get; set; }
        public UgyfelSzekresztesForm(Ugyfel ugyfel = null)
        {
            InitializeComponent();
            this.SzerkesztettUgyfel = ugyfel ?? new Ugyfel();
        }
    }
}
