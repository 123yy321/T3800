﻿using System.Diagnostics;
using Sunny.UI;

namespace T3800
{
    public partial class FLabel : UIPage
    {
        public FLabel()
        {
            InitializeComponent();
        }

        private void uiLinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(uiLinkLabel1.Text);
        }
    }
}
