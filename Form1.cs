using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
          InitializeComponent();
            player.SoundLocation = "duncan-laurence-arcade-evrovidenie-2019-niderlandy- (online-audio-converter.com).wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
