namespace Rendeles_Forms_EM9NYU
{
    partial class UgyfelSzekresztesForm
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
            textBox1 = new TextBox();
            ugyfelBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            cimBindingSource = new BindingSource(components);
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Nev", true));
            textBox1.Location = new Point(84, 7);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 0;
            textBox1.Validating += textBox1_Validating;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Email", true));
            textBox2.Location = new Point(84, 32);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 23);
            textBox2.TabIndex = 1;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Telefonszam", true));
            textBox3.Location = new Point(84, 57);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 23);
            textBox3.TabIndex = 2;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", cimBindingSource, "Orszag", true));
            textBox4.Location = new Point(84, 82);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 23);
            textBox4.TabIndex = 3;
            // 
            // cimBindingSource
            // 
            cimBindingSource.DataSource = typeof(Models.Cim);
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", cimBindingSource, "Iranyitoszam", true));
            textBox5.Location = new Point(84, 107);
            textBox5.Margin = new Padding(2, 1, 2, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", cimBindingSource, "Varos", true));
            textBox6.Location = new Point(84, 132);
            textBox6.Margin = new Padding(2, 1, 2, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(272, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", cimBindingSource, "Utca", true));
            textBox7.Location = new Point(84, 157);
            textBox7.Margin = new Padding(2, 1, 2, 1);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(272, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", cimBindingSource, "Hazszam", true));
            textBox8.Location = new Point(84, 182);
            textBox8.Margin = new Padding(2, 1, 2, 1);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(272, 23);
            textBox8.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(11, 255);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(350, 22);
            button1.TabIndex = 8;
            button1.Text = "Új elem hozzáadása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 279);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(350, 22);
            button2.TabIndex = 9;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 13;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 15;
            label3.Text = "Telefonszám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 16;
            label4.Text = "Ország";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 17;
            label5.Text = "Irányítószám";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 135);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 18;
            label6.Text = "Város";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 160);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 19;
            label7.Text = "Utca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 185);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 20;
            label8.Text = "Házszám";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UgyfelSzekresztesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 311);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(330, 350);
            Name = "UgyfelSzekresztesForm";
            Text = "UgyfelSzekresztesForm";
            Load += UgyfelSzekresztesForm_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private BindingSource ugyfelBindingSource;
        private ErrorProvider errorProvider1;
        private BindingSource cimBindingSource;
    }
}