using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_RDS
{
    public partial class FormUpdate : Form
    {
        private SoftUpdate update;
        public FormUpdate()
        {
            InitializeComponent();

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            update = new SoftUpdate(true);
          //  SoftUpdate update = new SoftUpdate(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = update.Bar;
            label2.Text = update.Bar + " %";

        }

    
    }
}
