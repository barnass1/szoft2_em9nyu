namespace Rendeles_Forms_EM9NYU
{
    partial class termekKategoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            mentésXMLbeToolStripMenuItem = new ToolStripMenuItem();
            txtLeiras = new TextBox();
            txtNev = new TextBox();
            buttonUjtestver = new Button();
            buttonUjgyerek = new Button();
            buttonMentes = new Button();
            buttonTorles = new Button();
            label1 = new Label();
            label2 = new Label();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeViewKategoriak.ContextMenuStrip = contextMenuStripKategoria;
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(336, 426);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterLabelEdit += treeViewKategoriak_AfterLabelEdit;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, mentésXMLbeToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStripKategoria";
            contextMenuStripKategoria.Size = new Size(159, 136);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 22);
            toolStripMenuItem1.Text = "Átnevezés";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(158, 22);
            toolStripMenuItem2.Text = "Új főkategória";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(158, 22);
            toolStripMenuItem3.Text = "Új alkategória";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(158, 22);
            toolStripMenuItem4.Text = "Törlés";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(158, 22);
            toolStripMenuItem5.Text = "Frissítés";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // mentésXMLbeToolStripMenuItem
            // 
            mentésXMLbeToolStripMenuItem.Name = "mentésXMLbeToolStripMenuItem";
            mentésXMLbeToolStripMenuItem.Size = new Size(158, 22);
            mentésXMLbeToolStripMenuItem.Text = "Mentés XML-be";
            mentésXMLbeToolStripMenuItem.Click += mentésXMLbeToolStripMenuItem_Click;
            // 
            // txtLeiras
            // 
            txtLeiras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLeiras.Location = new Point(415, 56);
            txtLeiras.Multiline = true;
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(373, 353);
            txtLeiras.TabIndex = 1;
            // 
            // txtNev
            // 
            txtNev.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNev.Location = new Point(415, 12);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(373, 23);
            txtNev.TabIndex = 2;
            // 
            // buttonUjtestver
            // 
            buttonUjtestver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUjtestver.Location = new Point(354, 415);
            buttonUjtestver.Name = "buttonUjtestver";
            buttonUjtestver.Size = new Size(133, 23);
            buttonUjtestver.TabIndex = 3;
            buttonUjtestver.Text = "Új testvér kategória";
            buttonUjtestver.UseVisualStyleBackColor = true;
            buttonUjtestver.Click += buttonUjtestver_Click;
            // 
            // buttonUjgyerek
            // 
            buttonUjgyerek.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUjgyerek.Location = new Point(493, 415);
            buttonUjgyerek.Name = "buttonUjgyerek";
            buttonUjgyerek.Size = new Size(133, 23);
            buttonUjgyerek.TabIndex = 4;
            buttonUjgyerek.Text = "Új gyerek kategória";
            buttonUjgyerek.UseVisualStyleBackColor = true;
            buttonUjgyerek.Click += buttonUjgyerek_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMentes.Location = new Point(632, 415);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(75, 23);
            buttonMentes.TabIndex = 5;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTorles.Location = new Point(713, 415);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(75, 23);
            buttonTorles.TabIndex = 6;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(378, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(371, 228);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Leírás:";
            // 
            // termekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTorles);
            Controls.Add(buttonMentes);
            Controls.Add(buttonUjgyerek);
            Controls.Add(buttonUjtestver);
            Controls.Add(txtNev);
            Controls.Add(txtLeiras);
            Controls.Add(treeViewKategoriak);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "termekKategoriaForm";
            ShowInTaskbar = false;
            Text = "Termékkategóriák kezelése";
            Load += termekKategoriaForm_Load;
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox txtLeiras;
        private TextBox txtNev;
        private Button buttonUjtestver;
        private Button buttonUjgyerek;
        private Button buttonMentes;
        private Button buttonTorles;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem mentésXMLbeToolStripMenuItem;
    }
}