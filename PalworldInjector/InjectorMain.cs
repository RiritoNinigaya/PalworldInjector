using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PalworldInjector
{
    public partial class InjectorMain : Form
    {
        Process[] GetCurrentProcess()
        {
            return Process.GetProcessesByName("Palworld-Win64-Shipping.exe");
        }
        public InjectorMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] proc = GetCurrentProcess();
            Memory.Mem mem = new Memory.Mem();
            foreach(Process process in proc)
            {
                if (mem.OpenProcess(process.Id))
                {
                    mem.InjectDll(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Error: Process not Found or You're Writing Wrong Directory", "PalworldInjector", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
