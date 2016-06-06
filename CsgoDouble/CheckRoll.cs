using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsgoDouble
{
    public partial class CheckRoll : Form
    {
        private List<string> rolls;

        public CheckRoll()
        {
            InitializeComponent();
        }

        public CheckRoll(List<string> rolls)
        {
            InitializeComponent();
            this.rolls = rolls;
        }

        private void CheckRoll_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int round_id = Convert.ToInt32(textBox1.Text);
            label1.Text = rolls[round_id];
        }
    }
}
