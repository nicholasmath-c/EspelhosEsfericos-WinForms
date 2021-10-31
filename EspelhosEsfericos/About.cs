using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspelhosEsfericos
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 5)
            {
                imageNumber = 0;
            }

            imageNumber++;
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpeg", imageNumber);
        }

        private void LoadPrevImage()
        {
            if (imageNumber == 1)
            {
                imageNumber = 6;
            }

            imageNumber--;
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpeg", imageNumber);
        }

        private void LoadText()
        {
            switch (imageNumber)
            {
                case 1: txtNome.Text = "Nicholas M. A. Costa"; txtDesc.Text = "Desenvolvedor do algoritmo e aplicativo Windows"; break;
                case 2: txtNome.Text = "Mariana G. Souza"; txtDesc.Text = "Desenvolvedora da apresentação de slides"; break;
                case 3: txtNome.Text = "Maria Eduarda N. Silva"; txtDesc.Text = "Desenvolvedora da logo e apresentação de slides"; break;
                case 4: txtNome.Text = "João V. S. Santos"; txtDesc.Text = "Auxiliar criativo no desenvovimento do front-end"; break;
                case 5: txtNome.Text = "Pedro L. F. Filho"; txtDesc.Text = "Desenvolvedor Web do site"; break;
            }
        }

        private void OpenInstagram()
        {
            switch(imageNumber)
            {
                case 1: System.Diagnostics.Process.Start("https://www.instagram.com/mus4ng/"); break;
                case 2: System.Diagnostics.Process.Start("https://www.instagram.com/marigalvincio/"); break;
                case 3: System.Diagnostics.Process.Start("https://www.instagram.com/dudaens_/"); break;
                case 4: System.Diagnostics.Process.Start("https://www.instagram.com/jvs4nt/"); break;
                case 5: System.Diagnostics.Process.Start("https://www.instagram.com/pedrofranca_br/"); break;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            LoadNextImage();
            LoadText();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            LoadPrevImage();
            LoadText();
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            OpenInstagram();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        
    }
}
