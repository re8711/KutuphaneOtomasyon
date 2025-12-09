using KutuphaneOtomasyon.formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i != 100)
            {
                i++;
            }
            else
            {
                timer1.Stop();
                login asd = new login();
                asd.Show();
                this.Hide();
            }
        }
    }
}
