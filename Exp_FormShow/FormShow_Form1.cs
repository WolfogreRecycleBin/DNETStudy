using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp_FormShow
{
    public partial class FormShow_Form1 : Form
    {
        private int new_form_count { get; set; }

        public FormShow_Form1()
        {
            InitializeComponent();
        }

        private void FormShow_Form1_Load(object sender, EventArgs e)
        {
            new_form_count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form new_form = new FormShow_Form1();
            new_form.Text = Text + "-" + "无模" + ++new_form_count;
            new_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form new_form = new FormShow_Form1();
            new_form.Text = Text + "-" + "有模" + ++new_form_count;
            new_form.ShowDialog();
        }
    }
}
