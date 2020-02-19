namespace Sort_Test
{
    partial class frmSort_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSort_Test));
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.picVisual = new System.Windows.Forms.PictureBox();
            this.gBoxMain = new System.Windows.Forms.GroupBox();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.radBtnAuto = new System.Windows.Forms.RadioButton();
            this.radBtnManual = new System.Windows.Forms.RadioButton();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).BeginInit();
            this.gBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar1
            // 
            this.pBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar1.Location = new System.Drawing.Point(0, 539);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(784, 22);
            this.pBar1.TabIndex = 7;
            // 
            // picVisual
            // 
            this.picVisual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVisual.Dock = System.Windows.Forms.DockStyle.Right;
            this.picVisual.Location = new System.Drawing.Point(174, 0);
            this.picVisual.Name = "picVisual";
            this.picVisual.Size = new System.Drawing.Size(610, 539);
            this.picVisual.TabIndex = 11;
            this.picVisual.TabStop = false;
            this.picVisual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picVisual_MouseDown);
            this.picVisual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picVisual_MouseMove);
            // 
            // gBoxMain
            // 
            this.gBoxMain.Controls.Add(this.chkTrace);
            this.gBoxMain.Controls.Add(this.radBtnAuto);
            this.gBoxMain.Controls.Add(this.radBtnManual);
            this.gBoxMain.Controls.Add(this.txtManual);
            this.gBoxMain.Controls.Add(this.txtSize);
            this.gBoxMain.Controls.Add(this.lblSize);
            this.gBoxMain.Controls.Add(this.lblTime);
            this.gBoxMain.Controls.Add(this.txtResult);
            this.gBoxMain.Controls.Add(this.txtData);
            this.gBoxMain.Controls.Add(this.btnQuit);
            this.gBoxMain.Controls.Add(this.btnStart);
            this.gBoxMain.Controls.Add(this.btnInitialize);
            this.gBoxMain.Controls.Add(this.comboMethod);
            this.gBoxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBoxMain.Location = new System.Drawing.Point(0, 0);
            this.gBoxMain.Name = "gBoxMain";
            this.gBoxMain.Size = new System.Drawing.Size(174, 539);
            this.gBoxMain.TabIndex = 12;
            this.gBoxMain.TabStop = false;
            this.gBoxMain.Text = "Sort Test";
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(90, 60);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(54, 17);
            this.chkTrace.TabIndex = 25;
            this.chkTrace.Text = "Trace";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // radBtnAuto
            // 
            this.radBtnAuto.AutoSize = true;
            this.radBtnAuto.Checked = true;
            this.radBtnAuto.Location = new System.Drawing.Point(95, 37);
            this.radBtnAuto.Name = "radBtnAuto";
            this.radBtnAuto.Size = new System.Drawing.Size(73, 17);
            this.radBtnAuto.TabIndex = 24;
            this.radBtnAuto.TabStop = true;
            this.radBtnAuto.Text = "Auto Data";
            this.radBtnAuto.UseVisualStyleBackColor = true;
            // 
            // radBtnManual
            // 
            this.radBtnManual.AutoSize = true;
            this.radBtnManual.Location = new System.Drawing.Point(6, 37);
            this.radBtnManual.Name = "radBtnManual";
            this.radBtnManual.Size = new System.Drawing.Size(86, 17);
            this.radBtnManual.TabIndex = 23;
            this.radBtnManual.Text = "Manual Data";
            this.radBtnManual.UseVisualStyleBackColor = true;
            this.radBtnManual.CheckedChanged += new System.EventHandler(this.radBtnManual_CheckedChanged);
            // 
            // txtManual
            // 
            this.txtManual.Location = new System.Drawing.Point(6, 117);
            this.txtManual.Multiline = true;
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(162, 81);
            this.txtManual.TabIndex = 22;
            this.txtManual.Text = "1,4,2,8,5,7,6,3,9,15,684,21,4684,214,648,73,164,0";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(66, 13);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(102, 20);
            this.txtSize.TabIndex = 19;
            this.txtSize.Text = "100";
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 16);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(54, 13);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "Data size:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time: ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(90, 262);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(78, 271);
            this.txtResult.TabIndex = 16;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(6, 262);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(78, 271);
            this.txtData.TabIndex = 15;
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(90, 231);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(78, 25);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 25);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(6, 60);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(78, 25);
            this.btnInitialize.TabIndex = 12;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // comboMethod
            // 
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Items.AddRange(new object[] {
            "BubbleSort",
            "Insertion",
            "QuikSort",
            "Selection",
            "MergeSort"});
            this.comboMethod.Location = new System.Drawing.Point(6, 204);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(162, 21);
            this.comboMethod.TabIndex = 11;
            // 
            // frmSort_Test
            // 
            this.AcceptButton = this.btnInitialize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gBoxMain);
            this.Controls.Add(this.picVisual);
            this.Controls.Add(this.pBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSort_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort_Test";
            this.Load += new System.EventHandler(this.frmSort_Test_Load);
            this.Resize += new System.EventHandler(this.frmSort_Test_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picVisual)).EndInit();
            this.gBoxMain.ResumeLayout(false);
            this.gBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.PictureBox picVisual;
        private System.Windows.Forms.GroupBox gBoxMain;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.RadioButton radBtnAuto;
        private System.Windows.Forms.RadioButton radBtnManual;
        private System.Windows.Forms.CheckBox chkTrace;
    }
}

