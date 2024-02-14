using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalworldInjector
{
    public partial class InjectorMain : Form
    {
        public InjectorMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textbox = textBox1.Text;
            Memory.Mem mem = new Memory.Mem();
            bool opened = mem.OpenProcess("Palworld-Win64-Shipping.exe");
            if (opened)
            {
                mem.InjectDll(textbox);
            }
            else
            {
                MessageBox.Show("Error: Process not Found or You're Writing Wrong Directory", "PalworldInjector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
