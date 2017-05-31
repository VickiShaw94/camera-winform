namespace FAITool
{
    partial class FORM__CameraCapture
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
            this.btn_takePicture = new DevExpress.XtraEditors.SimpleButton();
            this.btn_takeVideo = new DevExpress.XtraEditors.SimpleButton();
            this.cameraControl1 = new DevExpress.XtraEditors.Camera.CameraControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_takePicture
            // 
            this.btn_takePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_takePicture.Location = new System.Drawing.Point(84, 3);
            this.btn_takePicture.Name = "btn_takePicture";
            this.btn_takePicture.Size = new System.Drawing.Size(158, 54);
            this.btn_takePicture.TabIndex = 2;
            this.btn_takePicture.Text = "Capture Image";
            this.btn_takePicture.Click += new System.EventHandler(this.btn_takePicture_Click);
            // 
            // btn_takeVideo
            // 
            this.btn_takeVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_takeVideo.Location = new System.Drawing.Point(415, 3);
            this.btn_takeVideo.Name = "btn_takeVideo";
            this.btn_takeVideo.Size = new System.Drawing.Size(148, 54);
            this.btn_takeVideo.TabIndex = 3;
            this.btn_takeVideo.Click += new System.EventHandler(this.btn_takeVideo_Click);
            // 
            // cameraControl1
            // 
            this.cameraControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cameraControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl1.Location = new System.Drawing.Point(0, 0);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(652, 478);
            this.cameraControl1.TabIndex = 4;
            this.cameraControl1.Text = "cameraControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_takePicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_takeVideo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FORM__CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cameraControl1);
            this.Name = "FORM__CameraCapture";
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.FORM__CameraCapture_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_takePicture;
        private DevExpress.XtraEditors.SimpleButton btn_takeVideo;
        private DevExpress.XtraEditors.Camera.CameraControl cameraControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}