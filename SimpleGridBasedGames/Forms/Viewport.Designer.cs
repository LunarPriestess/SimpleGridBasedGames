
namespace SimpleGridBasedGames.Forms
{
    partial class Viewport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewport));
            this.uxViewPort = new System.Windows.Forms.PictureBox();
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxViewPort)).BeginInit();
            this.SuspendLayout();
            // 
            // uxViewPort
            // 
            this.uxViewPort.BackColor = System.Drawing.Color.Black;
            this.uxViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxViewPort.Location = new System.Drawing.Point(0, 0);
            this.uxViewPort.Name = "uxViewPort";
            this.uxViewPort.Size = new System.Drawing.Size(800, 500);
            this.uxViewPort.TabIndex = 0;
            this.uxViewPort.TabStop = false;
            this.uxViewPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxViewPort_MouseClick);
            // 
            // uxTimer
            // 
            this.uxTimer.Enabled = true;
            this.uxTimer.Interval = 60;
            this.uxTimer.Tick += new System.EventHandler(this.uxTimer_Tick);
            // 
            // Viewport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.uxViewPort);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Viewport";
            this.Text = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viewport_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Viewport_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uxViewPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox uxViewPort;
        private System.Windows.Forms.Timer uxTimer;
    }
}