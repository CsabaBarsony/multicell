using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiCell.World;

namespace MultiCell
{
    public partial class Form1 : Form
    {
        World.Incubator incubator;

        public Form1()
        {
            InitializeComponent();
            incubator = new World.Incubator();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
