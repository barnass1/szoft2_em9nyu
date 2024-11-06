namespace MintaZH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            fogasokBindingSource = new BindingSource(components);
            nyersanyagokBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            hozzávalóBindingSource = new BindingSource(components);
            receptIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiseg4foDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hozzávalóBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = fogasokBindingSource;
            listBox1.DisplayMember = "FogasNev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(185, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fogasokBindingSource
            // 
            fogasokBindingSource.DataSource = typeof(Models.Fogasok);
            // 
            // nyersanyagokBindingSource
            // 
            nyersanyagokBindingSource.DataSource = typeof(Models.Nyersanyagok);
            // 
            // listBox2
            // 
            listBox2.DataSource = nyersanyagokBindingSource;
            listBox2.DisplayMember = "NyersanyagNev";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(603, 44);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(185, 364);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(603, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(122, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptIDDataGridViewTextBoxColumn, fogasIDDataGridViewTextBoxColumn, nyersanyagNevDataGridViewTextBoxColumn, mennyiseg4foDataGridViewTextBoxColumn, egysegNevDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hozzávalóBindingSource;
            dataGridView1.Location = new Point(203, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(333, 364);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(542, 212);
            button3.Name = "button3";
            button3.Size = new Size(55, 23);
            button3.TabIndex = 8;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(542, 255);
            button4.Name = "button4";
            button4.Size = new Size(55, 23);
            button4.TabIndex = 9;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(603, 415);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(709, 419);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // hozzávalóBindingSource
            // 
            hozzávalóBindingSource.DataSource = typeof(Hozzávaló);
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            árDataGridViewTextBoxColumn.HeaderText = "Ár";
            árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hozzávalóBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label1;
        private BindingSource nyersanyagokBindingSource;
        private BindingSource fogasokBindingSource;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzávalóBindingSource;
    }
}