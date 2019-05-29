using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure2
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form title = new frm_title();
            GameController.Start_game(this);
            title.ShowDialog();
        }

        private void lbl_luck_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void pnl_character_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_gold_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void pnl_main_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pnl_controls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
