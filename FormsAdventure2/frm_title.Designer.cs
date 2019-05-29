namespace FormsAdventure2
{
    partial class frm_title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_title));
            this.pbx_title = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_title)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_title
            // 
            this.pbx_title.Image = ((System.Drawing.Image)(resources.GetObject("pbx_title.Image")));
            this.pbx_title.Location = new System.Drawing.Point(87, 8);
            this.pbx_title.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_title.Name = "pbx_title";
            this.pbx_title.Size = new System.Drawing.Size(593, 95);
            this.pbx_title.TabIndex = 1;
            this.pbx_title.TabStop = false;
            this.pbx_title.Click += new System.EventHandler(this.pbx_title_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(378, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Game";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(718, 260);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "What would you like your name to be?";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(718, 287);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(291, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // frm_title
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbx_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_title";
            this.Text = "frm_title";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbx_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxName;
    }
}