using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPresentationOral
{
    public partial class Form1 : Form
    {
        Questionnaire questionaire;
        int auguementation=0;
        int image = 0;

        public Form1()
        {
            questionaire = new Questionnaire();
            InitializeComponent();
            afficher();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            auguementation++;          
            afficher();
        }
        private void afficher()
        {
            switch (questionaire.tableauQuestion[auguementation].typeQuestion)
            {
                case 1:
                    labelQuestion.Text = questionaire.tableauQuestion[auguementation].request;
                    buttonReponse1.Text = "Afficher la réponce";
                    buttonReponse2.Enabled = false;
                    buttonReponse3.Enabled = false;
                    buttonReponse4.Enabled = false;
                    buttonReponse5.Enabled = false;
                    buttonNext.Enabled = false;
                    break;
                case 2:

                    break;
                case 3:
                    labelQuestion.Text = questionaire.tableauQuestion[auguementation].request;
                    buttonReponse1.Text = "Afficher la réponce";
                    buttonReponse2.Enabled = false;
                    buttonReponse3.Enabled = false;
                    buttonReponse4.Enabled = false;
                    buttonReponse5.Enabled = false;
                    buttonNext.Enabled = false;
                    pictureBox1.Image = imageList1.Images[image];
                    image++;
                    break;
               
            }
            
        }

        private void buttonReponse1_Click(object sender, EventArgs e)
        {
            if (questionaire.tableauQuestion[auguementation].typeQuestion == 2)
            {

            }
            else
            {
                labelQuestion.Text = questionaire.tableauQuestion[auguementation].reponse;
                buttonNext.Enabled = true;
            }
        }
    }
}
