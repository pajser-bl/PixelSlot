using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PixelSlot
{
    public partial class MainForm : Form
    {
        public Boolean musicOFF = false;
        public System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Properties.Resources.music_loop);
        public System.Media.SoundPlayer goldPlayer = new System.Media.SoundPlayer(Properties.Resources.gold);
        public System.Media.SoundPlayer alertPlayer = new System.Media.SoundPlayer(Properties.Resources.alert);
        public System.Media.SoundPlayer winPlayer = new System.Media.SoundPlayer(Properties.Resources.win);
        public Timer timer = new Timer();
        public Random random = new Random();
        public double Balance = 25;
        public double RoundBalance = 0;
        public List<string> history = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            this.BalanceLable.Text = Balance.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Form Paytable = new PayTable();
            Paytable.ShowDialog();
        }

        private void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "Open info.";
            this.InfoButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.info_button_1));
        }

        private void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
            this.InfoButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.info_button_0));
        }

        private void SpinButton_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "Try your luck,DON'T wake the SMAUG![-1]";
            this.SpinButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.spin_button_1));
        }

        private void SpinButton_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
            this.SpinButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.spin_button_0));
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "EXIT Pixel Slot ? ? ?";
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_button_1));

        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
            this.ExitButton.BackgroundImage = Properties.Resources.exit_button_0;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();
        }

        private void MusicButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (musicOFF)
            {
                MusicButton.BackgroundImage = Properties.Resources.music_on;
                musicOFF = false;
                soundPlayer.PlayLooping();
            }
            else
            {
                MusicButton.BackgroundImage = Properties.Resources.music_off;
                musicOFF = true;
                soundPlayer.Stop();
            }
        }

        private void MusicButton_MouseEnter(object sender, EventArgs e)
        {
            if (musicOFF)
            {
                this.MainLabel.Text = "Turn the music ON.";
            }
            else
            {
                this.MainLabel.Text = "Turn the music OFF.";
            }
        }

        private void MusicButton_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
        }

        private void HistoryButton_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "Gaze upon HISTORY.";
            this.HistoryButton.BackgroundImage = Properties.Resources.history_1;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 600;
            timer.Start();
        }

        private void HistoryButton_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
            this.HistoryButton.BackgroundImage = Properties.Resources.history_0;
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {

            this.HistoryButton.BackgroundImage = Properties.Resources.history_2;
        }
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Form History = new History(this.history);
            History.ShowDialog();
        }

        private void BalanceLable_MouseEnter(object sender, EventArgs e)
        {
            string text = "";
            if (this.Balance == 0)
            {
                text = "No HOPE and NO GOLD...";
            }
            else if (Balance == 1)
            {
                text = "Last glimer of HOPE...";
            }
            else if (Balance <= 5)
            {
                text = "There is still HOPE.";
            }
            else if (Balance < 10)
            {
                text = "A bit SAD looking.";
            }
            else if (Balance < 30)
            {
                text = "Do NOT call yourself rich jet.";
            }
            else if (Balance > 50)
            {
                text = "Your purse is overflowing!";
            }
            else if (Balance > 100)
            {
                text = "Are YOU a HOBBIT or a DWARF?";
            }
            this.MainLabel.Text = text;
        }

        private void BalanceLable_MouseLeave(object sender, EventArgs e)
        {
            this.MainLabel.Text = "";
        }

        private void SpinButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Scene.Image = Properties.Resources.scene_0;
            this.BackgroundImage = Properties.Resources.background_0;
            this.Scene.Visible = true;
            this.SpinButton.Enabled = false;
            this.Tile0.Visible = true;
            this.Tile1.Visible = true;
            this.Balance -= 1;
            this.BalanceLable.Text = Balance.ToString();
            this.MainLabel.Text = "Choose your steps carfuly.";
        }

        private void Tile1_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "First step is the hardest. [1.92]";
        }

        private void Tile1_Click(object sender, EventArgs e)
        {
            this.Tile0.Visible = false;
            this.Tile1.Visible = false;
            if (this.random.Next(1, 100) > 50)
            {
                this.goldPlayer.Play();
                this.Tile10.Visible = true;
                this.Tile11.Visible = true;
                this.SaveButton.Visible = true;
                this.RoundBalance = 1.92;
                this.MainLabel.Text = "Good job!. Will you continue ?!";
            }
            else
            {
                this.history.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+" Demise at first step.["+this.Balance.ToString()+"]");
                this.alertPlayer.Play();
                this.RoundBalance = 0;
                DragonAwake();
            }
        }



        private void Tile10_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "RICHES await the BRAVE! [3.84]";
        }


        private void Tile10_Click(object sender, EventArgs e)
        {
            this.Tile10.Visible = false;
            this.Tile11.Visible = false;
            if (this.random.Next(1, 100) > 50)
            {
                this.goldPlayer.Play();
                this.MainLabel.Text = "Splendid!. Care to continue ?!";
                this.RoundBalance = 3.84;
                this.Tile110.Visible = true;
                this.Tile111.Visible = true;
            }
            else
            {
                this.history.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Demise at second step.[" + this.Balance.ToString() + "]");
                this.alertPlayer.Play();
                this.RoundBalance = 0;
                DragonAwake();
            }
            
        }

        private void Tile110_MouseEnter(object sender, EventArgs e)
        {
            this.MainLabel.Text = "So CLOSE, so FAR. [7.68]";
        }

   

        private void Tile110_Click(object sender, EventArgs e)
        {
            this.SaveButton.Visible = false;
            this.Tile110.Visible = false;
            this.Tile111.Visible = false;
            if (this.random.Next(1, 100) > 50)
            {
                this.winPlayer.Play();
                this.MainLabel.Text = "Truly a BURGLAR of legend.";
                this.RoundBalance = 7.68;
                this.Balance += RoundBalance;
                this.SaveButton.Visible = true;
            }
            else
            {
                this.history.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Demise at the end.[" + this.Balance.ToString() + "]");
                this.alertPlayer.Play();
                this.RoundBalance = 0;
                this.BackgroundImage = Properties.Resources.background_1;
                this.Scene.Image = Properties.Resources.scene_1;
                this.SaveButton.Visible = true;
            }
            this.BalanceLable.Text = Balance.ToString();
        }

        public void DragonAwake()
        {
            this.MainLabel.Text = "FLY YOU FOOL!!!";
            this.BackgroundImage = Properties.Resources.background_1;
            this.Scene.Image = Properties.Resources.scene_1;
            this.SaveButton.Visible = true;
        }
        public void DefaultBackground() 
        {
            this.BackgroundImage = Properties.Resources.background;
            this.Scene.Visible = false;
            this.Scene.Image = Properties.Resources.scene_0;
            this.SaveButton.Visible = false;
            this.SpinButton.Enabled = true;
            this.MainLabel.Text = "";
        }

        private void SaveButton_MouseEnter(object sender, EventArgs e)
        {
            if (this.RoundBalance == 7.68) {
                this.MainLabel.Text = "More like SMAUGhingstock[+" + this.RoundBalance.ToString() + "]";
                this.history.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " All the loot.[" + this.Balance.ToString() + "]");

            }
            else if (this.RoundBalance > 0)
            {
                this.history.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Run with "+this.RoundBalance.ToString()+" coins.[" + this.Balance.ToString() + "]");
                this.MainLabel.Text = "Take your riches and RUN?[+"+this.RoundBalance.ToString()+"]";
            }
            else
            {
                this.MainLabel.Text = "RUN for your LIFE!!!";
            }
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            if (this.RoundBalance > 0)
            {
                this.MainLabel.Text = "";
            }
            else
            {
                this.MainLabel.Text = "FLY YOU FOOL!!!";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Tile0.Visible = false;
            this.Tile1.Visible = false;
            this.Tile10.Visible = false;
            this.Tile11.Visible = false;
            this.Tile110.Visible = false;
            this.Tile111.Visible = false;
            this.Balance += RoundBalance;
            this.BalanceLable.Text = Balance.ToString();
            DefaultBackground();
        }

        
    }

}
