namespace Rendeles_Forms_EM9NYU
{
    partial class RendelesForm
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
            listBox1 = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            listBox3 = new ListBox();
            termekBindingSource = new BindingSource(components);
            tbSzuro = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            cimEgybenDTOBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = ugyfelBindingSource;
            listBox1.DisplayMember = "Nev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(19, 156);
            listBox1.Margin = new Padding(5, 6, 5, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(319, 784);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "UgyfelId";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // listBox2
            // 
            listBox2.DataSource = rendelesBindingSource;
            listBox2.DisplayMember = "RendelesDatum";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Location = new Point(351, 156);
            listBox2.Margin = new Padding(5, 6, 5, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(319, 784);
            listBox2.TabIndex = 1;
            listBox2.ValueMember = "RendelesId";
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // listBox3
            // 
            listBox3.DataSource = termekBindingSource;
            listBox3.DisplayMember = "Nev";
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 30;
            listBox3.Location = new Point(1685, 156);
            listBox3.Margin = new Padding(5, 6, 5, 6);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(319, 784);
            listBox3.TabIndex = 2;
            listBox3.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // tbSzuro
            // 
            tbSzuro.Location = new Point(19, 64);
            tbSzuro.Margin = new Padding(5, 6, 5, 6);
            tbSzuro.Name = "tbSzuro";
            tbSzuro.Size = new Size(319, 35);
            tbSzuro.TabIndex = 3;
            tbSzuro.TextChanged += tbSzuro_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(348, 953);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(322, 46);
            button1.TabIndex = 4;
            button1.Text = "Új rendelés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(684, 246);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(864, 694);
            dataGridView1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = cimEgybenDTOBindingSource;
            comboBox1.DisplayMember = "CimEgyben";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(684, 156);
            comboBox1.Margin = new Padding(5, 6, 5, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(462, 38);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "CimId";
            // 
            // cimEgybenDTOBindingSource
            // 
            cimEgybenDTOBindingSource.DataSource = typeof(CimEgybenDTO);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1341, 156);
            comboBox2.Margin = new Padding(5, 6, 5, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 38);
            comboBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1159, 156);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 35);
            textBox2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(1180, 953);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(179, 46);
            button2.TabIndex = 9;
            button2.Text = "Mentés";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1369, 953);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(179, 46);
            button3.TabIndex = 10;
            button3.Text = "Excel export";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1558, 492);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(117, 100);
            button4.TabIndex = 11;
            button4.Text = "Új tétel";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1558, 604);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(117, 100);
            button5.TabIndex = 12;
            button5.Text = "Tétel törlés";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 13;
            label1.Text = "Ügyfelek szűrése";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 120);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 14;
            label2.Text = "Ügyfelek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 120);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 15;
            label3.Text = "Rendelések";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 120);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 30);
            label4.TabIndex = 16;
            label4.Text = "Rendelés címe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1159, 120);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 30);
            label5.TabIndex = 17;
            label5.Text = "Kedvezmény";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1344, 120);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 30);
            label6.TabIndex = 18;
            label6.Text = "Státusz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(684, 210);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 30);
            label7.TabIndex = 19;
            label7.Text = "Rendelt tételek";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 950);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 30);
            label8.TabIndex = 20;
            label8.Text = "label8";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1558, 434);
            textBox3.Margin = new Padding(5, 6, 5, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 35);
            textBox3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1558, 398);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(114, 30);
            label9.TabIndex = 22;
            label9.Text = "Mennyiség";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1685, 120);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(110, 30);
            label10.TabIndex = 23;
            label10.Text = "Termkékek";
            // 
            // RendelesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2028, 1024);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(tbSzuro);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RendelesForm";
            Text = "RendelesForm";
            Load += RendelesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox tbSzuro;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Label label10;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource cimEgybenDTOBindingSource;
        private BindingSource rendelesBindingSource;
    }
}