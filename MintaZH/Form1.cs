using MintaZH.Models;

namespace MintaZH
{
    public partial class Form1 : Form
    {
        private ReceptContext _context;



        public Form1()
        {
            InitializeComponent();
            _context = new ReceptContext();
            NyersanyagListazas();
            FogasListazas();
        }

        private void FogasListazas()
        {
            var hv = from x in _context.Fogasok
                     where x.FogasNev.Contains(textBox2.Text)
                     select x;

            fogasokBindingSource.DataSource = hv.ToList();
        }

        private void NyersanyagListazas()
        {
            var hv = from x in _context.Nyersanyagok
                     where x.NyersanyagNev.Contains(textBox1.Text)
                     select x;

            nyersanyagokBindingSource.DataSource = hv.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            var filteredData = _context.Nyersanyagok
                                       .Where(x => x.NyersanyagNev.ToLower().Contains(filterString))
                                       .ToList();
            nyersanyagokBindingSource.DataSource = filteredData;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox2.Text.ToLower();
            var filteredData = _context.Nyersanyagok
                                       .Where(x => x.NyersanyagNev.ToLower().Contains(filterString))
                                       .ToList();
            nyersanyagokBindingSource.DataSource = filteredData;
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Nyersanyagok kiválasztottNyersanyag)
            {
                var megyseg = (from x in _context.MennyisegiEgysegek
                               where x.MennyisegiEgysegId == kiválasztottNyersanyag.MennyisegiEgysegId
                               select x).FirstOrDefault();
                if (megyseg != null)
                {
                    label1.Text = megyseg.EgysegNev;
                }
                else
                {
                    label1.Text = "N/A"; // or handle the null case appropriately
                }
            }
            else
            {
                label1.Text = "N/A"; // or handle the null case appropriately
            }
        }

        private void HozzávalóListázás()
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            var id = ((Fogasok)listBox1.SelectedItem).FogasId;

            var hozzávalók = from x in _context.Receptek
                             where x.FogasId == id
                             select new
                             {
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ár = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            hozzávalóBindingSource.DataSource = hozzávalók.ToList();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string newNyersanyag = textBox3.Text;
            if (!string.IsNullOrEmpty(newNyersanyag))
            {
                var nyersanyag = new Nyersanyagok { NyersanyagNev = newNyersanyag };
                _context.Nyersanyagok.Add(nyersanyag);
                _context.SaveChanges();
                NyersanyagListazas();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzávalóListázás();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Nyersanyagok selectedNyersanyag)
            {
                _context.Nyersanyagok.Remove(selectedNyersanyag);
                _context.SaveChanges();
                NyersanyagListazas();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Hozzávaló
    {
        public int ReceptID { get; set; }
        public int? FogasID { get; set; }
        public string NyersanyagNev { get; set; }
        public double? Mennyiseg_4fo { get; set; }
        public string EgysegNev { get; set; }
        public double? Ár { get; set; }
    }
}