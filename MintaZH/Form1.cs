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
            if (listBox2.SelectedItem is Nyersanyagok kiv�lasztottNyersanyag)
            {
                var megyseg = (from x in _context.MennyisegiEgysegek
                               where x.MennyisegiEgysegId == kiv�lasztottNyersanyag.MennyisegiEgysegId
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

        private void Hozz�val�List�z�s()
        {
            if (listBox1.SelectedItem == null)
            {
                // Handle the case when no item is selected
                return;
            }

            var id = ((Fogasok)listBox1.SelectedItem).FogasId;

            var hozz�val�k = from x in _context.Receptek
                             where x.FogasId == id
                             select new Hozz�val�
                             {
                                 ReceptID = x.ReceptId,
                                 FogasID = x.FogasId,
                                 NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                                 Mennyiseg_4fo = x.Mennyiseg4fo,
                                 EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 �r = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            hozz�val�BindingSource.DataSource = hozz�val�k.ToList();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Receptek r = new Receptek();
            r.NyersanyagId = ((Nyersanyagok)listBox2.SelectedItem).NyersanyagId;
            r.FogasId = ((Fogasok)listBox1.SelectedItem).FogasId;
            double m;
            if (!double.TryParse(textBox3.Text, out m)) return;
            r.Mennyiseg4fo = m;
            _context.Receptek.Add(r);
            _context.SaveChanges();
            Hozz�val�List�z�s(); //Az k�z�ps� r�csot kell �jrat�lteni
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hozz�val�List�z�s();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedHozz�val� = (Hozz�val�)hozz�val�BindingSource.Current;

            var t�rlend� = (from x in _context.Receptek
                            where x.ReceptId == selectedHozz�val�.ReceptID
                            select x).FirstOrDefault();

            if (t�rlend� != null)
            {
                _context.Receptek.Remove(t�rlend�);
                _context.SaveChanges();
                Hozz�val�List�z�s();
            }
        }
    }

    public class Hozz�val�
    {
        public int ReceptID { get; set; }
        public int? FogasID { get; set; }
        public string NyersanyagNev { get; set; }
        public double? Mennyiseg_4fo { get; set; }
        public string EgysegNev { get; set; }
        public double? �r { get; set; }
    }
}