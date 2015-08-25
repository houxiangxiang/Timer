namespace Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageClock = new System.Windows.Forms.TabPage();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.tabPagePomodoro = new System.Windows.Forms.TabPage();
            this.buttonPomodoroStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPomodoroStart = new System.Windows.Forms.Button();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerTrigger = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageClock.SuspendLayout();
            this.tabPagePomodoro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClock);
            this.tabControlMain.Controls.Add(this.tabPagePomodoro);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ImageList = this.imageList1;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(675, 262);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageClock
            // 
            this.tabPageClock.BackColor = System.Drawing.Color.Silver;
            this.tabPageClock.Controls.Add(this.textBoxDate);
            this.tabPageClock.Controls.Add(this.textBoxTime);
            this.tabPageClock.ImageIndex = 0;
            this.tabPageClock.Location = new System.Drawing.Point(4, 34);
            this.tabPageClock.Name = "tabPageClock";
            this.tabPageClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClock.Size = new System.Drawing.Size(667, 224);
            this.tabPageClock.TabIndex = 0;
            this.tabPageClock.Text = "Clock";
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.Color.Silver;
            this.textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.ForeColor = System.Drawing.Color.Navy;
            this.textBoxDate.Location = new System.Drawing.Point(41, 12);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(439, 37);
            this.textBoxDate.TabIndex = 14;
            this.textBoxDate.Text = "DATE";
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.Silver;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.ForeColor = System.Drawing.Color.Navy;
            this.textBoxTime.Location = new System.Drawing.Point(99, 91);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(439, 73);
            this.textBoxTime.TabIndex = 13;
            this.textBoxTime.Text = "TIME";
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPagePomodoro
            // 
            this.tabPagePomodoro.BackColor = System.Drawing.Color.Silver;
            this.tabPagePomodoro.Controls.Add(this.buttonPomodoroStop);
            this.tabPagePomodoro.Controls.Add(this.label3);
            this.tabPagePomodoro.Controls.Add(this.label2);
            this.tabPagePomodoro.Controls.Add(this.label1);
            this.tabPagePomodoro.Controls.Add(this.buttonPomodoroStart);
            this.tabPagePomodoro.Controls.Add(this.numericUpDownSec);
            this.tabPagePomodoro.Controls.Add(this.numericUpDownMin);
            this.tabPagePomodoro.Controls.Add(this.numericUpDownHour);
            this.tabPagePomodoro.ImageIndex = 1;
            this.tabPagePomodoro.Location = new System.Drawing.Point(4, 34);
            this.tabPagePomodoro.Name = "tabPagePomodoro";
            this.tabPagePomodoro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePomodoro.Size = new System.Drawing.Size(667, 224);
            this.tabPagePomodoro.TabIndex = 1;
            this.tabPagePomodoro.Text = "Pomodoro";
            // 
            // buttonPomodoroStop
            // 
            this.buttonPomodoroStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPomodoroStop.ForeColor = System.Drawing.Color.Navy;
            this.buttonPomodoroStop.Location = new System.Drawing.Point(341, 125);
            this.buttonPomodoroStop.Name = "buttonPomodoroStop";
            this.buttonPomodoroStop.Size = new System.Drawing.Size(275, 75);
            this.buttonPomodoroStop.TabIndex = 7;
            this.buttonPomodoroStop.Text = "STOP";
            this.buttonPomodoroStop.UseVisualStyleBackColor = true;
            this.buttonPomodoroStop.Click += new System.EventHandler(this.buttonPomodoroStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(468, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(266, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "MIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOUR";
            // 
            // buttonPomodoroStart
            // 
            this.buttonPomodoroStart.BackColor = System.Drawing.Color.Navy;
            this.buttonPomodoroStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPomodoroStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPomodoroStart.ForeColor = System.Drawing.Color.White;
            this.buttonPomodoroStart.Location = new System.Drawing.Point(39, 125);
            this.buttonPomodoroStart.Name = "buttonPomodoroStart";
            this.buttonPomodoroStart.Size = new System.Drawing.Size(275, 75);
            this.buttonPomodoroStart.TabIndex = 3;
            this.buttonPomodoroStart.Text = "START";
            this.buttonPomodoroStart.UseVisualStyleBackColor = false;
            this.buttonPomodoroStart.Click += new System.EventHandler(this.buttonPomodoroStart_Click);
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.BackColor = System.Drawing.Color.White;
            this.numericUpDownSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSec.ForeColor = System.Drawing.Color.Navy;
            this.numericUpDownSec.Location = new System.Drawing.Point(550, 25);
            this.numericUpDownSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.ReadOnly = true;
            this.numericUpDownSec.Size = new System.Drawing.Size(80, 44);
            this.numericUpDownSec.TabIndex = 2;
            this.numericUpDownSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.BackColor = System.Drawing.Color.White;
            this.numericUpDownMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMin.ForeColor = System.Drawing.Color.Navy;
            this.numericUpDownMin.Location = new System.Drawing.Point(341, 28);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.ReadOnly = true;
            this.numericUpDownMin.Size = new System.Drawing.Size(80, 44);
            this.numericUpDownMin.TabIndex = 1;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.BackColor = System.Drawing.Color.White;
            this.numericUpDownHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHour.ForeColor = System.Drawing.Color.Navy;
            this.numericUpDownHour.Location = new System.Drawing.Point(144, 28);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.ReadOnly = true;
            this.numericUpDownHour.Size = new System.Drawing.Size(80, 44);
            this.numericUpDownHour.TabIndex = 0;
            this.numericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clock.png");
            this.imageList1.Images.SetKeyName(1, "pomodoro.jpg");
            // 
            // timerTrigger
            // 
            this.timerTrigger.Enabled = true;
            this.timerTrigger.Interval = 1000;
            this.timerTrigger.Tick += new System.EventHandler(this.timerTrigger_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 262);
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageClock.ResumeLayout(false);
            this.tabPageClock.PerformLayout();
            this.tabPagePomodoro.ResumeLayout(false);
            this.tabPagePomodoro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageClock;
        private System.Windows.Forms.TabPage tabPagePomodoro;
        private System.Windows.Forms.Button buttonPomodoroStart;
        private System.Windows.Forms.NumericUpDown numericUpDownSec;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Timer timerTrigger;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPomodoroStop;
        private System.Windows.Forms.ImageList imageList1;
    }
}

