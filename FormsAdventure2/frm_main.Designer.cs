namespace FormsAdventure2
{
    partial class frm_main
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_character = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_gold = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_items = new System.Windows.Forms.Button();
            this.pnl_character = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.pnl_controls.SuspendLayout();
            this.pnl_character.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_main.Controls.Add(this.button1);
            this.pnl_main.Location = new System.Drawing.Point(4, 200);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(960, 500);
            this.pnl_main.TabIndex = 0;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnl_controls
            // 
            this.pnl_controls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_controls.Controls.Add(this.button2);
            this.pnl_controls.Location = new System.Drawing.Point(4, 0);
            this.pnl_controls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(1277, 200);
            this.pnl_controls.TabIndex = 3;
            this.pnl_controls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_controls_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1121, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_character
            // 
            this.lbl_character.AutoSize = true;
            this.lbl_character.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_character.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_character.Location = new System.Drawing.Point(82, 22);
            this.lbl_character.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_character.Name = "lbl_character";
            this.lbl_character.Size = new System.Drawing.Size(195, 46);
            this.lbl_character.TabIndex = 1;
            this.lbl_character.Text = "Character";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(26, 108);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(121, 37);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_gold
            // 
            this.lbl_gold.AutoSize = true;
            this.lbl_gold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gold.Location = new System.Drawing.Point(26, 189);
            this.lbl_gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gold.Name = "lbl_gold";
            this.lbl_gold.Size = new System.Drawing.Size(94, 37);
            this.lbl_gold.TabIndex = 4;
            this.lbl_gold.Text = "Gold:";
            this.lbl_gold.Click += new System.EventHandler(this.lbl_gold_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(26, 268);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(109, 37);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score:";
            // 
            // btn_items
            // 
            this.btn_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Location = new System.Drawing.Point(28, 534);
            this.btn_items.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(171, 92);
            this.btn_items.TabIndex = 6;
            this.btn_items.Text = "Items";
            this.btn_items.UseVisualStyleBackColor = true;
            // 
            // pnl_character
            // 
            this.pnl_character.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_character.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_character.Controls.Add(this.btn_items);
            this.pnl_character.Controls.Add(this.lbl_score);
            this.pnl_character.Controls.Add(this.lbl_gold);
            this.pnl_character.Controls.Add(this.lbl_name);
            this.pnl_character.Controls.Add(this.lbl_character);
            this.pnl_character.Location = new System.Drawing.Point(962, 200);
            this.pnl_character.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_character.Name = "pnl_character";
            this.pnl_character.Size = new System.Drawing.Size(330, 503);
            this.pnl_character.TabIndex = 1;
            this.pnl_character.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_character_Paint);
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 700);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.pnl_character);
            this.Controls.Add(this.pnl_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Awesome Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_controls.ResumeLayout(false);
            this.pnl_character.ResumeLayout(false);
            this.pnl_character.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.Label lbl_character;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gold;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Panel pnl_character;
        private System.Windows.Forms.Button button2;
    }
}

