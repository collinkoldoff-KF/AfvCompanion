﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AfvCompanion
{
    class AutoDeafen
    {
        public static bool run = false;
        public static void toggle(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                if (PushToDeafen.run == false && AutoVolume.run == false)
                {
                    Form1.btnDisableAll.BackColor = System.Drawing.Color.Empty;
                    
                }
                Form1.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
                Form1.btnAutoDeafenToggle.Text = "Start";
            }
            else if (run == false)
            {
                run = true;
                Form1.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnAutoDeafenToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(206)))));
                Form1.btnAutoDeafenToggle.Text = "Stop";
            }
        }
    }
}