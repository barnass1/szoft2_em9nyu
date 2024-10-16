using Rendeles_Forms_EM9NYU.Data;
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
    public partial class RendelesForm : Form
    {
        private readonly RendelesDbContext _context;



        public RendelesForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();


        }
        private void RendelesForm_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadCimek();
            LoadTermekek();
        }


        private void LoadUgyfelek()
        {
            var q = from x in _context.Ugyfel
                    where x.Nev.Contains(tbSzuro.Text) || x.Email.Contains(tbSzuro.Text)
                    orderby x.Nev
                    select x;

            ugyfelBindingSource.DataSource = q.ToList();
            ugyfelBindingSource.ResetCurrentItem();
        }


        private void LoadCimek()
        {
            var q = from x in _context.Cim
                    select new CimEgybenDTO
                    {
                        CimId = x.CimId,
                        CimEgyben = $"{x.Iranyitoszam}-{x.Varos}, {x.Orszag}: {x.Utca} {x.Hazszam}"
                    };

            cimEgybenDTOBindingSource.DataSource = q.ToList();
        }

        private void LoadTermekek()
        {
            var q = from x in _context.Termek
                    select x;

            termekBindingSource.DataSource = q.ToList();
        }


        private void tbSzuro_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class CimEgybenDTO
    {
        private readonly RendelesDbContext _context;
        public int CimId { get; set; }
        public string? CimEgyben { get; set; }
    }
}
