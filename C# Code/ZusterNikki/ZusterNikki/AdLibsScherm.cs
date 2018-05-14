﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZusterNikki
{
    public partial class AdLibsScherm : Form
    {
        //fields
        AdLibs adLibs;
        Dictionary<int, TextBox> textBoxDict;
        Dictionary<int, Label> labelDict;

        public AdLibsScherm()
        {
            InitializeComponent();
            adLibs = new AdLibs();
            LBLStoryTitle.Text = adLibs.Title;

            textBoxDict = new Dictionary<int, TextBox>();
            textBoxDict.Add(1, TBAdVar1);
            textBoxDict.Add(2, TBAdVar2);
            textBoxDict.Add(3, TBAdVar3);
            textBoxDict.Add(4, TBAdVar4);
            textBoxDict.Add(5, TBAdVar5);
            textBoxDict.Add(6, TBAdVar6);
            textBoxDict.Add(7, TBAdVar7);
            textBoxDict.Add(8, TBAdVar8);
            textBoxDict.Add(9, TBAdVar9);
            textBoxDict.Add(10, TBAdVar10);

            labelDict = new Dictionary<int, Label>();
            labelDict.Add(1, LBLAdVar1);
            labelDict.Add(2, LBLAdVar2);
            labelDict.Add(3, LBLAdVar3);
            labelDict.Add(4, LBLAdVar4);
            labelDict.Add(5, LBLAdVar5);
            labelDict.Add(6, LBLAdVar6);
            labelDict.Add(7, LBLAdVar7);
            labelDict.Add(8, LBLAdVar8);
            labelDict.Add(9, LBLAdVar9);
            labelDict.Add(10, LBLAdVar10);

            int i = 1;
            foreach(var word in adLibs.VarWords)
            {
                labelDict[i].Visible = true;
                labelDict[i].Text = word.Trim(new char[] {'[', ']'});
                textBoxDict[i].Visible = true;
                i++;
            }
        }

        private void AdLibsScherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BTNStoryReady_Click(object sender, EventArgs e)
        {
            List<String> input = new List<String>();
            foreach(KeyValuePair<int, TextBox> item in textBoxDict)
            {
                if (item.Value.Visible)
                {
                    input.Add(item.Value.Text);
                }               
            }

            adLibs.MakeStory(input);
            AdLibsResultScherm newResult = new AdLibsResultScherm(adLibs.Story, adLibs.Title);
            newResult.Show();
            this.Dispose();
        }
    }
}
