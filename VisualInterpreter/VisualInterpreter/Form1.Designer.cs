namespace VisualInterpreter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataCardListBox = new System.Windows.Forms.ListView();
            this.dataLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programListBox = new System.Windows.Forms.ListView();
            this.line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.op = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opn3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.translationListBox = new System.Windows.Forms.ListView();
            this.linenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputCardListBox = new System.Windows.Forms.ListView();
            this.inputLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variableNameBox = new System.Windows.Forms.TextBox();
            this.varNameButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.codeBlockList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.baseArrayBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lenBox = new System.Windows.Forms.TextBox();
            this.watchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(941, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Translation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input Cards";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(36, 15);
            this.fileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(208, 22);
            this.fileTextBox.TabIndex = 9;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(255, 15);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(84, 28);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dataCardListBox
            // 
            this.dataCardListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataLine,
            this.dataValue,
            this.varName});
            this.dataCardListBox.FullRowSelect = true;
            this.dataCardListBox.Location = new System.Drawing.Point(348, 84);
            this.dataCardListBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataCardListBox.Name = "dataCardListBox";
            this.dataCardListBox.Size = new System.Drawing.Size(216, 386);
            this.dataCardListBox.TabIndex = 11;
            this.dataCardListBox.UseCompatibleStateImageBehavior = false;
            this.dataCardListBox.View = System.Windows.Forms.View.Details;
            // 
            // dataLine
            // 
            this.dataLine.Text = "var";
            // 
            // dataValue
            // 
            this.dataValue.Text = "val";
            // 
            // varName
            // 
            this.varName.Text = "name";
            // 
            // programListBox
            // 
            this.programListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.line,
            this.op,
            this.opn1,
            this.opn2,
            this.opn3});
            this.programListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.programListBox.Location = new System.Drawing.Point(573, 47);
            this.programListBox.Margin = new System.Windows.Forms.Padding(4);
            this.programListBox.Name = "programListBox";
            this.programListBox.Size = new System.Drawing.Size(248, 422);
            this.programListBox.TabIndex = 12;
            this.programListBox.UseCompatibleStateImageBehavior = false;
            this.programListBox.View = System.Windows.Forms.View.Details;
            this.programListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramListBox_KeyPress);
            // 
            // line
            // 
            this.line.Text = "line";
            this.line.Width = 25;
            // 
            // op
            // 
            this.op.Text = "op";
            this.op.Width = 25;
            // 
            // opn1
            // 
            this.opn1.Text = "opn1";
            this.opn1.Width = 25;
            // 
            // opn2
            // 
            this.opn2.Text = "opn2";
            this.opn2.Width = 25;
            // 
            // opn3
            // 
            this.opn3.Text = "opn3";
            this.opn3.Width = 25;
            // 
            // translationListBox
            // 
            this.translationListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.linenum,
            this.code});
            this.translationListBox.FullRowSelect = true;
            this.translationListBox.Location = new System.Drawing.Point(831, 47);
            this.translationListBox.Margin = new System.Windows.Forms.Padding(4);
            this.translationListBox.Name = "translationListBox";
            this.translationListBox.Size = new System.Drawing.Size(339, 422);
            this.translationListBox.TabIndex = 13;
            this.translationListBox.UseCompatibleStateImageBehavior = false;
            this.translationListBox.View = System.Windows.Forms.View.Details;
            // 
            // linenum
            // 
            this.linenum.Text = "lineNum";
            // 
            // code
            // 
            this.code.Text = "c code";
            // 
            // inputCardListBox
            // 
            this.inputCardListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inputLine,
            this.inputValue});
            this.inputCardListBox.FullRowSelect = true;
            this.inputCardListBox.Location = new System.Drawing.Point(37, 306);
            this.inputCardListBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputCardListBox.Name = "inputCardListBox";
            this.inputCardListBox.Size = new System.Drawing.Size(300, 163);
            this.inputCardListBox.TabIndex = 14;
            this.inputCardListBox.UseCompatibleStateImageBehavior = false;
            this.inputCardListBox.View = System.Windows.Forms.View.Details;
            // 
            // inputLine
            // 
            this.inputLine.Text = "line";
            // 
            // inputValue
            // 
            this.inputValue.Text = "val";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output";
            // 
            // outputListBox
            // 
            this.outputListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.outputListBox.FullRowSelect = true;
            this.outputListBox.Location = new System.Drawing.Point(37, 503);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(527, 205);
            this.outputListBox.TabIndex = 16;
            this.outputListBox.UseCompatibleStateImageBehavior = false;
            this.outputListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Output";
            // 
            // variableNameBox
            // 
            this.variableNameBox.Location = new System.Drawing.Point(387, 52);
            this.variableNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.variableNameBox.Name = "variableNameBox";
            this.variableNameBox.Size = new System.Drawing.Size(93, 22);
            this.variableNameBox.TabIndex = 17;
            // 
            // varNameButton
            // 
            this.varNameButton.Location = new System.Drawing.Point(489, 50);
            this.varNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.varNameButton.Name = "varNameButton";
            this.varNameButton.Size = new System.Drawing.Size(76, 26);
            this.varNameButton.TabIndex = 18;
            this.varNameButton.Text = "save";
            this.varNameButton.UseVisualStyleBackColor = true;
            this.varNameButton.Click += new System.EventHandler(this.VarNameButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(348, 52);
            this.numberBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(29, 22);
            this.numberBox.TabIndex = 19;
            // 
            // codeBlockList
            // 
            this.codeBlockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.codeBlockList.FullRowSelect = true;
            this.codeBlockList.Location = new System.Drawing.Point(831, 506);
            this.codeBlockList.Margin = new System.Windows.Forms.Padding(4);
            this.codeBlockList.Name = "codeBlockList";
            this.codeBlockList.Size = new System.Drawing.Size(339, 205);
            this.codeBlockList.TabIndex = 20;
            this.codeBlockList.UseCompatibleStateImageBehavior = false;
            this.codeBlockList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "val";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(941, 479);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Code Block Watch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Where does it start? ";
            // 
            // baseArrayBox
            // 
            this.baseArrayBox.Location = new System.Drawing.Point(574, 565);
            this.baseArrayBox.Name = "baseArrayBox";
            this.baseArrayBox.Size = new System.Drawing.Size(247, 22);
            this.baseArrayBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "How long is it?";
            // 
            // lenBox
            // 
            this.lenBox.Location = new System.Drawing.Point(573, 610);
            this.lenBox.Name = "lenBox";
            this.lenBox.Size = new System.Drawing.Size(247, 22);
            this.lenBox.TabIndex = 25;
            // 
            // watchButton
            // 
            this.watchButton.Location = new System.Drawing.Point(659, 638);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(75, 23);
            this.watchButton.TabIndex = 26;
            this.watchButton.Text = "watch";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.WatchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.lenBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.baseArrayBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codeBlockList);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.varNameButton);
            this.Controls.Add(this.variableNameBox);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputCardListBox);
            this.Controls.Add(this.translationListBox);
            this.Controls.Add(this.programListBox);
            this.Controls.Add(this.dataCardListBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Visual Interpreter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView dataCardListBox;
        private System.Windows.Forms.ListView programListBox;
        private System.Windows.Forms.ListView translationListBox;
        private System.Windows.Forms.ListView inputCardListBox;
        private System.Windows.Forms.ColumnHeader line;
        private System.Windows.Forms.ColumnHeader op;
        private System.Windows.Forms.ColumnHeader opn1;
        private System.Windows.Forms.ColumnHeader opn2;
        private System.Windows.Forms.ColumnHeader opn3;
        private System.Windows.Forms.ColumnHeader dataValue;
        private System.Windows.Forms.ColumnHeader dataLine;
        private System.Windows.Forms.ColumnHeader inputLine;
        private System.Windows.Forms.ColumnHeader inputValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView outputListBox;
        private System.Windows.Forms.ColumnHeader varName;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.TextBox variableNameBox;
        private System.Windows.Forms.Button varNameButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader linenum;
        private System.Windows.Forms.ListView codeBlockList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox baseArrayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lenBox;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Button button1;
    }
}

