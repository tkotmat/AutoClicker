using System.Windows.Forms;

namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stopButton = new Button();
            panel3 = new Panel();
            doubleClickDelayText = new Label();
            doubleClickDelay = new TextBox();
            label10 = new Label();
            valueClickers = new TextBox();
            label9 = new Label();
            isRepeatUnitStopper = new RadioButton();
            isRepeat = new RadioButton();
            startButton = new Button();
            millisecendsTextBox = new TextBox();
            hoursTextBox = new TextBox();
            minsTextBox = new TextBox();
            secondsTextBox = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            startClilkerButton = new TextBox();
            label7 = new Label();
            typeClickerBox = new ComboBox();
            mouseButton = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stopButton.Location = new Point(123, 250);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(112, 30);
            stopButton.TabIndex = 25;
            stopButton.Text = "StopButton";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(doubleClickDelayText);
            panel3.Controls.Add(doubleClickDelay);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(valueClickers);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(isRepeatUnitStopper);
            panel3.Controls.Add(isRepeat);
            panel3.Location = new Point(270, 72);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 172);
            panel3.TabIndex = 26;
            // 
            // doubleClickDelayText
            // 
            doubleClickDelayText.AutoSize = true;
            doubleClickDelayText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            doubleClickDelayText.Location = new Point(36, 112);
            doubleClickDelayText.Name = "doubleClickDelayText";
            doubleClickDelayText.Size = new Size(135, 21);
            doubleClickDelayText.TabIndex = 20;
            doubleClickDelayText.Text = "Double click delay";
            doubleClickDelayText.Visible = false;
            // 
            // doubleClickDelay
            // 
            doubleClickDelay.Location = new Point(18, 136);
            doubleClickDelay.Name = "doubleClickDelay";
            doubleClickDelay.Size = new Size(173, 23);
            doubleClickDelay.TabIndex = 19;
            doubleClickDelay.Text = "0";
            doubleClickDelay.TextAlign = HorizontalAlignment.Center;
            doubleClickDelay.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(140, 35);
            label10.Name = "label10";
            label10.Size = new Size(51, 21);
            label10.TabIndex = 18;
            label10.Text = "Times";
            // 
            // valueClickers
            // 
            valueClickers.Location = new Point(89, 36);
            valueClickers.Margin = new Padding(3, 2, 3, 2);
            valueClickers.Name = "valueClickers";
            valueClickers.Size = new Size(46, 23);
            valueClickers.TabIndex = 17;
            valueClickers.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(50, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 16;
            label9.Text = "Click Repeat";
            // 
            // isRepeatUnitStopper
            // 
            isRepeatUnitStopper.AutoSize = true;
            isRepeatUnitStopper.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isRepeatUnitStopper.Location = new Point(3, 76);
            isRepeatUnitStopper.Margin = new Padding(3, 2, 3, 2);
            isRepeatUnitStopper.Name = "isRepeatUnitStopper";
            isRepeatUnitStopper.Size = new Size(168, 25);
            isRepeatUnitStopper.TabIndex = 1;
            isRepeatUnitStopper.TabStop = true;
            isRepeatUnitStopper.Text = "Repeat until stopper";
            isRepeatUnitStopper.UseVisualStyleBackColor = true;
            // 
            // isRepeat
            // 
            isRepeat.AutoSize = true;
            isRepeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isRepeat.Location = new Point(3, 33);
            isRepeat.Margin = new Padding(3, 2, 3, 2);
            isRepeat.Name = "isRepeat";
            isRepeat.Size = new Size(76, 25);
            isRepeat.TabIndex = 0;
            isRepeat.TabStop = true;
            isRepeat.Text = "Repeat";
            isRepeat.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startButton.Location = new Point(3, 250);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(105, 30);
            startButton.TabIndex = 24;
            startButton.Text = "StartButton";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // millisecendsTextBox
            // 
            millisecendsTextBox.Location = new Point(430, 58);
            millisecendsTextBox.Name = "millisecendsTextBox";
            millisecendsTextBox.Size = new Size(47, 23);
            millisecendsTextBox.TabIndex = 21;
            millisecendsTextBox.Text = "0";
            millisecendsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(74, 57);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(41, 23);
            hoursTextBox.TabIndex = 15;
            hoursTextBox.Text = "0";
            hoursTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // minsTextBox
            // 
            minsTextBox.Location = new Point(171, 57);
            minsTextBox.Name = "minsTextBox";
            minsTextBox.Size = new Size(44, 23);
            minsTextBox.TabIndex = 17;
            minsTextBox.Text = "0";
            minsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // secondsTextBox
            // 
            secondsTextBox.Location = new Point(270, 57);
            secondsTextBox.Name = "secondsTextBox";
            secondsTextBox.Size = new Size(44, 23);
            secondsTextBox.TabIndex = 19;
            secondsTextBox.Text = "0";
            secondsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(startClilkerButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(typeClickerBox);
            panel2.Controls.Add(mouseButton);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 172);
            panel2.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(46, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 15;
            label8.Text = "Click Option";
            // 
            // startClilkerButton
            // 
            startClilkerButton.Location = new Point(3, 136);
            startClilkerButton.Name = "startClilkerButton";
            startClilkerButton.ReadOnly = true;
            startClilkerButton.Size = new Size(219, 23);
            startClilkerButton.TabIndex = 14;
            startClilkerButton.KeyDown += startClilkerButton_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(28, 112);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 10;
            label7.Text = "Start/Stop Button";
            // 
            // typeClickerBox
            // 
            typeClickerBox.FormattingEnabled = true;
            typeClickerBox.Items.AddRange(new object[] { "Sinlge", "Double" });
            typeClickerBox.Location = new Point(62, 76);
            typeClickerBox.Name = "typeClickerBox";
            typeClickerBox.Size = new Size(155, 23);
            typeClickerBox.TabIndex = 12;
            typeClickerBox.Text = "Sinlge";
            typeClickerBox.SelectedIndexChanged += typeClickerBox_SelectedIndexChanged;
            // 
            // mouseButton
            // 
            mouseButton.FormattingEnabled = true;
            mouseButton.Items.AddRange(new object[] { "Left", "Center", "Right" });
            mouseButton.Location = new Point(116, 33);
            mouseButton.Name = "mouseButton";
            mouseButton.Size = new Size(101, 23);
            mouseButton.TabIndex = 10;
            mouseButton.Text = "Left";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 74);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 11;
            label6.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 33);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 10;
            label5.Text = "Mouse button";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 16;
            label1.Text = "Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(320, 57);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 22;
            label4.Text = "Milliseconds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(120, 57);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 18;
            label2.Text = "Mins";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(220, 57);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 20;
            label3.Text = "Sens";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(stopButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(startButton);
            panel1.Location = new Point(2, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 290);
            panel1.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(label11);
            panel4.Location = new Point(2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 48);
            panel4.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(176, 6);
            label11.Name = "label11";
            label11.Size = new Size(136, 32);
            label11.TabIndex = 0;
            label11.Text = "AutoClicker";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 330);
            Controls.Add(panel4);
            Controls.Add(millisecendsTextBox);
            Controls.Add(hoursTextBox);
            Controls.Add(minsTextBox);
            Controls.Add(secondsTextBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button stopButton;
        public Panel panel3;
        public Label label10;
        public TextBox valueClickers;
        public Label label9;
        public RadioButton isRepeatUnitStopper;
        public RadioButton isRepeat;
        public Button startButton;
        public TextBox millisecendsTextBox;
        public TextBox hoursTextBox;
        public TextBox minsTextBox;
        public TextBox secondsTextBox;
        public Panel panel2;
        public Label label8;
        public TextBox startClilkerButton;
        public Label label7;
        public ComboBox mouseButton;
        public Label label5;
        public Label label1;
        public Label label4;
        public Label label2;
        public Label label3;
        public Panel panel1;
        public Panel panel4;
        public Label label11;
        public ComboBox typeClickerBox;
        public Label label6;
        public Label doubleClickDelayText;
        public TextBox doubleClickDelay;
    }
}
