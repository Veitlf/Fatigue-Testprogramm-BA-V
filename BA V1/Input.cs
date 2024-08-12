using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_V1
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }
        public string ID
        {
            get
            {
                return textBox1.Text;
            }
        }
    }
}
