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
        Bitmap[] tabBitmap;
        Questionnaire questionaire;
        int auguementation = 46;
        int image = 0;

        public Form1()
        {
            tabBitmap = new Bitmap[7];


			tabBitmap[0] = new Bitmap(ProjetPresentationOral.Properties.Resources.E_t);
			tabBitmap[1] = new Bitmap(ProjetPresentationOral.Properties.Resources.DentDeLaMers);
			tabBitmap[2] = new Bitmap(ProjetPresentationOral.Properties.Resources.StarWars);
			tabBitmap[3] = new Bitmap(ProjetPresentationOral.Properties.Resources.Matrix);
			tabBitmap[4] = new Bitmap(ProjetPresentationOral.Properties.Resources.StarWars);
			tabBitmap[5] = new Bitmap(ProjetPresentationOral.Properties.Resources.ForrestGump);
			tabBitmap[6] = new Bitmap(ProjetPresentationOral.Properties.Resources.KingKong);


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
			pictureBox1.Image = null;
			buttonReponse1.Text = "";
			buttonReponse2.Text = "";
			buttonReponse3.Text = "";
			buttonReponse4.Text = "";
			buttonReponse5.Text = "";

			switch (questionaire.tableauQuestion[auguementation].typeQuestion)
            {

                case 1:					
					richTextBoxQuestionReponse.Text = questionaire.tableauQuestion[auguementation].request;
                    buttonReponse1.Text = "Afficher la réponse";
                    buttonReponse2.Enabled = false;
                    buttonReponse3.Enabled = false;
                    buttonReponse4.Enabled = false;
                    buttonReponse5.Enabled = false;
                    buttonNext.Enabled = false;
                    break;
                case 2:
					buttonReponse1.Text = questionaire.tableauQuestion[auguementation].tableauchoix[0];
					buttonReponse2.Text = questionaire.tableauQuestion[auguementation].tableauchoix[1];
					buttonReponse3.Text = questionaire.tableauQuestion[auguementation].tableauchoix[2];
					buttonReponse4.Text = questionaire.tableauQuestion[auguementation].tableauchoix[3];
					buttonReponse5.Text = questionaire.tableauQuestion[auguementation].tableauchoix[4];
					richTextBoxQuestionReponse.Text = questionaire.tableauQuestion[auguementation].request;
					buttonReponse2.Enabled = true;
                    buttonReponse3.Enabled = true;
                    buttonReponse4.Enabled = true;
                    buttonReponse5.Enabled = true;					
					buttonNext.Enabled = false;
                    break;
                case 3:
                    richTextBoxQuestionReponse.Text = questionaire.tableauQuestion[auguementation].request;
                    buttonReponse1.Text = "Afficher la réponse";
                    buttonReponse2.Enabled = false;
                    buttonReponse3.Enabled = false;
                    buttonReponse4.Enabled = false;
                    buttonReponse5.Enabled = false;
                    buttonNext.Enabled = false;
                    pictureBox1.Image = tabBitmap[image];
                    image++;
                    break;
				default:
					richTextBoxQuestionReponse.Text = "FIN!!!!!!";
					break;
			}
		
			buttonReponse1.BackColor = DefaultBackColor;
			buttonReponse2.BackColor = DefaultBackColor;
			buttonReponse3.BackColor = DefaultBackColor;
			buttonReponse4.BackColor = DefaultBackColor;
			buttonReponse5.BackColor = DefaultBackColor;

		}

		private void buttonReponse_Click(object sender, EventArgs e)
        {
            if (questionaire.tableauQuestion[auguementation].typeQuestion == 2)
            {
                Button boutonPresser = (Button)sender;
                RegarderReponse(boutonPresser);

            }
            else
            {
                richTextBoxQuestionReponse.Text = questionaire.tableauQuestion[auguementation].reponse;
                buttonNext.Enabled = true;
            }

        }
        private void RegarderReponse(Button boutton)
        {

            if (boutton.Text == questionaire.tableauQuestion[auguementation].reponse)
            {
                buttonNext.Enabled = true;
                boutton.BackColor = Color.Green;
            }
            else
            {
                boutton.BackColor = Color.Red;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void richTextBoxQuestionReponse_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
