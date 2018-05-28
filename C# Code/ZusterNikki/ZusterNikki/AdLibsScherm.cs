using System;
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

            textBoxDict = new Dictionary<int, TextBox>
            {
                { 1, TBAdVar1 },
                { 2, TBAdVar2 },
                { 3, TBAdVar3 },
                { 4, TBAdVar4 },
                { 5, TBAdVar5 },
                { 6, TBAdVar6 },
                { 7, TBAdVar7 },
                { 8, TBAdVar8 },
                { 9, TBAdVar9 },
                { 10, TBAdVar10 }
            };

            labelDict = new Dictionary<int, Label>
            {
                { 1, LBLAdVar1 },
                { 2, LBLAdVar2 },
                { 3, LBLAdVar3 },
                { 4, LBLAdVar4 },
                { 5, LBLAdVar5 },
                { 6, LBLAdVar6 },
                { 7, LBLAdVar7 },
                { 8, LBLAdVar8 },
                { 9, LBLAdVar9 },
                { 10, LBLAdVar10 }
            };

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

        private void BTNMainMenu_Click(object sender, EventArgs e)
        {
            HoofdMenu newMain = new HoofdMenu();
            newMain.Show();
            this.Dispose();
        }
    }
}
