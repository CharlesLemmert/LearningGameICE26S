﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LearningGame1
{
    public partial class Days : Form
    {   
        private static string pointSave = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\SavedScore.txt";
        private string[] value = File.ReadAllLines(pointSave);
        
        private static string pointSaveM = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\Mistakes.txt";
        private string[] valueM = File.ReadAllLines(pointSaveM);
        
        private static string pointSaveScore = @"C:\Users\joshu\source\repos\LearningGameICE26S(Design)\SavedScore.txt";
        private string[] valueScore = File.ReadAllLines(pointSaveScore);
        
        private int a = 0;
        private int b = 0;

        private System.Media.SoundPlayer hint1 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint2 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint3 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint4 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint5 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint6 = new System.Media.SoundPlayer();
        private System.Media.SoundPlayer hint7 = new System.Media.SoundPlayer();

        public Days()
        {
            InitializeComponent();
            hint1.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Maandag.wav";
            hint2.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\dinsdag.wav";
            hint3.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Woensdag.wav";
            hint4.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Donderdag.wav";
            hint5.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Vrydag.wav";
            hint6.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Saterdag.wav";
            hint7.SoundLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\soundDaysoftheweek\Sondag.wav";
        }

        private void letter1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblScore.Text = value[0];
            //converting the array value to an integer
            a = int.Parse(value[0]);

            switch (a)
            {

                case 0:
                    LevelOne();
                    break;
                case 1:
                    LevelTwo();
                    break;
                case 2:
                    LevelThree();
                    break;
                case 3:
                    LevelFour();
                    break;
                case 4:
                    LevelFive();
                    break;
                case 5:
                    LevelSix();
                    break;
                case 6:
                    LevelSeven();
                    break;
                case 7:
                    MessageBox.Show("***YOU HAVE COMPLETED THIS LEVEL***");
                    Close();

                    break;
                default:
                    MessageBox.Show("It is Done");
                    break;




            }


        }
        //--------------------------------------------------------------Level methods where the position of the textboxes and text values are set
        private void LevelOne()
        {
            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(534, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(117, 55);
            t4.Location = new Point(228, 55);
            t5.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "M";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "A";
            letter4.Text = "N";
            letter4.ForeColor = Color.White;
            letter5.Text = "D";
            letter6.Text = "A";
            letter6.ForeColor = Color.White;
            letter7.Text = "G";
            letter8.Visible = false;
            letter9.Visible = false;
            t6.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\M.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;



        }
        private void LevelTwo()
        {
            a = 0;
            String res2 = a.ToString();
            valueM[0] = res2;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res2;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(534, 131);
            hintGroupBox.Location = new Point(698, 211);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(117, 55);
            t4.Location = new Point(228, 55);
            t5.Location = new Point(333, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;

            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "D";
            letter2.Text = "I";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Text = "S";
            letter4.ForeColor = Color.White;
            letter5.Text = "D";
            letter6.Text = "A";
            letter6.ForeColor = Color.White;
            letter7.Text = "G";
            letter8.Visible = false;
            letter9.Visible = false;
            t6.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\D.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelThree()
        {
            a = 0;
            String res3 = a.ToString();
            valueM[0] = res3;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res3;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(609, 131);
            hintGroupBox.Location = new Point(646, 208);
            answerGroupBox.Size = new Size(497, 125);
            t3.Location = new Point(125, 55);
            t4.Location = new Point(200, 55);
            t5.Location = new Point(272, 55);
            t6.Location = new Point(344, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;
            letter8.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;
            t6.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "W";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "E";
            letter4.Text = "N";
            letter4.ForeColor = Color.White;
            letter5.Text = "S";
            letter6.Text = "D";
            letter6.ForeColor = Color.White;
            letter7.Text = "A";
            letter8.Text = "G";
            letter8.ForeColor = Color.White;
            letter9.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\W.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelFour()
        {
            a = 0;
            String res4 = a.ToString();
            valueM[0] = res4;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res4;

            //adjusting the size and position of the group boxes
            hintGroupBox.Size = new Size(691, 131);
            hintGroupBox.Location = new Point(597, 210);
            answerGroupBox.Size = new Size(497, 125);
            t3.Location = new Point(125, 55);
            t4.Location = new Point(200, 55);
            t5.Location = new Point(272, 55);
            t6.Location = new Point(344, 55);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;
            letter8.TextAlign = HorizontalAlignment.Center;
            letter9.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;
            t6.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "D";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Text = "D";
            letter4.ForeColor = Color.White;
            letter5.Text = "E";
            letter6.Text = "R";
            letter6.ForeColor = Color.White;
            letter7.Text = "D";
            letter8.Text = "A";
            letter8.ForeColor = Color.White;
            letter9.Text = "G";

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\D1.jfif";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelFive()
        {
            a = 0;
            String res5 = a.ToString();
            valueM[0] = res5;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res5;

            //adjusting the size and position of the group boxes, textboxes
            hintGroupBox.Size = new Size(493, 131);
            hintGroupBox.Location = new Point(698, 210);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(117, 55);
            t4.Location = new Point(228, 55);
            t5.Location = new Point(333, 55);

            letter1.Location = new Point(30, 50);
            letter2.Location = new Point(105, 50);
            letter3.Location = new Point(180, 50);
            letter4.Location = new Point(255, 50);
            letter5.Location = new Point(330, 50);
            letter6.Location = new Point(405, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;

            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "V";
            letter2.Text = "R";
            letter2.ForeColor = Color.White;
            letter3.Text = "Y";
            letter4.Text = "D";
            letter4.ForeColor = Color.White;
            letter5.Text = "A";
            letter6.Text = "G";
            letter6.ForeColor = Color.White;
            letter7.Visible = false;
            letter8.Visible = false;
            letter9.Visible = false;
            t6.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\V.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void LevelSix()
        {
            a = 0;
            String res6 = a.ToString();
            valueM[0] = res6;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res6;

            //adjusting the size and position of the group boxes, textboxes
            hintGroupBox.Size = new Size(617, 131);
            hintGroupBox.Location = new Point(646, 208);
            answerGroupBox.Size = new Size(497, 125);
            t3.Location = new Point(125, 55);
            t4.Location = new Point(200, 55);
            t5.Location = new Point(272, 55);
            t6.Location = new Point(344, 55);

            letter1.Location = new Point(14, 50);
            letter2.Location = new Point(89, 50);
            letter3.Location = new Point(164, 50);
            letter4.Location = new Point(239, 50);
            letter5.Location = new Point(314, 50);
            letter6.Location = new Point(389, 50);
            letter7.Location = new Point(464, 50);
            letter8.Location = new Point(539, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;
            letter7.TextAlign = HorizontalAlignment.Center;
            letter8.TextAlign = HorizontalAlignment.Center;
            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;
            t6.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "S";
            letter2.Text = "A";
            letter2.ForeColor = Color.White;
            letter3.Text = "T";
            letter4.Text = "E";
            letter4.ForeColor = Color.White;
            letter5.Text = "R";
            letter6.Text = "D";
            letter6.ForeColor = Color.White;
            letter7.Text = "A";
            letter8.Text = "G";
            letter8.ForeColor = Color.White;
            letter9.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\S.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void LevelSeven()
        {
            a = 0;
            String res7 = a.ToString();
            valueM[0] = res7;
            File.WriteAllLines(pointSaveM, valueM);
            lblMistakes.Text = res7;

            //adjusting the size and position of the group boxes, textboxes
            hintGroupBox.Size = new Size(493, 131);
            hintGroupBox.Location = new Point(698, 210);
            answerGroupBox.Size = new Size(493, 125);

            t3.Location = new Point(117, 55);
            t4.Location = new Point(228, 55);
            t5.Location = new Point(333, 55);

            letter1.Location = new Point(30, 50);
            letter2.Location = new Point(105, 50);
            letter3.Location = new Point(180, 50);
            letter4.Location = new Point(255, 50);
            letter5.Location = new Point(330, 50);
            letter6.Location = new Point(405, 50);

            //setting the position of the placeholder and input text to the center porsition of the screen
            letter1.TextAlign = HorizontalAlignment.Center;
            letter2.TextAlign = HorizontalAlignment.Center;
            letter3.TextAlign = HorizontalAlignment.Center;
            letter4.TextAlign = HorizontalAlignment.Center;
            letter5.TextAlign = HorizontalAlignment.Center;
            letter6.TextAlign = HorizontalAlignment.Center;

            t3.TextAlign = HorizontalAlignment.Center;
            t4.TextAlign = HorizontalAlignment.Center;
            t5.TextAlign = HorizontalAlignment.Center;

            //adding values to the placeholders and setting unused textboxes visibility to false
            letter1.Text = "S";
            letter2.Text = "O";
            letter2.ForeColor = Color.White;
            letter3.Text = "N";
            letter4.Text = "D";
            letter4.ForeColor = Color.White;
            letter5.Text = "A";
            letter6.Text = "G";
            letter6.ForeColor = Color.White;
            letter7.Visible = false;
            letter8.Visible = false;
            letter9.Visible = false;
            t6.Visible = false;

            //getting the image from it location and adding it to the picturebox
            pBox1.ImageLocation = @"C:\Users\joshu\Dropbox\My PC (LAPTOP-GL5QPPVH)\Downloads\GameDev-Assignment-2-220498385 (1) - 1\GameDev-Assignment-2-220498385\GameDev-Assignment-2-master\images\S1.jpg";
            pBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        //--------------------------------------------------------------MatchUp methods responsible for checking whether the placeholders match the letters entered by the user
        private void MatchUpOne()
        {
            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {



                MessageBox.Show("                    ***MAANDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();



            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {




                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();


            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }


        }
        private void MatchUpTwo()
        {


            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {



                MessageBox.Show("                    ***DINSDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();



            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {




                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();


            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

        }
        private void MatchUpThree()
        {


            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("                   ***WOENSDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }


        }
        private void MatchUpFour()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("                  ***DONDERDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();
            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();
            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }







        }
        private void MatchUpFive()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("                   ***VRYDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {

                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

        }
        private void MatchUpSix()
        {


            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("                   ***SATERDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper() && letter8.Text == t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper() && letter8.Text != t6.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }


        }
        private void MatchUpSeven()
        {

            //if else staments that are checking whether the place holder values equal to the users input value

            //if match is found( letter2 == t3 but letter4 == t4)
            if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("                   ***SONDAG***\n***YOU HAVE ANSWERED CORRECTLY***");
                PointSystemMatches();

            }

            //else if match is not found( letter2 != t3 but letter4 != t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {

                MessageBox.Show("***INCORRECT ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 != t3 but letter4 == t4)
            else if (letter2.Text != t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {

                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

            //else if one match is not found but the other is( letter2 = t3 but letter4 != t4)
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text == t4.Text.ToUpper() && letter6.Text != t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }
            else if (letter2.Text == t3.Text.ToUpper() && letter4.Text != t4.Text.ToUpper() && letter6.Text == t5.Text.ToUpper())
            {
                MessageBox.Show("***YOU ALMOST GOT THE ANSWER***");
                PointSystemDoesNotMatch();

            }

        }
        //------------------------------------------------------------------------------------------------------------PointSystemMatch() checks the current point in the text file and increments it by 1
        private void PointSystemMatches()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);

            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {

                case 0:
                    a += 1;
                    String val = a.ToString();
                    value[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val;
                    resetToNewQuestion();

                    break;
                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    value[0] = val1;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val1;
                    resetToNewQuestion();
                    break;
                case 2:
                    a += 1;
                    String val2 = a.ToString();
                    value[0] = val2;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val2;
                    resetToNewQuestion();
                    break;
                case 3:
                    a += 1;
                    String val3 = a.ToString();
                    value[0] = val3;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val3;
                    resetToNewQuestion();
                    break;
                case 4:
                    a += 1;
                    String val4 = a.ToString();
                    value[0] = val4;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val4;
                    resetToNewQuestion();
                    break;
                case 5:
                    a += 1;
                    String val5 = a.ToString();
                    value[0] = val5;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val5;
                    resetToNewQuestion();
                    break;
                case 6:
                    a += 1;
                    String val6 = a.ToString();
                    value[0] = val6;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val6;
                    resetToNewQuestion();
                    break;

                default:
                    MessageBox.Show("Program Failed");
                    break;
            }




        }
        //------------------------------------------------------------------------------------------------------------PointSystemDoesNotMatch() checks the current  lose point in the text file and increments it by 1
        private void PointSystemDoesNotMatch()
        {
            //converting the array value to an integer
            a = int.Parse(valueM[0]);

            //incrementing by one and saving the new value to the file for later use
            switch (a)
            {
                case 0:
                    a += 1;
                    String val = a.ToString();
                    valueM[0] = val;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";
                    lblMistakes.Text = val;
                    break;

                case 1:
                    a += 1;
                    String val1 = a.ToString();
                    valueM[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";
                    lblMistakes.Text = val1;
                    break;

                case 2:
                    a += 1;
                    String val2 = a.ToString();
                    valueM[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveM, valueM);
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";
                    lblMistakes.Text = val2;
                    GameOver();
                    break;
                
                default:
                    MessageBox.Show("GAME OVER");
                    break;

            }
        }
        //------------------------------------------------------------------------------------------------------------ResetToNewQuestion() check the current score and calls the next level according to the current score value
        private void resetToNewQuestion()
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);
            
            //The switch when called will check the value in the txt file and call the level after that value e.g(a =1 that means call level 2).
            switch (a)
            {

                case 0:
                    letter7.Visible = true;
                    LevelOne();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";

                    break;
                case 1:
                    t6.Visible = true;
                    LevelTwo();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";

                    break;
                case 2:
                    letter8.Visible = true;
                    letter9.Visible = true;
                    t6.Visible = true;
                    LevelThree();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";

                    break;
                case 3:
                    letter8.Visible = true;
                    letter9.Visible = true;
                    t6.Visible = true;
                    LevelFour();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";

                    break;
                case 4:
                    LevelFive();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";

                    break;
                case 5:
                    letter7.Visible = true;
                    letter8.Visible = true;
                    letter9.Visible = true;
                    t6.Visible = true;
                    LevelSix();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    t6.Text = "";

                    break;
                case 6:
                    LevelSeven();
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";

                    break;
                case 7:

                    MessageBox.Show("***YOU HAVE COMPLETED ALL LEVELS RETURN TO GAME SELECTION***");
                    //RESET LBLSCORE TO 0 AND RERUN THE PROGRAM IN A LOOP
                    a = 0;
                    String val = a.ToString();
                    value[0] = val;
                    //writing the current score value to the SavedScore text file
                    File.WriteAllLines(pointSave, value);
                    lblScore.Text = val;

                    this.Hide();
                    LevelOptionsForm levelsCaller = new LevelOptionsForm();
                    levelsCaller.ShowDialog();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("It Has been completed!");
                    break;




            }




        }

        private void GameOver()
        {
            a = 0;
            String val = a.ToString();
            value[0] = val;

            //writing the current score value to the SavedScore text file
            File.WriteAllLines(pointSave, value);
            lblScore.Text = val;

            MessageBox.Show("                  ***YOU HAVE FAILED THIS LEVEL***\n   ***THE LEVEL WILL RESET WHEN YOU CLICK ON OK***");
            //---------------------------------------------------------------------------------------------------------------------------------------

            //converting the array value to an integer
            b = int.Parse(valueScore[0]);

            switch (b)
            {

                case 0:
                    b = 0;
                    String val1 = b.ToString();
                    valueScore[0] = val1;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val1;
                    resetToNewQuestion();

                    break;
                case 1:
                    b = 0;
                    String val2 = b.ToString();
                    valueScore[0] = val2;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val2;
                    resetToNewQuestion();

                    break;
                case 2:
                    b = 0;
                    String val3 = b.ToString();
                    valueScore[0] = val3;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val3;
                    resetToNewQuestion();

                    break;
                case 3:
                    b = 0;
                    String val4 = b.ToString();
                    valueScore[0] = val4;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val4;
                    resetToNewQuestion();

                    break;
                case 4:
                    b = 0;
                    String val5 = b.ToString();
                    valueScore[0] = val5;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val5;
                    resetToNewQuestion();

                    break;
                case 5:
                    b = 0;
                    String val6 = b.ToString();
                    valueScore[0] = val6;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val6;
                    resetToNewQuestion();

                    break;
                case 6:
                    b = 0;
                    String val7 = b.ToString();
                    valueScore[0] = val7;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val7;
                    resetToNewQuestion();

                    break;
                case 7:
                    b = 0;
                    String val8 = b.ToString();
                    valueScore[0] = val8;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val8;
                    resetToNewQuestion();

                    break;

                case 8:
                    b = 0;
                    String val9 = b.ToString();
                    valueScore[0] = val9;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val9;
                    resetToNewQuestion();

                    break;
                case 9:
                    b = 0;
                    String val10 = b.ToString();
                    valueScore[0] = val10;
                    //writing the current score value to the Mistakes text file
                    File.WriteAllLines(pointSaveScore, valueScore);
                    lblMistakes.Text = val10;
                    resetToNewQuestion();

                    break;
                case 10:
                    resetToNewQuestion();

                    break;
                default:
                    MessageBox.Show("It Has been completed!");
                    break;



            }



        }

        private void pointsLbl_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);
            
            switch (a)
            {

                case 0:
                    MatchUpOne();
                    break;
                case 1:
                    MatchUpTwo();
                    break;
                case 2:
                    MatchUpThree();
                    break;
                case 3:
                    MatchUpFour();
                    break;
                case 4:
                    MatchUpFive();
                    break;
                case 5:
                    MatchUpSix();
                    break;
                case 6:
                    MatchUpSeven();
                    break;
                default:
                    MessageBox.Show("It is done");
                    break;




            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //converting the array value to an integer
            a = int.Parse(value[0]);
            
            switch (a)
            {

                case 0:
                    hint1.Play();
                    break;
                case 1:
                    hint2.Play();
                    break;
                case 2:
                    hint3.Play();
                    break;
                case 3:
                    hint4.Play();
                    break;
                case 4:
                    hint5.Play();
                    break;
                case 5:
                    hint6.Play();
                    break;
                case 6:
                    hint7.Play();
                    break;
                default:
                    MessageBox.Show("It is done");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LevelOptionsForm levelsCaller = new LevelOptionsForm();
            levelsCaller.ShowDialog();
            this.Close();
        }
    }
}
