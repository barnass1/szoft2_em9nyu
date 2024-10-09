namespace Rendeles_Forms_EM9NYU
{
    partial class UgyfelKezeloForm
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
            dgvUgyfelek = new DataGridView();
            ugyfelBindingSource = new BindingSource(components);
            tbSzuro = new TextBox();
            buttonUj = new Button();
            buttonMod = new Button();
            buttonTorles = new Button();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUgyfelek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvUgyfelek
            // 
            dgvUgyfelek.AllowUserToAddRows = false;
            dgvUgyfelek.AllowUserToDeleteRows = false;
            dgvUgyfelek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUgyfelek.AutoGenerateColumns = false;
            dgvUgyfelek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUgyfelek.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn });
            dgvUgyfelek.DataSource = ugyfelBindingSource;
            dgvUgyfelek.Location = new Point(22, 87);
            dgvUgyfelek.Margin = new Padding(6);
            dgvUgyfelek.Name = "dgvUgyfelek";
            dgvUgyfelek.ReadOnly = true;
            dgvUgyfelek.RowHeadersWidth = 82;
            dgvUgyfelek.RowTemplate.Height = 25;
            dgvUgyfelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUgyfelek.Size = new Size(1441, 809);
            dgvUgyfelek.TabIndex = 0;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // tbSzuro
            // 
            tbSzuro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSzuro.Location = new Point(22, 26);
            tbSzuro.Margin = new Padding(6);
            tbSzuro.Name = "tbSzuro";
            tbSzuro.Size = new Size(1438, 39);
            tbSzuro.TabIndex = 1;
            tbSzuro.TextChanged += tbSzuro_TextChanged;
            // 
            // buttonUj
            // 
            buttonUj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUj.Location = new Point(773, 909);
            buttonUj.Margin = new Padding(6);
            buttonUj.Name = "buttonUj";
            buttonUj.Size = new Size(223, 49);
            buttonUj.TabIndex = 2;
            buttonUj.Text = "Új ügyfél";
            buttonUj.UseVisualStyleBackColor = true;
            buttonUj.Click += buttonUj_Click;
            // 
            // buttonMod
            // 
            buttonMod.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMod.Location = new Point(1007, 909);
            buttonMod.Margin = new Padding(6);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(223, 49);
            buttonMod.TabIndex = 3;
            buttonMod.Text = "Módosítás";
            buttonMod.UseVisualStyleBackColor = true;
            // 
            // buttonTorles
            // 
            buttonTorles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTorles.Location = new Point(1241, 909);
            buttonTorles.Margin = new Padding(6);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(223, 49);
            buttonTorles.TabIndex = 4;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            ugyfelIdDataGridViewTextBoxColumn.ReadOnly = true;
            ugyfelIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 10;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.ReadOnly = true;
            nevDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.MinimumWidth = 10;
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            telefonszamDataGridViewTextBoxColumn.ReadOnly = true;
            telefonszamDataGridViewTextBoxColumn.Width = 200;
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            lakcimIdDataGridViewTextBoxColumn.ReadOnly = true;
            lakcimIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.MinimumWidth = 10;
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            lakcimDataGridViewTextBoxColumn.ReadOnly = true;
            lakcimDataGridViewTextBoxColumn.Width = 200;
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.MinimumWidth = 10;
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            rendelesDataGridViewTextBoxColumn.ReadOnly = true;
            rendelesDataGridViewTextBoxColumn.Width = 200;
            // 
            // UgyfelKezeloForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 983);
            Controls.Add(buttonTorles);
            Controls.Add(buttonMod);
            Controls.Add(buttonUj);
            Controls.Add(tbSzuro);
            Controls.Add(dgvUgyfelek);
            Margin = new Padding(6);
            MinimumSize = new Size(906, 666);
            Name = "UgyfelKezeloForm";
            Text = "UgyfelKezeloForm";
            Load += UgyfelKezeloForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUgyfelek).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUgyfelek;
        private TextBox tbSzuro;
        private Button buttonUj;
        private Button buttonMod;
        private Button buttonTorles;
        private BindingSource ugyfelBindingSource;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
    }
}