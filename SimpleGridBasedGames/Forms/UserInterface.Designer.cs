
namespace SimpleGridBasedGames
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxSettingsGroup = new System.Windows.Forms.GroupBox();
            this.uxGamePreview = new System.Windows.Forms.PictureBox();
            this.uxLeftButton = new System.Windows.Forms.Button();
            this.uxRightButton = new System.Windows.Forms.Button();
            this.uxApplySettings = new System.Windows.Forms.Button();
            this.uxDefaultSettings = new System.Windows.Forms.Button();
            this.uxPlayButton = new System.Windows.Forms.Button();
            this.uxGameSelectPanel = new System.Windows.Forms.Panel();
            this.uxSettingsFileLabel = new System.Windows.Forms.Label();
            this.uxSoundLabel = new System.Windows.Forms.Label();
            this.uxSoundBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.uxSelectSettingsFile = new System.Windows.Forms.Button();
            this.uxColorDialog = new System.Windows.Forms.ColorDialog();
            this.uxByLabel = new System.Windows.Forms.Label();
            this.uxXValue = new System.Windows.Forms.NumericUpDown();
            this.uxYValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxColor1 = new System.Windows.Forms.PictureBox();
            this.uxColor2 = new System.Windows.Forms.PictureBox();
            this.uxChangeColor1 = new System.Windows.Forms.Button();
            this.uxChangeColor2 = new System.Windows.Forms.Button();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamePreview)).BeginInit();
            this.uxGameSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSoundBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxColor2)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSettingsGroup
            // 
            this.uxSettingsGroup.Controls.Add(this.groupBox2);
            this.uxSettingsGroup.Controls.Add(this.uxYValue);
            this.uxSettingsGroup.Controls.Add(this.uxXValue);
            this.uxSettingsGroup.Controls.Add(this.uxByLabel);
            this.uxSettingsGroup.Controls.Add(this.uxSelectSettingsFile);
            this.uxSettingsGroup.Controls.Add(this.label3);
            this.uxSettingsGroup.Controls.Add(this.uxSoundBar);
            this.uxSettingsGroup.Controls.Add(this.uxSoundLabel);
            this.uxSettingsGroup.Controls.Add(this.uxSettingsFileLabel);
            this.uxSettingsGroup.Controls.Add(this.uxDefaultSettings);
            this.uxSettingsGroup.Controls.Add(this.uxApplySettings);
            this.uxSettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.uxSettingsGroup.Name = "uxSettingsGroup";
            this.uxSettingsGroup.Size = new System.Drawing.Size(279, 312);
            this.uxSettingsGroup.TabIndex = 0;
            this.uxSettingsGroup.TabStop = false;
            this.uxSettingsGroup.Text = "Settings: ";
            // 
            // uxGamePreview
            // 
            this.uxGamePreview.BackColor = System.Drawing.Color.Black;
            this.uxGamePreview.Location = new System.Drawing.Point(3, 3);
            this.uxGamePreview.Name = "uxGamePreview";
            this.uxGamePreview.Size = new System.Drawing.Size(250, 250);
            this.uxGamePreview.TabIndex = 1;
            this.uxGamePreview.TabStop = false;
            // 
            // uxLeftButton
            // 
            this.uxLeftButton.Location = new System.Drawing.Point(3, 259);
            this.uxLeftButton.Name = "uxLeftButton";
            this.uxLeftButton.Size = new System.Drawing.Size(50, 50);
            this.uxLeftButton.TabIndex = 2;
            this.uxLeftButton.Text = "<";
            this.uxLeftButton.UseVisualStyleBackColor = true;
            // 
            // uxRightButton
            // 
            this.uxRightButton.Location = new System.Drawing.Point(203, 259);
            this.uxRightButton.Name = "uxRightButton";
            this.uxRightButton.Size = new System.Drawing.Size(50, 50);
            this.uxRightButton.TabIndex = 3;
            this.uxRightButton.Text = ">";
            this.uxRightButton.UseVisualStyleBackColor = true;
            // 
            // uxApplySettings
            // 
            this.uxApplySettings.Location = new System.Drawing.Point(198, 281);
            this.uxApplySettings.Name = "uxApplySettings";
            this.uxApplySettings.Size = new System.Drawing.Size(75, 25);
            this.uxApplySettings.TabIndex = 0;
            this.uxApplySettings.Text = "Apply";
            this.uxApplySettings.UseVisualStyleBackColor = true;
            // 
            // uxDefaultSettings
            // 
            this.uxDefaultSettings.Location = new System.Drawing.Point(6, 281);
            this.uxDefaultSettings.Name = "uxDefaultSettings";
            this.uxDefaultSettings.Size = new System.Drawing.Size(75, 25);
            this.uxDefaultSettings.TabIndex = 1;
            this.uxDefaultSettings.Text = "Default";
            this.uxDefaultSettings.UseVisualStyleBackColor = true;
            // 
            // uxPlayButton
            // 
            this.uxPlayButton.Location = new System.Drawing.Point(59, 259);
            this.uxPlayButton.Name = "uxPlayButton";
            this.uxPlayButton.Size = new System.Drawing.Size(138, 50);
            this.uxPlayButton.TabIndex = 4;
            this.uxPlayButton.Text = "Play";
            this.uxPlayButton.UseVisualStyleBackColor = true;
            // 
            // uxGameSelectPanel
            // 
            this.uxGameSelectPanel.AutoSize = true;
            this.uxGameSelectPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxGameSelectPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uxGameSelectPanel.Controls.Add(this.uxGamePreview);
            this.uxGameSelectPanel.Controls.Add(this.uxPlayButton);
            this.uxGameSelectPanel.Controls.Add(this.uxLeftButton);
            this.uxGameSelectPanel.Controls.Add(this.uxRightButton);
            this.uxGameSelectPanel.Location = new System.Drawing.Point(297, 12);
            this.uxGameSelectPanel.Name = "uxGameSelectPanel";
            this.uxGameSelectPanel.Size = new System.Drawing.Size(256, 312);
            this.uxGameSelectPanel.TabIndex = 5;
            // 
            // uxSettingsFileLabel
            // 
            this.uxSettingsFileLabel.AutoSize = true;
            this.uxSettingsFileLabel.Location = new System.Drawing.Point(7, 23);
            this.uxSettingsFileLabel.Name = "uxSettingsFileLabel";
            this.uxSettingsFileLabel.Size = new System.Drawing.Size(128, 17);
            this.uxSettingsFileLabel.TabIndex = 2;
            this.uxSettingsFileLabel.Text = "Settings File: ";
            // 
            // uxSoundLabel
            // 
            this.uxSoundLabel.AutoSize = true;
            this.uxSoundLabel.Location = new System.Drawing.Point(7, 45);
            this.uxSoundLabel.Name = "uxSoundLabel";
            this.uxSoundLabel.Size = new System.Drawing.Size(56, 17);
            this.uxSoundLabel.TabIndex = 3;
            this.uxSoundLabel.Text = "Sound:";
            // 
            // uxSoundBar
            // 
            this.uxSoundBar.Location = new System.Drawing.Point(6, 65);
            this.uxSoundBar.Maximum = 20;
            this.uxSoundBar.Name = "uxSoundBar";
            this.uxSoundBar.Size = new System.Drawing.Size(267, 56);
            this.uxSoundBar.TabIndex = 4;
            this.uxSoundBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.uxSoundBar.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grid Size:";
            // 
            // uxSelectSettingsFile
            // 
            this.uxSelectSettingsFile.Location = new System.Drawing.Point(198, 19);
            this.uxSelectSettingsFile.Name = "uxSelectSettingsFile";
            this.uxSelectSettingsFile.Size = new System.Drawing.Size(75, 23);
            this.uxSelectSettingsFile.TabIndex = 6;
            this.uxSelectSettingsFile.Text = "Select";
            this.uxSelectSettingsFile.UseVisualStyleBackColor = true;
            // 
            // uxByLabel
            // 
            this.uxByLabel.AutoSize = true;
            this.uxByLabel.Location = new System.Drawing.Point(96, 147);
            this.uxByLabel.Name = "uxByLabel";
            this.uxByLabel.Size = new System.Drawing.Size(16, 17);
            this.uxByLabel.TabIndex = 7;
            this.uxByLabel.Text = "x";
            // 
            // uxXValue
            // 
            this.uxXValue.Location = new System.Drawing.Point(10, 145);
            this.uxXValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uxXValue.Name = "uxXValue";
            this.uxXValue.Size = new System.Drawing.Size(80, 23);
            this.uxXValue.TabIndex = 8;
            this.uxXValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxYValue
            // 
            this.uxYValue.Location = new System.Drawing.Point(118, 145);
            this.uxYValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uxYValue.Name = "uxYValue";
            this.uxYValue.Size = new System.Drawing.Size(80, 23);
            this.uxYValue.TabIndex = 9;
            this.uxYValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxChangeColor2);
            this.groupBox2.Controls.Add(this.uxChangeColor1);
            this.groupBox2.Controls.Add(this.uxColor2);
            this.groupBox2.Controls.Add(this.uxColor1);
            this.groupBox2.Location = new System.Drawing.Point(7, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Colors: ";
            // 
            // uxColor1
            // 
            this.uxColor1.BackColor = System.Drawing.Color.White;
            this.uxColor1.Location = new System.Drawing.Point(7, 23);
            this.uxColor1.Name = "uxColor1";
            this.uxColor1.Size = new System.Drawing.Size(23, 23);
            this.uxColor1.TabIndex = 0;
            this.uxColor1.TabStop = false;
            // 
            // uxColor2
            // 
            this.uxColor2.BackColor = System.Drawing.Color.Black;
            this.uxColor2.Location = new System.Drawing.Point(7, 52);
            this.uxColor2.Name = "uxColor2";
            this.uxColor2.Size = new System.Drawing.Size(23, 23);
            this.uxColor2.TabIndex = 1;
            this.uxColor2.TabStop = false;
            // 
            // uxChangeColor1
            // 
            this.uxChangeColor1.Location = new System.Drawing.Point(36, 22);
            this.uxChangeColor1.Name = "uxChangeColor1";
            this.uxChangeColor1.Size = new System.Drawing.Size(155, 25);
            this.uxChangeColor1.TabIndex = 11;
            this.uxChangeColor1.Text = "Change Color 1";
            this.uxChangeColor1.UseVisualStyleBackColor = true;
            this.uxChangeColor1.Click += new System.EventHandler(this.uxChangeColor1_Click);
            // 
            // uxChangeColor2
            // 
            this.uxChangeColor2.Location = new System.Drawing.Point(36, 52);
            this.uxChangeColor2.Name = "uxChangeColor2";
            this.uxChangeColor2.Size = new System.Drawing.Size(155, 25);
            this.uxChangeColor2.TabIndex = 12;
            this.uxChangeColor2.Text = "Change Color 2";
            this.uxChangeColor2.UseVisualStyleBackColor = true;
            this.uxChangeColor2.Click += new System.EventHandler(this.uxChangeColor2_Click);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.uxGameSelectPanel);
            this.Controls.Add(this.uxSettingsGroup);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInterface";
            this.Text = "SimpleGridBasedGames";
            this.uxSettingsGroup.ResumeLayout(false);
            this.uxSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamePreview)).EndInit();
            this.uxGameSelectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSoundBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxColor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uxSettingsGroup;
        private System.Windows.Forms.Button uxDefaultSettings;
        private System.Windows.Forms.Button uxApplySettings;
        private System.Windows.Forms.PictureBox uxGamePreview;
        private System.Windows.Forms.Button uxLeftButton;
        private System.Windows.Forms.Button uxRightButton;
        private System.Windows.Forms.Button uxPlayButton;
        private System.Windows.Forms.Panel uxGameSelectPanel;
        private System.Windows.Forms.TrackBar uxSoundBar;
        private System.Windows.Forms.Label uxSoundLabel;
        private System.Windows.Forms.Label uxSettingsFileLabel;
        private System.Windows.Forms.Button uxSelectSettingsFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uxYValue;
        private System.Windows.Forms.NumericUpDown uxXValue;
        private System.Windows.Forms.Label uxByLabel;
        private System.Windows.Forms.ColorDialog uxColorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uxChangeColor2;
        private System.Windows.Forms.Button uxChangeColor1;
        private System.Windows.Forms.PictureBox uxColor2;
        private System.Windows.Forms.PictureBox uxColor1;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}

