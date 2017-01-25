using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMB
{
    public partial class SnakeScreen : UserControl
    {
        //initial starting values for you and the snake
        int xyou = 10;
        int yyou = 200;
        int speedyou = 5;
        int widthyou = 30;
        int heightyou = 60;

        int xsnake = 200;
        int ysnake = 200;
        int speedsnake = 2;
        int widthsnake = 60;
        int heightsnake = 90;
        string snakeDirection = "up";

        int xdoor = 400;
        int ydoor = 50;
        int widthDoor = 10;
        int heightDoor = 75;

        Rectangle doorRec, playerRec, snakeRec;


        //determines whether a key is being pressed or not
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        Boolean gameWin = false;

        // Graphic objects
        SolidBrush drawBrush = new SolidBrush(Color.Black);



        private void SnakeScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void SnakeScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        public SnakeScreen()
        {
            InitializeComponent();

            doorRec = new Rectangle(xdoor, ydoor, widthDoor, heightDoor);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region move character based on key presses

            if (leftArrowDown == true)
            {
                xyou = xyou - speedyou;
            }

            if (downArrowDown == true)
            {
                yyou = yyou + speedyou;
            }

            if (rightArrowDown == true)
            {
                xyou = xyou + speedyou;
            }

            if (upArrowDown == true)
            {
                yyou = yyou - speedyou;
            }


            #endregion


            //refresh the screen, which causes the Form1_Paint method to run
            // Refresh();

            #region move snake

            if (snakeDirection == "down")
            {
                ysnake += 5;
            }
            else
            {
                ysnake -= 5;
            }

            if (ysnake < 15)
            {
                snakeDirection = "down";
            }
            if (ysnake > 260)
            {
                snakeDirection = "up";
            }
            #endregion

            #region check collision

            playerRec = new Rectangle(xyou, yyou, widthyou, heightyou);
            snakeRec = new Rectangle(xsnake, ysnake, widthsnake, heightsnake);

            if (playerRec.IntersectsWith(doorRec))
            {
                gameTimer.Stop();
               // outputLabel.Text = " You made it past the snake";
                gameWin = true;

            }

            if (playerRec.IntersectsWith(snakeRec))
            {
                gameTimer.Stop();
               // outputLabel.Text = "You got bit by the Snake and died";
            }


            #endregion

            Refresh();
        }

        private void SnakeScreen_Paint(object sender, PaintEventArgs e)
        {
            //SnakeScreen
            //draw rectangle to screen
            e.Graphics.DrawImage(Properties.Resources.Man, xyou, yyou, widthyou, heightyou);
            e.Graphics.DrawImage(Properties.Resources.snakerg, xsnake, ysnake, widthsnake, heightsnake);
            //e.Graphics.DrawRectangle(new Pen(Color.Red), xyou, yyou, widthyou, heightyou);
            //e.Graphics.DrawRectangle(new Pen(Color.Red), xsnake, ysnake, widthsnake, heightsnake);
            e.Graphics.FillRectangle(drawBrush, xdoor, ydoor, widthDoor, heightDoor);

        }
    }
}
