using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBancoDeSangre
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void Logo_Load(object sender, EventArgs e)
        {
            

        }

        public void fn_prbar_()
        {
            pbrlogo.Increment(1);
            if(pbrlogo.Value == pbrlogo.Maximum)
            {
                tmrBarra.Stop();
                this.Hide();
                frmUser pasar = new frmUser();
                pasar.Show();
            }
        }

        private void tmrBarra_Tick(object sender, EventArgs e)
        {
            fn_prbar_();

        }
    }
}
