namespace FlappyBird
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pipeTop = new DevExpress.XtraEditors.PictureEdit();
            this.pipeBottom = new DevExpress.XtraEditors.PictureEdit();
            this.flappy = new DevExpress.XtraEditors.PictureEdit();
            this.ground = new DevExpress.XtraEditors.PictureEdit();
            this.lblScore = new DevExpress.XtraEditors.LabelControl();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblOver = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.EditValue = ((object)(resources.GetObject("pipeTop.EditValue")));
            this.pipeTop.Location = new System.Drawing.Point(944, -1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Properties.Appearance.Options.UseBackColor = true;
            this.pipeTop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeTop.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeTop.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeTop.Size = new System.Drawing.Size(190, 194);
            this.pipeTop.TabIndex = 0;
            // 
            // pipeBottom
            // 
            this.pipeBottom.EditValue = ((object)(resources.GetObject("pipeBottom.EditValue")));
            this.pipeBottom.Location = new System.Drawing.Point(834, 365);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Properties.Appearance.Options.UseBackColor = true;
            this.pipeBottom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pipeBottom.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pipeBottom.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pipeBottom.Size = new System.Drawing.Size(190, 194);
            this.pipeBottom.TabIndex = 1;
            // 
            // flappy
            // 
            this.flappy.EditValue = ((object)(resources.GetObject("flappy.EditValue")));
            this.flappy.Location = new System.Drawing.Point(170, 213);
            this.flappy.Name = "flappy";
            this.flappy.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.flappy.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.flappy.Properties.Appearance.Options.UseBackColor = true;
            this.flappy.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flappy.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.flappy.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.flappy.Size = new System.Drawing.Size(73, 66);
            this.flappy.TabIndex = 2;
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.EditValue = ((object)(resources.GetObject("ground.EditValue")));
            this.ground.Location = new System.Drawing.Point(0, 556);
            this.ground.Name = "ground";
            this.ground.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ground.Properties.InitialImageOptions.Image")));
            this.ground.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ground.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ground.Size = new System.Drawing.Size(1458, 96);
            this.ground.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.Appearance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Appearance.Options.UseFont = true;
            this.lblScore.Location = new System.Drawing.Point(35, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(117, 32);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblOver
            // 
            this.lblOver.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOver.Appearance.Options.UseFont = true;
            this.lblOver.Location = new System.Drawing.Point(633, 233);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(82, 27);
            this.lblOver.TabIndex = 5;
            this.lblOver.Text = "lblOver";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1458, 652);
            this.Controls.Add(this.lblOver);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pipeTop;
        private DevExpress.XtraEditors.PictureEdit pipeBottom;
        private DevExpress.XtraEditors.PictureEdit flappy;
        private DevExpress.XtraEditors.PictureEdit ground;
        private DevExpress.XtraEditors.LabelControl lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private DevExpress.XtraEditors.LabelControl lblOver;
    }
}

