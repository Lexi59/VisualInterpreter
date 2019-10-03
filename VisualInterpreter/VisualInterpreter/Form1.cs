using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VisualInterpreter
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> locationDict;
        private List<int> dat;
        private int baseIndex;
        public Form1()
        {
            InitializeComponent();
            locationDict = new Dictionary<string, int>();
            dat = new List<int>(1000);
            for(int i = 0; i< 1000; i++)
            {
                dat.Add(0);
            }
            locationDict.Add("program", 0);
            locationDict.Add("input", 0);
            for (int i = 0; i < programListBox.Columns.Count; i++)
            {
                programListBox.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            fileTextBox.Text = openFileDialog.FileName;
            try
            {
                string contents = File.ReadAllText(openFileDialog.FileName);
                fillProgram(contents);
            }
            catch
            {
                outputListBox.Items.Add("Something went wrong");
            }
        }
        private void fillProgram(string contents)
        {
            int section = 0;
            int lineNum = 0;
            List<string> prog = new List<string>();
            prog = contents.Split('\n').ToList<string>();
            for (int i = 0; i < prog.Count; i++)
            {
                if (prog[i].Substring(0, 2) == "+9")
                {
                    lineNum = 0;
                    section += 1;
                }
                else
                {
                    ListViewItem line = new ListViewItem(lineNum.ToString());

                    if (section == 0)
                    {
                        line.SubItems.Add((Convert.ToInt32(prog[i].Substring(2, 9))).ToString());
                        line.SubItems.Add(" ");
                        dataCardListBox.Items.Add(line);
                    }
                    else if (section == 1)
                    {
                        line.SubItems.Add(prog[i].Substring(0, 2));
                        line.SubItems.Add(prog[i].Substring(2, 3));
                        line.SubItems.Add(prog[i].Substring(5, 3));
                        line.SubItems.Add(prog[i].Substring(8, 3));
                        programListBox.Items.Add(line);
                        translateLine(prog[i],i-dataCardListBox.Items.Count-1);
                    }
                    else
                    {
                        line.SubItems.Add((Convert.ToInt32(prog[i].Substring(2, 9))).ToString());
                        inputCardListBox.Items.Add(line);
                    }
                    lineNum++;
                }
            }
        }
        private void translateLine(string line, int lineNum)
        {
            var op = line.Substring(0, 2);
            var opn1 = line.Substring(2, 3);
            var opn2 = line.Substring(5, 3);
            var opn3 = line.Substring(8, 3);
            var o1 = Convert.ToInt32(opn1);
            var o2 = Convert.ToInt32(opn2);
            var o3 = Convert.ToInt32(opn3);
            string str;
            ListViewItem itm = new ListViewItem(lineNum.ToString());
            switch (op)
            {
                case "+0":
                    str = opn3 + " = " + opn1 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+1":
                    str = opn3 + " = " + opn1 + " + " + opn2 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+2":
                    str = opn3 + " = " + opn1 + " * " + opn2 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+3":
                    str = opn3 + " = " + "pow(" + opn1 + ",2);";
                    itm.SubItems.Add(str);
                    break;
                case "+4":
                    str = "if(" + opn1 + " == " + opn2 + ") goto " + opn3 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+5":
                    str = "if(" + opn1 + " >= " + opn2 + ") goto " + opn3 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+6":
                    str = opn3 + " = " + opn1 + "[" + opn2 + "];";
                    itm.SubItems.Add(str);
                    break;
                case "+7":
                    str = opn1 + "++; " + "if(" + opn1 + " < " + opn2 + ") goto " + opn3 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "+8":
                    str = "scanf(\"%d\", &" + opn3 + ");";
                    itm.SubItems.Add(str);
                    break;
                case "+9":
                    break;
                case "-0":
                    break;
                case "-1":
                    str = opn3 + " = " + opn1 + " - " + opn2 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "-2":
                    str = opn3 + " = " + opn1 + " // " + opn2 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "-3":
                    break;
                case "-4":
                    str = "if(" + opn1 + " != " + opn2 + ") goto " + opn3 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "-5":
                    str = "if(" + opn1 + " < " + opn2 + ") goto " + opn3 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "-6":
                    str = opn2 + "[" + opn3 + "] = " + opn1 + ";";
                    itm.SubItems.Add(str);
                    break;
                case "-7":
                    break;
                case "-8":
                    str = "printf(\"%d\\n\", &" + opn3 + ");";
                    itm.SubItems.Add(str);
                    break;
                case "-9":
                    break;
                default:
                    outputListBox.Items.Add("Something went wrong");
                    break;
            }
            translationListBox.Items.Add(itm);
            translationListBox.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            translationListBox.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void VarNameButton_Click(object sender, EventArgs e)
        {
            while (numberBox.Text.Length < 3)
            {
                numberBox.Text = "0" + numberBox.Text;
            }
            dataCardListBox.Items[Convert.ToInt32(numberBox.Text)].SubItems[2].Text = variableNameBox.Text;
            for (int i = 0; i < translationListBox.Items.Count; i++)
            {
                if (!translationListBox.Items[i].Text.Contains("goto") || translationListBox.Items[i].Text.IndexOf("goto") > translationListBox.Items[i].Text.IndexOf(numberBox.Text))
                    translationListBox.Items[i].Text = translationListBox.Items[i].Text.Replace(numberBox.Text, variableNameBox.Text);
            }
            numberBox.Text = null;
            variableNameBox.Text = null;
        }
        private int runLine(int pos)
        {
            for(int i = 0; i < programListBox.Items.Count; i++)
            {
                programListBox.Items[i].BackColor = Color.White;
            }
            for(int i = 0; i < dataCardListBox.Items.Count; i++)
            {
                dataCardListBox.Items[i].ForeColor = Color.Black;
                dat[i] = Convert.ToInt32(dataCardListBox.Items[i].SubItems[1].Text);
            }
            for(int i = 0; i < inputCardListBox.Items.Count; i++)
            {
                inputCardListBox.Items[i].ForeColor = Color.Black;
            }
            for(int i = 0; i < codeBlockList.Items.Count; i++)
            {
                codeBlockList.Items[i].ForeColor = Color.Black;
            }
            programListBox.Items[pos].BackColor = Color.LightBlue;
            var op = programListBox.Items[pos].SubItems[1].Text;
            var opn1 = programListBox.Items[pos].SubItems[2].Text;
            var opn2 = programListBox.Items[pos].SubItems[3].Text;
            var opn3 = programListBox.Items[pos].SubItems[4].Text;
            var o1 = Convert.ToInt32(opn1);
            var o2 = Convert.ToInt32(opn2);
            var o3 = Convert.ToInt32(opn3);
            switch (op)
            {
                case "+0":
                    dat[o3] = dat[o1];
                    return pos + 1;
                case "+1":
                    dat[o3] = dat[o1] + dat[o2];
                    return pos + 1;
                case "+2":
                    dat[o3] = dat[o1] * dat[o2];
                    return pos + 1;
                case "+3":
                    dat[o3] = (int)Math.Pow(dat[o1], 2);
                    return pos + 1;
                case "+4":
                    if (dat[o1] == dat[o2]) { return o3; }
                    return pos + 1;
                case "+5":
                    if (dat[o1] >= dat[o2]) { return o3; }
                    return pos + 1;
                case "+6":
                    dat[o3] = dat[o1 + dat[o2]];
                    return pos + 1;
                case "+7":
                    dat[o1] = dat[o1] + 1;
                    if (dat[o1] < dat[o2]) { return o3; }
                    return pos + 1;
                case "+8":
                    dat[o3] = Convert.ToInt32(inputCardListBox.Items[locationDict["input"]].SubItems[1].Text);
                    inputCardListBox.Items[locationDict["input"]].ForeColor = Color.Red;
                    locationDict["input"]++;
                    return pos + 1;
                case "+9":
                    return pos + 1;
                case "-0":
                    return pos + 1;
                case "-1":
                    dat[o3] = dat[o1] - dat[o2];
                    return pos + 1;
                case "-2":
                    dat[o3] = dat[o1] / dat[o2];
                    return pos + 1;
                case "-3":
                    return pos + 1;
                case "-4":
                    if (dat[o1] != dat[o2]) { return o3; }
                    return pos + 1;
                case "-5":
                    if (dat[o1] < dat[o2]) { return o3; }
                    return pos + 1;
                case "-6":
                    dat[o2 + dat[o3]] = dat[o1];
                    return pos + 1;
                case "-7":
                    return pos + 1;
                case "-8":
                    outputListBox.Items.Add(dat[o1].ToString());
                    return pos + 1;
                case "-9":
                    return pos + 1;
                default:
                    outputListBox.Items.Add("Something went wrong");
                    return pos + 1;
            }
        }

        private void ProgramListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 110)
            {
                locationDict["program"] = runLine(locationDict["program"]);
                if (locationDict["program"] >= programListBox.Items.Count)
                {
                    for (int i = 0; i < programListBox.Items.Count; i++)
                    {
                        programListBox.Items[i].BackColor = Color.White;
                    }
                    outputListBox.Items.Add("----Program finished----");
                    locationDict["program"] = 0;
                    locationDict["input"] = 0;
                }
                for (int i = 0; i < dataCardListBox.Items.Count; i++)
                {
                    if(dataCardListBox.Items[i].SubItems[1].Text != dat[i].ToString())
                    {
                        dataCardListBox.Items[i].ForeColor = Color.Red;
                    }
                    dataCardListBox.Items[i].SubItems[1].Text = dat[i].ToString();
                }
                for (int i = 0; i < codeBlockList.Items.Count; i++)
                {
                    if (codeBlockList.Items[i].SubItems[1].Text != dat[baseIndex + i].ToString())
                    {
                        codeBlockList.Items[i].ForeColor = Color.Red;
                    }
                    codeBlockList.Items[i].SubItems[1].Text = dat[baseIndex + i].ToString();
                }
                outputListBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                e.Handled = true;
            }
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            codeBlockList.Items.Clear();
            int len;
            try
            {
                baseIndex = Convert.ToInt32(baseArrayBox.Text);
                len = Convert.ToInt32(lenBox.Text);
            }
            catch
            {
                outputListBox.Items.Add("Something went wrong");
                return;
            }
            if (baseIndex >= 1000 || len <= 0)
            {
                outputListBox.Items.Add("Something went wrong");
                return;
            }
            for (int i = 0; i < len; i++)
            {
                var itm = new ListViewItem(i.ToString());
                itm.SubItems.Add(dat[baseIndex + i].ToString());
                codeBlockList.Items.Add(itm);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tHi! Welcome to the pseudocode debugger.\n\t" +
                "Start off by clicking the load button and finding your code file.\n\t" +
                "Once it's loaded you'll be able to see all the features of the debugger." +
                " Including, a rough translation into c code to make it more readable.\n\tIf you wish to rename the number variables, " +
                "simply enter the number of the variable you wish to change in the small box above the data cards, " +
                "and enter the name you wish to call it into the larger box and click 'save'.\n\t" +
                " To step through your code, click anywhere in the 'Program' box and click 'n' for 'next'," +
                " this will run one line of your code, highlight the line it ran, and show you which data values were changed.\n\t" +
                "If you have any variables you want to watch that aren't included in the declarative part of your program, " +
                "simply answer the questions in the lower middle part of the screen and click 'watch'. (Hint: this is great for watching arrays)");
        }
    }
}
