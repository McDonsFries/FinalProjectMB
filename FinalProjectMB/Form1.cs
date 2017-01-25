///mikayla and brooke
///final project
///Dec-Jan 2016-17
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FinalProjectMB
{
    public partial class finalProject : Form
    {
        int scene = 1;  // tracks what part of the game the user is at
        Random randgen = new Random();
        int pixels = 1;
        int xyou = 230;
        int yyou = 330;
        int widthyou = 30;
        int heightyou = 60;

        //Graphicic objects
        Graphics g;
        SolidBrush boomBrush1 = new SolidBrush(Color.Yellow);
        SolidBrush boomBrush2 = new SolidBrush(Color.OrangeRed);
        SolidBrush boomBrush3 = new SolidBrush(Color.Red);
        SolidBrush houseBrush = new SolidBrush(Color.Brown);
        SolidBrush treebrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush uppertree = new SolidBrush(Color.Green);
        SolidBrush redpathBrush = new SolidBrush(Color.Red);
        SolidBrush demonBrush = new SolidBrush(Color.Black);
        SolidBrush waterBrush = new SolidBrush(Color.Blue);
        SolidBrush demoneyesBrush = new SolidBrush(Color.Red);
        SolidBrush bulbBrush = new SolidBrush(Color.Yellow);
        SolidBrush stairBrush = new SolidBrush(Color.Black);
        Pen drawPen = new Pen(Color.Black, 3);
        Pen WaterPen = new Pen(Color.Blue, 4);
        Pen housePen = new Pen(Color.Brown, 20);
        //Sounds
        SoundPlayer creak = new SoundPlayer(Properties.Resources.creaky);
        SoundPlayer slam = new SoundPlayer(Properties.Resources.doorSlam);
        SoundPlayer growl = new SoundPlayer(Properties.Resources.growlgrowl);
        SoundPlayer locklock = new SoundPlayer(Properties.Resources.locklock);
        SoundPlayer walking = new SoundPlayer(Properties.Resources.walkin);
        SoundPlayer tearing = new SoundPlayer(Properties.Resources.tear);

        GameForm gf;

        public finalProject()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            outputLabel.Text = "You want to go on a hike, do you go down the forest path or the bright red path?";
            spaceLabel.Text = "Forest Path";
            mLabel.Text = "Bright Red Path";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 22;
                }
                else if (scene == 13)
                {
                    scene = 22;
                }
                else if (scene == 14)
                {
                    scene = 22;
                }

                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 18)
                {
                    scene = 22;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 20)
                {
                    scene = 22;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (scene == 1)
                {
                    scene = 8;
                }
                else if (scene == 2)
                {
                    scene = 7;
                }
                else if (scene == 3)
                {
                    scene = 13;
                }
                else if (scene == 4)
                {
                    scene = 14;
                }
                else if (scene == 5)
                {
                    scene = 15;
                }
                else if (scene == 6)
                {
                    scene = 22;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 11;
                }
                else if (scene == 9)
                {
                    scene = 16;
                }
                else if (scene == 10)
                {
                    scene = 16;
                }
                else if (scene == 11)
                {
                    scene = 19;
                }
                else if (scene == 15)
                {
                    scene = 22;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 22;
                }
                else if (scene == 19)
                {
                    scene = 21;
                }
                else if (scene == 21)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 1;
                }
            }

            switch (scene)
            {
                case 1:
                    outputLabel.Text = "You want to go on a hike,\n do you go down the forest path or the bright red path?";
                    spaceLabel.Text = "Forest Path";
                    mLabel.Text = "Bright Red Path";
                    break;
                case 2:
                    outputLabel.Text = "You come across a river, do you go swimming?";
                    spaceLabel.Text = "no";
                    mLabel.Text = "yes";
                    break;
                case 3:
                    outputLabel.Text = "You take off your clothes but see someone watching nearby, do you get out?";
                    spaceLabel.Text = "Yes";
                    mLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "You get your clothes on without being noticed and continue your hike but you start to feel hungry. You check your bag for food to find that you forgot to pack a lunch. Do you start to hunt for food or skip the meal?";
                    spaceLabel.Text = "Start to hunt";
                    mLabel.Text = "Skip the meal";
                    break;
                case 5:
                    outputLabel.Text = "You catch a rabbit and make a fire to cook it. You see a lake and want some water. You see that the water is dirty, do you drink from it?";
                    spaceLabel.Text = "Yes";
                    mLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You decide to end your hike and go home because youre so thirsty.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You got past the Snake";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    gf = new FinalProjectMB.GameForm();
                    gf.Show();
                    break;
                case 8:
                    outputLabel.Text = "You come across an abandoned house, do you you go in or keep on the path?";
                    spaceLabel.Text = "Keep on the path";
                    mLabel.Text = "Go in the house";
                    break;

                case 9:
                    outputLabel.Text = "You enter the house and see some stairs leading upstairs and into a basement, where do you go?";
                    spaceLabel.Text = "Basement";
                    mLabel.Text = "Upstairs";
                    break;
                case 10:
                    outputLabel.Text = "You see a light switch and decide to try it. The lights flicker on and you keep walking. The floor creaks as you walk. You find nothing upstairs and head back downstairs. Do you leave or go into the basement?";
                    spaceLabel.Text = "Go to the basement";
                    mLabel.Text = "Leave";
                    break;
                case 11:
                    outputLabel.Text = "You keep going and hear twigs snap in the forest behind you. Explore or keep going?";
                    spaceLabel.Text = "Keep going";
                    mLabel.Text = "Explore";
                    break;
                case 12:
                    outputLabel.Text = "When you walk into the forest you see the noise was made by a deer, you calm down and continue on your way. As you reach your destination, which was your grandmothers house in the middle of the spooky woods. Your basket swings beside you as you walk.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;

                case 13:
                    outputLabel.Text = "You got past the snake!!";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    Thread.Sleep(1000);
                    gf = new FinalProjectMB.GameForm();
                    gf.Show();
                    break;

                case 14:
                    outputLabel.Text = "You then get lost, and faint, no one find you and you get eaten by a bear.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;

                case 15:
                    outputLabel.Text = "You die from the contaminated water.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "As you reach the bottom of the stairs the door slams behind you, and when you try to open it it wont budge. You explore more to find a flashlight on the floor. Do you try to openn the door or explore the basement? ";
                    spaceLabel.Text = "Explore the basement";
                    mLabel.Text = "Try the door";
                    break;
                case 17:
                    outputLabel.Text = "The door refuses to open and you hear something fall behind you. You turn to see a woman with black eyes coming to attack you. You die of stab wounds and our body is never found.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You explore the basement to find a dead body, you scream and run towards the exit. You fail to open the door and get killed by the demon that trapped you down there.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You keep walking and ignore the noise. You keep hearing it as you walk. Do you go keep walking or go look?";
                    spaceLabel.Text = "Keep walking";
                    mLabel.Text = "Go look";
                    break;
                case 20:
                    outputLabel.Text = "When you go to look the growling gets louder and a black bear attacks you. You get eaten.";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "As you keep walking you hear something get closer to you in the woods.  You start to run and fall into a large body of water and drown";
                    spaceLabel.Text = "Continue";
                    mLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "Well, you either died or lived whatever. Good job. Do you want to do this thing again or want me to close this?";
                    spaceLabel.Text = "i waNNA PLAY AGAIN";
                    mLabel.Text = "peace out imma leave";
                    
                    break;
                    
            }



            ////Demon
            //g.FillEllipse(demonBrush, 300, 300, 18, 18);
            //g.FillEllipse(demoneyesBrush, 304, 303, 4, 4);
            //g.FillEllipse(demoneyesBrush, 310, 303, 4, 4);

            //g.DrawLine(drawPen, 302, 315, 310, 340);
            //g.DrawLine(drawPen, 317, 315, 310, 340);
            Refresh();

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void finalProject_Paint(object sender, PaintEventArgs e)
        {
            if (scene == 1)
            {
                //path
                e.Graphics.FillRectangle(redpathBrush, 0, 375, 200, 15);
                //Forest
                e.Graphics.FillRectangle(treebrush, 330, 335, 20, 80);
                e.Graphics.FillEllipse(uppertree, 315, 300, 50, 50);
                e.Graphics.FillRectangle(treebrush, 390, 345, 20, 80);
                e.Graphics.FillEllipse(uppertree, 375, 300, 50, 50);
                e.Graphics.FillRectangle(treebrush, 450, 345, 20, 80);
                e.Graphics.FillEllipse(uppertree, 435, 300, 50, 50);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            }
            else if (scene == 2)
            {
                //water
                e.Graphics.FillRectangle(waterBrush, 0, 380, 60, 10);
                e.Graphics.FillRectangle(waterBrush, 43, 375, 7, 8);
                e.Graphics.FillRectangle(waterBrush, 58, 382, 7, 7);
                e.Graphics.FillRectangle(waterBrush, 64, 386, 7, 7);
                e.Graphics.DrawLine(WaterPen, 40, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 50, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 60, 380, 79, 390);
                e.Graphics.DrawLine(WaterPen, 60, 390, 80, 390);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
                //Sound
                walking.Play();
            }
            else if (scene == 3)
            {
                //water
                e.Graphics.FillRectangle(waterBrush, 0, 380, 60, 10);
                e.Graphics.FillRectangle(waterBrush, 43, 375, 7, 8);
                e.Graphics.FillRectangle(waterBrush, 58, 382, 7, 7);
                e.Graphics.FillRectangle(waterBrush, 64, 386, 7, 7);
                e.Graphics.DrawLine(WaterPen, 40, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 50, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 60, 380, 79, 390);
                e.Graphics.DrawLine(WaterPen, 60, 390, 80, 390);
                //You
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
                //sound
                walking.Play();
            }
            else if (scene == 4)
            {
                //You
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            }
            else if (scene == 5)
            {
                //River
                e.Graphics.FillRectangle(waterBrush, 0, 380, 60, 10);
                e.Graphics.FillRectangle(waterBrush, 43, 375, 7, 8);
                e.Graphics.FillRectangle(waterBrush, 58, 382, 7, 7);
                e.Graphics.FillRectangle(waterBrush, 64, 386, 7, 7);
                e.Graphics.DrawLine(WaterPen, 40, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 50, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 60, 380, 79, 390);
                e.Graphics.DrawLine(WaterPen, 60, 390, 80, 390);
                //fire
                e.Graphics.FillEllipse(boomBrush1, 250 - pixels / 2, 400 - pixels / 2, 45 + pixels, 45 + pixels);
                e.Graphics.FillEllipse(boomBrush2, 259 - pixels / 2, 410 - pixels / 2, 30 + pixels, 30 + pixels);
                e.Graphics.FillEllipse(boomBrush3, 266 - pixels / 2, 420 - pixels / 2, 15 + pixels, 15 + pixels);
                //You
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);

                Thread.Sleep(10);

                pixels += 5;
            }
            else if (scene == 6)
            {
                //You
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
                walking.Play();
            }
            else if (scene == 7)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            }
            else if (scene == 8)
            {
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);

            }
            else if (scene == 9)
            {
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                // Stairs 
                e.Graphics.FillRectangle(stairBrush, 304, 410, 10, 15);
                e.Graphics.FillRectangle(stairBrush, 314, 395, 10, 30);
                e.Graphics.FillRectangle(stairBrush, 324, 380, 34, 45);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            }
            else if (scene == 10)
            {
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                // Stairs 
                SolidBrush stairBrush = new SolidBrush(Color.Black);
                e.Graphics.FillRectangle(stairBrush, 304, 410, 10, 15);
                e.Graphics.FillRectangle(stairBrush, 314, 395, 10, 30);
                e.Graphics.FillRectangle(stairBrush, 324, 380, 34, 45);
                //light bulb
                g.DrawLine(drawPen, 300, 300, 300, 330);
                g.FillEllipse(bulbBrush, 296, 329, 7, 7);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 380, yyou, widthyou, heightyou);
                //sound
                walking.Play();
                creak.Play();

            }
            else if (scene == 11)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 380, yyou, widthyou, heightyou);
                //sound
                walking.Play();
            }
            else if (scene == 12)
            {
                //forest
                e.Graphics.FillRectangle(treebrush, 330, 335, 20, 80);
                e.Graphics.FillEllipse(uppertree, 315, 300, 50, 50);
                e.Graphics.FillRectangle(treebrush, 390, 345, 20, 80);
                e.Graphics.FillEllipse(uppertree, 375, 300, 50, 50);
                e.Graphics.FillRectangle(treebrush, 450, 345, 20, 80);
                e.Graphics.FillEllipse(uppertree, 435, 300, 50, 50);
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 380, yyou, widthyou, heightyou);
                //sound
                walking.Play();
            }
            else if (scene == 13)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            }
            else if (scene == 14)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
                //SOUND
                tearing.Play();
            }
            else if (scene == 16)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 300, yyou, widthyou, heightyou);
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                // Stairs 
                SolidBrush stairBrush = new SolidBrush(Color.Black);
                e.Graphics.FillRectangle(stairBrush, 304, 410, 10, 15);
                e.Graphics.FillRectangle(stairBrush, 314, 395, 10, 30);
                e.Graphics.FillRectangle(stairBrush, 324, 380, 34, 45);
                //light bulb
                g.DrawLine(drawPen, 300, 300, 300, 330);
                g.FillEllipse(bulbBrush, 296, 329, 7, 7);
                //sound
                slam.Play();
            }
            else if (scene == 17)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 300, yyou, widthyou, heightyou);
                //sound
                growl.Play();
                tearing.Play();
            }
            else if (scene == 18)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 300, yyou, widthyou, heightyou);
                //house
                e.Graphics.FillRectangle(houseBrush, 285, 325, 73, 100);
                e.Graphics.DrawLine(housePen, 275, 345, 325, 305);
                e.Graphics.DrawLine(housePen, 367, 345, 310, 305);
                // Stairs 
                SolidBrush stairBrush = new SolidBrush(Color.Black);
                e.Graphics.FillRectangle(stairBrush, 304, 410, 10, 15);
                e.Graphics.FillRectangle(stairBrush, 314, 395, 10, 30);
                e.Graphics.FillRectangle(stairBrush, 324, 380, 34, 45);
                //Demon
                g.FillEllipse(demonBrush, 300, 300, 18, 18);
                g.FillEllipse(demoneyesBrush, 304, 303, 4, 4);
                g.FillEllipse(demoneyesBrush, 310, 303, 4, 4);
                g.DrawLine(drawPen, 302, 315, 310, 340);
                g.DrawLine(drawPen, 317, 315, 310, 340);

            }
            else if (scene == 19)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 300, yyou, widthyou, heightyou);
                //sound 
                walking.Play();
            }
            else if (scene == 20)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 300, yyou, widthyou, heightyou);
                //SOUND 
                growl.Play();
                tearing.Play();
            }
            else if (scene == 21)
            {
                //you
                e.Graphics.DrawImage(Properties.Resources.Man, 100, yyou, widthyou, heightyou);

                //River
                e.Graphics.FillRectangle(waterBrush, 0, 380, 60, 10);
                e.Graphics.FillRectangle(waterBrush, 43, 375, 7, 8);
                e.Graphics.FillRectangle(waterBrush, 58, 382, 7, 7);
                e.Graphics.FillRectangle(waterBrush, 64, 386, 7, 7);
                e.Graphics.DrawLine(WaterPen, 40, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 50, 380, 45, 370);
                e.Graphics.DrawLine(WaterPen, 60, 380, 79, 390);
                e.Graphics.DrawLine(WaterPen, 60, 390, 80, 390);

            }
        }
    }
}
