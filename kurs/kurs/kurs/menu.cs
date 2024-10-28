using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class menu : Form
    {
        int score;
        public menu()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, EventArgs e)
        {
            level1 lv1 = new level1();
            lv1.Show();
        }

        private void record_Click(object sender, EventArgs e)
        {
            Record rec = new Record(score);
            rec.Show();
        }
        private void info_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();

        }
        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}
