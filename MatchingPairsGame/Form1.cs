﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", 
            "g", "g",
            "m", "m",
            ",", ",",
            "P", "P",
            "t", "t",
            "u", "u",
            "q", "q",
        };
        public Form1()
        {
            InitializeComponent();
        }

    }
}
