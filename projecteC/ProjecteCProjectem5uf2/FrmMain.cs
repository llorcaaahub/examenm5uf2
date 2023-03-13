using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteCProjectem5uf2
{
    public partial class FrmMain : Form
    {
        FrmMenjar formMenjar = null;
        FrmViatge formViatge = null;
        FrmAnimal formAnimal = null;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnMenjar_Click(object sender, EventArgs e)
        {
            if (!isOpen("FrmMenjar"))
            {
                formMenjar = new FrmMenjar();
                formMenjar.MdiParent = this;
                formMenjar.Show();
            }
            else
            {
                MessageBox.Show("Ja tens obert aquest Formulari", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViatge_Click(object sender, EventArgs e)
        {
            if (!isOpen("FrmViatge"))
            {
                formViatge = new FrmViatge();
                formViatge.MdiParent = this;
                formViatge.Show();
            }
            else
            {
                MessageBox.Show("Ja tens obert aquest Formulari", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Boolean isOpen(string formulari)
        {
            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == formulari);
                x1++;
            }
            return xb;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            if (!isOpen("FrmAnimal"))
            {
                formAnimal = new FrmAnimal();
                formAnimal.MdiParent = this;
                formAnimal.Show();
            }
            else
            {
                MessageBox.Show("Ja tens obert aquest Formulari", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
