﻿using Rendeles_Forms_EM9NYU.Data;
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
using System.Xml.Linq;

namespace Rendeles_Forms_EM9NYU
{
    public partial class termekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        private bool isNewItem = false;
        private TermekKategoria newKategoria = null!;
        public termekKategoriaForm()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }

        private void termekKategoriaForm_Load(object sender, EventArgs e)
        {
            LoadKategoriak();
        }

        private void buttonUjtestver_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.SzuloKategoriaId
                };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void LoadKategoriak()
        {
            _context = new RendelesDbContext();
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            treeViewKategoriak.Nodes.Clear();

            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;

            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }


        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                txtNev.Text = selectedKategoria.Nev;
                txtLeiras.Text = selectedKategoria.Leiras;
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (isNewItem)
                {
                    newKategoria.Nev = txtNev.Text;
                    newKategoria.Leiras = txtLeiras.Text;
                    _context.TermekKategoria.Add(newKategoria);
                }
                else if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
                {
                    selectedKategoria.Nev = txtNev.Text;
                    selectedKategoria.Leiras = txtLeiras.Text;
                }

                _context.SaveChanges();
                MessageBox.Show("A változtatások sikeresen mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKategoriak();
                isNewItem = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUjgyerek_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.KategoriaId
                };
                txtNev.Clear();
                txtLeiras.Clear();
                isNewItem = true;
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                var result = MessageBox.Show($"Biztosan törölni szeretné a(z) '{selectedKategoria.Nev}' kategóriát és annak összes alkategóriáját?",
                    "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteKategoriaAndChildren(selectedKategoria);
                        _context.SaveChanges();
                        MessageBox.Show("A kategória és alkategóriái sikeresen törölve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKategoriak();
                        txtNev.Clear();
                        txtLeiras.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a törlés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteKategoriaAndChildren(TermekKategoria kategoria)
        {
            var alkategoriak = from k in _context.TermekKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak.ToList())
            {
                DeleteKategoriaAndChildren(gyerekKategoria);
            }

            _context.TermekKategoria.Remove(kategoria);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeViewKategoriak.SelectedNode.BeginEdit();
        }

        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && !string.IsNullOrEmpty(e.Label))
            {
                TermekKategoria kategoria = (TermekKategoria)e.Node.Tag;
                kategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            termekKategoriaForm_Load(null, null);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TermekKategoria termekKategoria = new TermekKategoria();
            termekKategoria.Nev = "Új kategória";
            termekKategoria.Leiras = "Új kategória leírása";
            termekKategoria.SzuloKategoriaId = null;
            _context.TermekKategoria.Add(termekKategoria);
            _context.SaveChanges();

            TreeNode node = new TreeNode(termekKategoria.Nev);
            node.Tag = termekKategoria;
            treeViewKategoriak.Nodes.Add(node);

            treeViewKategoriak.SelectedNode = node;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TermekKategoria termekKategoria = new TermekKategoria();
            termekKategoria.Nev = "Új alkategória";
            termekKategoria.Leiras = "Új alkategória leírása";
            termekKategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).KategoriaId;
            _context.TermekKategoria.Add(termekKategoria);
            _context.SaveChanges();

            TreeNode node = new TreeNode(termekKategoria.Nev);
            node.Tag = termekKategoria;
            treeViewKategoriak.SelectedNode.Nodes.Add(node);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
            {

                TermekKategoria termekKategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                _context.TermekKategoria.Remove(termekKategoria);
                _context.SaveChanges();
                treeViewKategoriak.SelectedNode.Remove();

            }
            else
            {
                MessageBox.Show("Nem törölhető olyan kategória, amelynek van alkategóriája!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewKategoriak_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewKategoriak.SelectedNode = e.Node;
                contextMenuStripKategoria.Show(treeViewKategoriak, e.Location);
            }
        }

        private void mentésXMLbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();
            XDeclaration xdec = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdec;

            XElement root = new XElement("Kategoriak");
            xdoc.Add(root);

            void SaveNodeToXml(TreeNode node, XElement parent)
            {
                TermekKategoria kategoria = (TermekKategoria)node.Tag;
                XElement kategoriaElem = new XElement("Kategoria",
                 new XAttribute("KategoriaId", kategoria.KategoriaId),
                    new XAttribute("Nev", kategoria.Nev));

                parent.Add(kategoriaElem);
                foreach (TreeNode childNode in node.Nodes)
                {
                    SaveNodeToXml(childNode, kategoriaElem);
                }
            }

            foreach (TreeNode node in treeViewKategoriak.Nodes)
            {
                XElement kategoria = new XElement("Kategoria");
                root.Add(kategoria);
                SaveNodeToXml(node, kategoria);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML fájlok (*.xml)|*.xml";
            saveFileDialog.Title = "Kategóriák mentése XML-be";
            saveFileDialog.FileName = "kategoriak.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xdoc.Save(saveFileDialog.FileName);
                    MessageBox.Show("A kategóriák sikeresen elmentve XML-be!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}