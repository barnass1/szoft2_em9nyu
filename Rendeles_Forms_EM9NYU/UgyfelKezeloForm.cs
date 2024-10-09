using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Rendeles_Forms_EM9NYU.Models;
using Rendeles_Forms_EM9NYU.Data;

namespace Rendeles_Forms_EM9NYU
{
    public partial class UgyfelKezeloForm : Form
    {
        public UgyfelKezeloForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        private void UgyfelKezeloForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            dgvUgyfelek.DataSource = ugyfelBindingList;
        }

        private void tbSzuro_TextChanged(object sender, EventArgs e)
        {
            string filterString = tbSzuro.Text.ToLower();
            ugyfelBindingSource.DataSource = _context.Ugyfel.Local.ToBindingList().Where(u => u.Nev.ToLower().Contains(filterString)).ToList();
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            UgyfelSzekresztesForm ugyfelSzekresztesForm = new UgyfelSzekresztesForm();
            if (ugyfelSzekresztesForm.ShowDialog() == DialogResult.OK)
            {
                _context.Ugyfel.Add(ugyfelSzekresztesForm.SzerkesztettUgyfel);
                _context.SaveChanges();
            }
        }
    }
}
