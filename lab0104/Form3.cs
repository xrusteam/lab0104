﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace lab0104
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Program.isGamePlayed = true;
            SoundPlayer song = new SoundPlayer(Environment.CurrentDirectory.Replace(@"bin\Debug", "") + "Sound_14988.wav");
            song.Play();

        }
    }
}
