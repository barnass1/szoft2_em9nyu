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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private BindingList<Cim> cimBindingList;
        private void UgyfelKezeloForm_Load(object sender, EventArgs e)
        {
            _context.Ugyfel.Load();
            _context.Cim.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            cimBindingList = _context.Cim.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
            //cimBindingSource.DataSource = cimBindingList;
            dgvUgyfelek.DataSource = ugyfelBindingList;
        }

        private void tbSzuro_TextChanged(object sender, EventArgs e)
        {
            string filterString = tbSzuro.Text.ToLower();
            ugyfelBindingSource.DataSource = from u in ugyfelBindingList
                                             where u.Nev.ToLower().Contains(filterString) ||
                                             u.Email.ToLower().Contains(filterString) ||
                                             (u.Telefonszam != null && u.Telefonszam.Contains(filterString))
                                             orderby u.UgyfelId
                                             select u;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            UgyfelSzekresztesForm ugyfelSzekresztesForm = new UgyfelSzekresztesForm();
            if (ugyfelSzekresztesForm.ShowDialog() == DialogResult.OK)
            {
                _context.Ugyfel.Add(ugyfelSzekresztesForm.SzerkesztettUgyfel);
                _context.Cim.Add(ugyfelSzekresztesForm.SzerkesztettCim);
                Mentés();
                
            }
        }

        void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            Ugyfel szerkesztettUgyfel = ugyfelBindingSource.Current as Ugyfel;
            if (szerkesztettUgyfel == null)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
                return;
            }
            UgyfelSzekresztesForm ugyfelSzekresztesForm = new UgyfelSzekresztesForm(szerkesztettUgyfel);
            if (ugyfelSzekresztesForm.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingSource.ResetCurrentItem();
                Mentés();
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            Ugyfel torlendoUgyfel = ugyfelBindingSource.Current as Ugyfel;
            if (torlendoUgyfel == null)
            {
                MessageBox.Show("Nincs kiválasztott ügyfél!");
                return;
            }
            if (MessageBox.Show("Biztosan törölni akarja az ügyfelet?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Ugyfel.Remove(torlendoUgyfel);
                Mentés();
            }
        }
    }
}
