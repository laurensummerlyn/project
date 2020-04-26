using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        Deck deck = new Deck();
        public Form1()
        {
            InitializeComponent();
        }
        public static Bitmap GetImageByName(string imageName)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new System.Resources.ResourceManager(resourceName, asm);
            return (Bitmap)rm.GetObject(imageName);

        }
        private void BtnDealCards_Click(object sender, EventArgs e)
        {
            Card card = deck.DealCard();

            string fileName = @"C:\Users\lswat\source\repos\21\21\Resources\" + card.GetFace() + card.GetSuit() + ".jpg";
            Image image = Image.FromFile(fileName);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCard1.Text = card.ToString();

            deck.Shuffle();
            card = deck.DealCard();
            fileName = @"C:\Users\lswat\source\repos\21\21\Resources\" + card.GetFace() + card.GetSuit() + ".jpg";
            image = Image.FromFile(fileName);
            pictureBox2.Image = image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCard2.Text = card.ToString();

            deck.Shuffle();
            card = deck.DealCard();
            fileName = @"C:\Users\lswat\source\repos\21\21\Resources\" + card.GetFace() + card.GetSuit() + ".jpg";
            image = Image.FromFile(fileName);
            pictureBox5.Image = image;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCard3.Text = card.ToString();

            deck.Shuffle();
            card = deck.DealCard();
            fileName = @"C:\Users\lswat\source\repos\21\21\Resources\" + card.GetFace() + card.GetSuit() + ".jpg";
            image = Image.FromFile(fileName);
            pictureBox6.Image = image;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCard4.Text = card.ToString();


        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            Card card = deck.DealCard();
            string fileName = @"C:\Users\lswat\source\repos\21\21\Resources\" + card.GetFace() + card.GetSuit() + ".jpg";
            Image image = Image.FromFile(fileName);
            pictureBox7.Image = image;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCard5.Text = card.ToString();
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
         
        }
    }
}
