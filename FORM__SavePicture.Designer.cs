namespace FAITool
{
    partial class FORM__SavePicture
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
            this.txtbox_fileName = new System.Windows.Forms.TextBox();
            this.lbl_saveFile = new DevExpress.XtraEditors.LabelControl();
            this.btn_saveName = new DevExpress.XtraEditors.SimpleButton();
            this.tbleLayoutPnl_saveFile = new System.Windows.Forms.TableLayoutPanel();
            this.tbleLayoutPnl_saveFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_fileName
            // 
            this.txtbox_fileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_fileName.BackColor = System.Drawing.Color.White;
            this.txtbox_fileName.Location = new System.Drawing.Point(3, 117);
            this.txtbox_fileName.Name = "txtbox_fileName";
            this.txtbox_fileName.Size = new System.Drawing.Size(400, 27);
            this.txtbox_fileName.TabIndex = 0;
            // 
            // lbl_saveFile
            // 
            this.lbl_saveFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_saveFile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbl_saveFile.Location = new System.Drawing.Point(3, 24);
            this.lbl_saveFile.Name = "lbl_saveFile";
            this.lbl_saveFile.Size = new System.Drawing.Size(400, 38);
            this.lbl_saveFile.TabIndex = 1;
            this.lbl_saveFile.Text = "If you would like to change the file name from the default, please change it belo" +
    "w. ";
            // 
            // btn_saveName
            // 
            this.btn_saveName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveName.Location = new System.Drawing.Point(147, 206);
            this.btn_saveName.Name = "btn_saveName";
            this.btn_saveName.Size = new System.Drawing.Size(111, 23);
            this.btn_saveName.TabIndex = 2;
            this.btn_saveName.Text = "Save Name";
            this.btn_saveName.Click += new System.EventHandler(this.btn_saveName_Click);
            // 
            // tbleLayoutPnl_saveFile
            // 
            this.tbleLayoutPnl_saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbleLayoutPnl_saveFile.ColumnCount = 1;
            this.tbleLayoutPnl_saveFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbleLayoutPnl_saveFile.Controls.Add(this.lbl_saveFile, 0, 0);
            this.tbleLayoutPnl_saveFile.Controls.Add(this.txtbox_fileName, 0, 1);
            this.tbleLayoutPnl_saveFile.Controls.Add(this.btn_saveName, 0, 2);
            this.tbleLayoutPnl_saveFile.Location = new System.Drawing.Point(0, 0);
            this.tbleLayoutPnl_saveFile.Name = "tbleLayoutPnl_saveFile";
            this.tbleLayoutPnl_saveFile.RowCount = 3;
            this.tbleLayoutPnl_saveFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleLayoutPnl_saveFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleLayoutPnl_saveFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbleLayoutPnl_saveFile.Size = new System.Drawing.Size(406, 261);
            this.tbleLayoutPnl_saveFile.TabIndex = 3;
            // 
            // FORM__FileRenamePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.tbleLayoutPnl_saveFile);
            this.Name = "FORM__FileRenamePopup";
            this.Text = "Rename File";
            this.tbleLayoutPnl_saveFile.ResumeLayout(false);
            this.tbleLayoutPnl_saveFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_fileName;
        private DevExpress.XtraEditors.LabelControl lbl_saveFile;
        private DevExpress.XtraEditors.SimpleButton btn_saveName;
        private System.Windows.Forms.TableLayoutPanel tbleLayoutPnl_saveFile;
    }
}