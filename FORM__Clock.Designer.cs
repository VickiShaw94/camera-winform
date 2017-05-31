namespace FAITool
{
    partial class FORM__Clock
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_saveResults = new DevExpress.XtraEditors.SimpleButton();
            this.btn_startTimer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pauseTimer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_resetTimer = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_saveResults, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_startTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_pauseTimer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_resetTimer, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_saveResults
            // 
            this.btn_saveResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveResults.Location = new System.Drawing.Point(280, 25);
            this.btn_saveResults.Name = "btn_saveResults";
            this.btn_saveResults.Size = new System.Drawing.Size(120, 50);
            this.btn_saveResults.TabIndex = 3;
            this.btn_saveResults.Text = "Stop and \r\nRecord";
            this.btn_saveResults.Click += new System.EventHandler(this.btn_saveResults_Click);
            // 
            // btn_startTimer
            // 
            this.btn_startTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startTimer.Location = new System.Drawing.Point(8, 25);
            this.btn_startTimer.Name = "btn_startTimer";
            this.btn_startTimer.Size = new System.Drawing.Size(120, 50);
            this.btn_startTimer.TabIndex = 0;
            this.btn_startTimer.Text = "Start";
            this.btn_startTimer.Click += new System.EventHandler(this.btn_startTimer_Click);
            // 
            // btn_pauseTimer
            // 
            this.btn_pauseTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pauseTimer.Location = new System.Drawing.Point(144, 25);
            this.btn_pauseTimer.Name = "btn_pauseTimer";
            this.btn_pauseTimer.Size = new System.Drawing.Size(120, 50);
            this.btn_pauseTimer.TabIndex = 1;
            this.btn_pauseTimer.Text = "Pause";
            this.btn_pauseTimer.Click += new System.EventHandler(this.btn_pauseTimer_Click);
            // 
            // btn_resetTimer
            // 
            this.btn_resetTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resetTimer.Location = new System.Drawing.Point(416, 25);
            this.btn_resetTimer.Name = "btn_resetTimer";
            this.btn_resetTimer.Size = new System.Drawing.Size(120, 50);
            this.btn_resetTimer.TabIndex = 2;
            this.btn_resetTimer.Text = "Reset";
            this.btn_resetTimer.Click += new System.EventHandler(this.btn_resetTimer_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_timer.Font = new System.Drawing.Font("Belgium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(545, 144);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "00:00:00.00";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // FORM__Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FORM__Clock";
            this.Text = "Stopwatch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_startTimer;
        private DevExpress.XtraEditors.SimpleButton btn_pauseTimer;
        private DevExpress.XtraEditors.SimpleButton btn_resetTimer;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btn_saveResults;
    }
}