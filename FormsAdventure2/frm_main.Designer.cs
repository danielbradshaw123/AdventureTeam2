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
            this.pnl_character = new System.Windows.Forms.Panel();
            this.btn_items = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_gold = new System.Windows.Forms.Label();
            this.lbl_luck = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_character = new System.Windows.Forms.Label();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.pnl_character.SuspendLayout();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_main.Controls.Add(this.button1);
            this.pnl_main.Location = new System.Drawing.Point(4, 163);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1414, 1011);
            this.pnl_main.TabIndex = 0;
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
            // pnl_character
            // 
            this.pnl_character.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_character.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_character.Controls.Add(this.btn_items);
            this.pnl_character.Controls.Add(this.lbl_score);
            this.pnl_character.Controls.Add(this.lbl_gold);
            this.pnl_character.Controls.Add(this.lbl_luck);
            this.pnl_character.Controls.Add(this.lbl_name);
            this.pnl_character.Controls.Add(this.lbl_character);
            this.pnl_character.Location = new System.Drawing.Point(1428, 177);
            this.pnl_character.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_character.Name = "pnl_character";
            this.pnl_character.Size = new System.Drawing.Size(326, 987);
            this.pnl_character.TabIndex = 1;
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
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(18, 445);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(109, 37);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score:";
            // 
            // lbl_gold
            // 
            this.lbl_gold.AutoSize = true;
            this.lbl_gold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gold.Location = new System.Drawing.Point(18, 362);
            this.lbl_gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gold.Name = "lbl_gold";
            this.lbl_gold.Size = new System.Drawing.Size(94, 37);
            this.lbl_gold.TabIndex = 4;
            this.lbl_gold.Text = "Gold:";
            // 
            // lbl_luck
            // 
            this.lbl_luck.AutoSize = true;
            this.lbl_luck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_luck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_luck.Location = new System.Drawing.Point(18, 269);
            this.lbl_luck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_luck.Name = "lbl_luck";
            this.lbl_luck.Size = new System.Drawing.Size(94, 37);
            this.lbl_luck.TabIndex = 3;
            this.lbl_luck.Text = "Luck:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(18, 175);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(121, 37);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: ";
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
            // pnl_controls
            // 
            this.pnl_controls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_controls.Controls.Add(this.lbl_title);
            this.pnl_controls.Location = new System.Drawing.Point(4, 0);
            this.pnl_controls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(2102, 168);
            this.pnl_controls.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(72, 48);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(488, 46);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Mr Bradshaw Is The Best";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 1050);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.pnl_character);
            this.Controls.Add(this.pnl_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.Text = "Awesome Adventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_character.ResumeLayout(false);
            this.pnl_character.PerformLayout();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_character;
        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_character;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_gold;
        private System.Windows.Forms.Label lbl_luck;
        private System.Windows.Forms.Button button1;
    }
}

