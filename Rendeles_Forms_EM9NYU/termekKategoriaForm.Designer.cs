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
            treeViewKategoriak = new TreeView();
            txtLeiras = new TextBox();
            txtNev = new TextBox();
            buttonUjtestver = new Button();
            buttonUjgyerek = new Button();
            buttonMentes = new Button();
            buttonTorles = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(22, 26);
            treeViewKategoriak.Margin = new Padding(6);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(621, 904);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(771, 119);
            txtLeiras.Margin = new Padding(6);
            txtLeiras.Multiline = true;
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(689, 749);
            txtLeiras.TabIndex = 1;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(771, 26);
            txtNev.Margin = new Padding(6);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(689, 39);
            txtNev.TabIndex = 2;
            // 
            // buttonUjtestver
            // 
            buttonUjtestver.Location = new Point(657, 885);
            buttonUjtestver.Margin = new Padding(6);
            buttonUjtestver.Name = "buttonUjtestver";
            buttonUjtestver.Size = new Size(247, 49);
            buttonUjtestver.TabIndex = 3;
            buttonUjtestver.Text = "Új testvér kategória";
            buttonUjtestver.UseVisualStyleBackColor = true;
            buttonUjtestver.Click += buttonUjtestver_Click;
            // 
            // buttonUjgyerek
            // 
            buttonUjgyerek.Location = new Point(916, 885);
            buttonUjgyerek.Margin = new Padding(6);
            buttonUjgyerek.Name = "buttonUjgyerek";
            buttonUjgyerek.Size = new Size(247, 49);
            buttonUjgyerek.TabIndex = 4;
            buttonUjgyerek.Text = "Új gyerek kategória";
            buttonUjgyerek.UseVisualStyleBackColor = true;
            buttonUjgyerek.Click += buttonUjgyerek_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(1174, 885);
            buttonMentes.Margin = new Padding(6);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(139, 49);
            buttonMentes.TabIndex = 5;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(1324, 885);
            buttonTorles.Margin = new Padding(6);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(139, 49);
            buttonTorles.TabIndex = 6;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(702, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 7;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(689, 486);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 8;
            label2.Text = "Leírás:";
            // 
            // termekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1486, 960);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTorles);
            Controls.Add(buttonMentes);
            Controls.Add(buttonUjgyerek);
            Controls.Add(buttonUjtestver);
            Controls.Add(txtNev);
            Controls.Add(txtLeiras);
            Controls.Add(treeViewKategoriak);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "termekKategoriaForm";
            ShowInTaskbar = false;
            Text = "Termékkategóriák kezelése";
            TopMost = true;
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
    }
}