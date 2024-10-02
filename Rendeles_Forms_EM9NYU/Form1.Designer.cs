namespace Rendeles_Forms_EM9NYU
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(269, 169);
            button2.Name = "button2";
            button2.Size = new Size(269, 23);
            button2.TabIndex = 1;
            button2.Text = "Ügyfelek kezelése";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(269, 215);
            button1.Name = "button1";
            button1.Size = new Size(269, 23);
            button1.TabIndex = 2;
            button1.Text = "Kategóriák kezelése";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 70);
            label1.TabIndex = 3;
            label1.Text = "Főoldal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 435);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            MinimumSize = new Size(500, 300);
            Name = "Form1";
            Text = "Főoldal";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Label label1;
    }
}