namespace FAITool
{
    partial class FORM__ScanSystem
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
            this.txtBox_barcode = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtBox_barcode
            // 
            this.txtBox_barcode.Location = new System.Drawing.Point(39, 117);
            this.txtBox_barcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_barcode.Name = "txtBox_barcode";
            this.txtBox_barcode.Size = new System.Drawing.Size(349, 27);
            this.txtBox_barcode.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(-3, 21);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(428, 60);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome to the FAI tool! Please scan the first system\'s 1S barcode.";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(159, 177);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(112, 34);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "Enter";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // FORM__ScanSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 254);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.txtBox_barcode);
            this.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FORM__ScanSystem";
            this.Text = "System Scan Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_barcode;
        private System.Windows.Forms.Label lbl_welcome;
        private DevExpress.XtraEditors.SimpleButton btn_enter;
    }
}