using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FormThread
{
    public partial class Form1 : Form
    {
        public delegate void Callback();
        public Thread thread;

        public Form1()
        {
            InitializeComponent();
            thread = new Thread(AsignarHora);
            thread.Start();
        }

        public void AsignarHora()
        {
            while(true)
            {
                this.InsertarHora();
            }
        }

        public void InsertarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                Callback d = new Callback(this.InsertarHora);
                this.Invoke(d);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.thread.Abort();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateHora.Text = DateTime.Now.ToString();
        }
    }
}
