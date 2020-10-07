using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine
{
    public partial class AgentInfo : Form
    {
        AgentiPrikazivanje parent;
        public AgentInfo()
        {
            InitializeComponent();

        }
        public AgentInfo(AgentiPrikazivanje a)
        {
            parent = a;
            InitializeComponent();

        }

        private void AgentInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = parent.agenti[parent.rbrAgent].Ime;
            textBox2.Text = parent.agenti[parent.rbrAgent].Telefon.ToString();
            textBox3.Text = parent.agenti[parent.rbrAgent].Procenat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTOManager.izmeniAgent(parent.agenti[parent.rbrAgent].Id, textBox1.Text, Int32.Parse(textBox3.Text), textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
