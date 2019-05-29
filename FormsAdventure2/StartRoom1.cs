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
    public partial class StartRoom1 : Form
    {
        public StartRoom1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameController.ShowSubform(new Room5());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameController.ShowSubform(new Room2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameController.ShowSubform(new Room16());
        }
    }
}
