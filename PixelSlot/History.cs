using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelSlot
{
    public partial class History : Form
    {
        public List<string> history = new List<string>();
        public History(List<string> history)
        {
            InitializeComponent();
            if (history.Any())
            {
                this.HLabel.Text = String.Join(Environment.NewLine, history);
            }
            else
            {
                this.HLabel.Text = "Write your HISTORY first.";
            }
        }

    }
}
