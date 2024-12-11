namespace Eclipse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            Execute = new Button();
            Inject = new Button();
            Kill = new Button();
            Clear = new Button();
            panel1 = new Panel();
            Min = new Button();
            Clo = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(559, 225);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(749, 352);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Execute
            // 
            Execute.Location = new Point(1139, 640);
            Execute.Name = "Execute";
            Execute.Size = new Size(150, 46);
            Execute.TabIndex = 1;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += button1_Click;
            // 
            // Inject
            // 
            Inject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inject.Location = new Point(559, 157);
            Inject.Name = "Inject";
            Inject.Size = new Size(144, 46);
            Inject.TabIndex = 2;
            Inject.Text = "Inject";
            Inject.UseVisualStyleBackColor = true;
            Inject.Click += Inject_Click;
            // 
            // Kill
            // 
            Kill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kill.Location = new Point(742, 157);
            Kill.Name = "Kill";
            Kill.Size = new Size(144, 46);
            Kill.TabIndex = 4;
            Kill.Text = "Kill Client";
            Kill.UseVisualStyleBackColor = true;
            Kill.Click += Kill_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(937, 640);
            Clear.Name = "Clear";
            Clear.Size = new Size(150, 46);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Min);
            panel1.Controls.Add(Clo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-90, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1708, 94);
            panel1.TabIndex = 6;
            // 
            // Min
            // 
            Min.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Min.Location = new Point(1322, 9);
            Min.Name = "Min";
            Min.Size = new Size(55, 56);
            Min.TabIndex = 9;
            Min.Text = "-";
            Min.TextAlign = ContentAlignment.TopCenter;
            Min.UseVisualStyleBackColor = true;
            Min.Click += Min_Click;
            // 
            // Clo
            // 
            Clo.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Clo.Location = new Point(1391, 9);
            Clo.Name = "Clo";
            Clo.Size = new Size(55, 56);
            Clo.TabIndex = 7;
            Clo.Text = "X";
            Clo.TextAlign = ContentAlignment.TopCenter;
            Clo.UseVisualStyleBackColor = true;
            Clo.Click += Clo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Eclipse_Logo_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 298);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 59);
            label1.TabIndex = 7;
            label1.Text = "Eclipse";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(1380, 801);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(Clear);
            Controls.Add(Kill);
            Controls.Add(Inject);
            Controls.Add(Execute);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Execute;
        private Button Inject;
        private Button Kill;
        private Button Clear;
        private Panel panel1;
        private Button Clo;
        private Button Min;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
