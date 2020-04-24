using System.Windows.Forms;

namespace PixelSlot
{
    public partial class LandingForm : Form
    {
        MainForm mainForm = new MainForm();
        
        public LandingForm()
        {
            InitializeComponent();
            this.mainForm.soundPlayer.Play();
        }

        private void LandingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                mainForm.ShowDialog();
                this.Dispose();
            }
            if (e.KeyCode == Keys.Escape) 
            {
                Application.Exit();
            }
        }
    }
}
