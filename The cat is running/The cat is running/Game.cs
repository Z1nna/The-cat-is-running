using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_cat_is_running
{
    public partial class Main : Form
    {
        private Point pos;
        private bool dragging;
        private bool Lose = false;
        private int CountFishCoin = 0;
        private int DogSpeed = 4;
        private int FishCoinSpeed = 8;
        private int BgSpeed = 3;
        private int CarSpeed = 25;
        private Random RandomDogX = new Random();
        private Random RandomDogY = new Random();
        private Random RandomFishCoinX = new Random();
        private Random RandomFishCoinY = new Random();

        public Main()
        {
            InitializeComponent();
            ClickUpDown();
            TimerStop();
            StartVisible();
            KeyPreview = true;
        }

        private void StartVisible()
        {
            ButtonStart.Visible = true;
            LabelLose.Visible = false;
            ButtonRestart.Visible = false;
            LabelWin.Visible = false;
        }

        private void ClickUpDown()
        {
            Background1.MouseDown += MouseClickDown;
            Background1.MouseUp += MouseClickUp;
            Background1.MouseMove += MouseClickMove;
            Background2.MouseDown += MouseClickDown;
            Background2.MouseUp += MouseClickUp;
            Background2.MouseMove += MouseClickMove;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point NewPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(NewPoint.X - pos.X, NewPoint.Y - pos.Y + Background1.Top);
            }
        }
        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }


        private void TimerBackground_Tick(object sender, EventArgs e)
        {
            
            Background1.Top += BgSpeed;
            Background2.Top += BgSpeed;
            if (Background1.Top >= 1024)
            {
                Background1.Top = 0;
                Background2.Top = -1024;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (Lose)
                return;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Cat.Left > 224)
                Cat.Left -= CarSpeed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Cat.Right < 1230)
                Cat.Left += CarSpeed;
        }

        private void TimerDog_Tick(object sender, EventArgs e)
        {
            Dog1.Top += DogSpeed;
            Dog2.Top += DogSpeed;
            Dog3.Top += DogSpeed;
            Dog4.Top += DogSpeed;
            if (Dog1.Top >= 1024)
            {
                Dog1.Left = RandomDogX.Next(224, 317);
                Dog1.Top = RandomDogY.Next(-800, -100);
            }
            if (Dog2.Top >= 1024)
            {
                Dog2.Left = RandomDogX.Next(443, 536);
                Dog2.Top = RandomDogY.Next(-800, -100);
            }
            if (Dog3.Top >= 1024)
            {
                Dog3.Left = RandomDogX.Next(662, 755);
                Dog3.Top = RandomDogY.Next(-800, -100);
            }
            if (Dog4.Top >= 1024)
            {
                Dog4.Left = RandomDogX.Next(881, 1100);
                Dog4.Top = RandomDogY.Next(-800, -100);
            }
        }

        private void TimerСonflict_Tick(object sender, EventArgs e)
        {
            if (Cat.Bounds.IntersectsWith(Dog1.Bounds) || Cat.Bounds.IntersectsWith(Dog2.Bounds)
            || Cat.Bounds.IntersectsWith(Dog3.Bounds) || Cat.Bounds.IntersectsWith(Dog4.Bounds))
            {
                TimerStop();
                LoseVisible();
                Lose = true;
            }
        }

        private void LoseVisible()
        {
            ButtonStart.Visible = false;
            LabelLose.Visible = true;
            ButtonRestart.Visible = true;
            LabelWin.Visible = false;
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            TimerStart();
            DogPosition();
            Lose = false;
            CountFishCoin = 0;
            CoinPosition();
            StartSpeed();
            RestartVisible();
        }

        private void RestartVisible()
        {
            LabelWin.Visible = false;
            LabelLose.Visible = false;
            ButtonRestart.Visible = false;
            ButtonStart.Visible = false;
            LableCountFishCoin.Text = "Coin: 0";
        }

        private void TimerStart()
        {
            TimerСonflict.Enabled = true;
            TimerDog.Enabled = true;
            TimerBackground.Enabled = true;
            TimerFishCoin.Enabled = true;
            TimerAcceleration.Enabled = true;
            TimerCountFishCoin.Enabled = true;
        }

        private void TimerFishCoin_Tick(object sender, EventArgs e)
        {
            FishCoin.Top += FishCoinSpeed;
            if (FishCoin.Top > 1024)
            {
                CoinPosition();

            }
        }

        private void TimerCountFishCoin_Tick(object sender, EventArgs e)
        {
            if (Cat.Bounds.IntersectsWith(FishCoin.Bounds))
            {
                CountFishCoin += 1;
                LableCountFishCoin.Text = "Coin: " + CountFishCoin.ToString();
                CoinPosition();
            }
        }

        private void Acceleration_Tick(object sender, EventArgs e)
        {
            BgSpeed += 2;
            DogSpeed += 2;
            FishCoinSpeed += 2;
            CarSpeed += 2;
            if (DogSpeed == 16)
            {
                TimerStop();
                WinVisible();
            }
        }

        private void WinVisible()
        {
            LabelWin.Visible = true;
            LabelLose.Visible = false;
            ButtonRestart.Visible = true;
            ButtonStart.Visible = false;
        }

        private void TimerStop()
        {
            TimerCountFishCoin.Enabled = false;
            TimerСonflict.Enabled = false;
            TimerDog.Enabled = false;
            TimerFishCoin.Enabled = false;
            TimerBackground.Enabled = false;
            TimerAcceleration.Enabled = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            DogPosition();
            StartSpeed();
            CoinPosition();
            Lose = false;
            CountFishCoin = 0;
            RestartVisible();
            TimerStart();
        }

        private void CoinPosition()
        {
            FishCoin.Left = RandomFishCoinX.Next(250, 1050);
            FishCoin.Top = RandomFishCoinY.Next(-600, -100);
        }

        private void StartSpeed()
        {
        DogSpeed = 4;
        FishCoinSpeed = 8;
        BgSpeed = 3;
        CarSpeed = 25;
    }

        private void DogPosition()
        {
            Dog1.Left = RandomDogX.Next(224, 443);
            Dog1.Top = RandomDogY.Next(-800, -100);
            Dog2.Left = RandomDogX.Next(443, 662);
            Dog2.Top = RandomDogY.Next(-800, -100);
            Dog3.Left = RandomDogX.Next(662, 881);
            Dog3.Top = RandomDogY.Next(-800, -100);
            Dog4.Left = RandomDogX.Next(881, 1100);
            Dog4.Top = RandomDogY.Next(-800, -100);
        }

        private void TimerVelocity_Tick(object sender, EventArgs e)
        {
            LabelVelocity.Text = "Velocity: " + DogSpeed.ToString();
        }
    }
}
