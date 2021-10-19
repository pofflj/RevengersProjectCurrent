using System;
using System.Windows.Forms;
using BoardGame;

namespace RevengerProject3
{
    public partial class RollDice : Form
    {
        Random dicerolling = new Random();
        Dice d1 = new Dice();
        public RollDice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNumber1 = dicerolling.Next(1, 7);
            switch (randNumber1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            int randNumber2 = dicerolling.Next(1, 7);
            switch (randNumber2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            int randNumber3 = dicerolling.Next(1, 7);
            switch (randNumber3)
            {
                case 1:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox3.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                    //DiceImage.ImageLocation  =       

            }
            int randNumber4 = dicerolling.Next(1, 7);
            switch (randNumber4)
            {
                case 1:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox4.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            int randNumber5 = dicerolling.Next(1, 7);
            switch (randNumber5)
            {
                case 1:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox5.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            int randNumber6 = dicerolling.Next(1, 7);
            switch (randNumber6)
            {
                case 1:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollOne.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollTwo.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollThree.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFour.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\DiceRollFive.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox6.ImageLocation = @"C:\Users\lukep\Software Engeneering 1\RollDiceSix.png";
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void DiceImage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RollDice_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }



    }

}

    

