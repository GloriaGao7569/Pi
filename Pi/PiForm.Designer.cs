namespace Pi
{
    partial class PiForm
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
            this._digits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._backgroundButton = new System.Windows.Forms.Button();
            this._pi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAPM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._performance = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._task = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._digits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._task)).BeginInit();
            this.SuspendLayout();
            // 
            // _digits
            // 
            this._digits.Location = new System.Drawing.Point(121, 35);
            this._digits.Name = "_digits";
            this._digits.Size = new System.Drawing.Size(154, 20);
            this._digits.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digits of Pi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _backgroundButton
            // 
            this._backgroundButton.Location = new System.Drawing.Point(34, 73);
            this._backgroundButton.Name = "_backgroundButton";
            this._backgroundButton.Size = new System.Drawing.Size(121, 23);
            this._backgroundButton.TabIndex = 2;
            this._backgroundButton.Text = "Background Worker";
            this._backgroundButton.UseVisualStyleBackColor = true;
            this._backgroundButton.Click += new System.EventHandler(this._backgroundButton_Click);
            // 
            // _pi
            // 
            this._pi.Location = new System.Drawing.Point(34, 127);
            this._pi.Multiline = true;
            this._pi.Name = "_pi";
            this._pi.Size = new System.Drawing.Size(479, 82);
            this._pi.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAPM
            // 
            this.btnAPM.Location = new System.Drawing.Point(161, 73);
            this.btnAPM.Name = "btnAPM";
            this.btnAPM.Size = new System.Drawing.Size(106, 23);
            this.btnAPM.TabIndex = 4;
            this.btnAPM.Text = "APM";
            this.btnAPM.UseVisualStyleBackColor = true;
            this.btnAPM.Click += new System.EventHandler(this.btnAPM_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Parallel Task";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Results:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Performance:";
            // 
            // _performance
            // 
            this._performance.Location = new System.Drawing.Point(111, 243);
            this._performance.Multiline = true;
            this._performance.Name = "_performance";
            this._performance.Size = new System.Drawing.Size(402, 20);
            this._performance.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number Of Task";
            // 
            // _task
            // 
            this._task.Location = new System.Drawing.Point(400, 97);
            this._task.Name = "_task";
            this._task.Size = new System.Drawing.Size(109, 20);
            this._task.TabIndex = 12;
            this._task.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // PiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._task);
            this.Controls.Add(this.button4);
            this.Controls.Add(this._performance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAPM);
            this.Controls.Add(this._pi);
            this.Controls.Add(this._backgroundButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._digits);
            this.Name = "PiForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._digits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _digits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _backgroundButton;
        private System.Windows.Forms.TextBox _pi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAPM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _performance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _task;
    }
}

