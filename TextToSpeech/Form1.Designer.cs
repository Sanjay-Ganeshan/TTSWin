namespace TextToSpeech
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
            this.txtFullText = new System.Windows.Forms.TextBox();
            this.lblPasteHere = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTextFeeder = new System.Windows.Forms.Label();
            this.btnStartSpeech = new System.Windows.Forms.Button();
            this.sliderSpeedControl = new System.Windows.Forms.TrackBar();
            this.lblSpeedBar = new System.Windows.Forms.Label();
            this.cbVoiceSelect = new System.Windows.Forms.ComboBox();
            this.lblVoiceChoose = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.ProgressBar();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSpeedControl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullText
            // 
            this.txtFullText.Location = new System.Drawing.Point(81, 70);
            this.txtFullText.Multiline = true;
            this.txtFullText.Name = "txtFullText";
            this.txtFullText.Size = new System.Drawing.Size(1000, 345);
            this.txtFullText.TabIndex = 0;
            // 
            // lblPasteHere
            // 
            this.lblPasteHere.AutoSize = true;
            this.lblPasteHere.Location = new System.Drawing.Point(477, 50);
            this.lblPasteHere.Name = "lblPasteHere";
            this.lblPasteHere.Size = new System.Drawing.Size(114, 17);
            this.lblPasteHere.TabIndex = 1;
            this.lblPasteHere.Text = "Paste Text Here:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Motorwerk", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(293, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(467, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Text To Speech Converter";
            // 
            // lblTextFeeder
            // 
            this.lblTextFeeder.AutoSize = true;
            this.lblTextFeeder.Font = new System.Drawing.Font("Motorwerk", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFeeder.Location = new System.Drawing.Point(620, 434);
            this.lblTextFeeder.Name = "lblTextFeeder";
            this.lblTextFeeder.Size = new System.Drawing.Size(461, 29);
            this.lblTextFeeder.TabIndex = 3;
            this.lblTextFeeder.Text = "Words will appear here";
            // 
            // btnStartSpeech
            // 
            this.btnStartSpeech.Location = new System.Drawing.Point(463, 421);
            this.btnStartSpeech.Name = "btnStartSpeech";
            this.btnStartSpeech.Size = new System.Drawing.Size(151, 62);
            this.btnStartSpeech.TabIndex = 4;
            this.btnStartSpeech.Text = "Start Speaking";
            this.btnStartSpeech.UseVisualStyleBackColor = true;
            this.btnStartSpeech.Click += new System.EventHandler(this.btnStartSpeech_Click);
            // 
            // sliderSpeedControl
            // 
            this.sliderSpeedControl.Location = new System.Drawing.Point(81, 427);
            this.sliderSpeedControl.Minimum = -10;
            this.sliderSpeedControl.Name = "sliderSpeedControl";
            this.sliderSpeedControl.Size = new System.Drawing.Size(365, 56);
            this.sliderSpeedControl.TabIndex = 5;
            this.sliderSpeedControl.TickFrequency = 2;
            this.sliderSpeedControl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderSpeedControl.ValueChanged += new System.EventHandler(this.sliderSpeedControl_ValueChanged);
            // 
            // lblSpeedBar
            // 
            this.lblSpeedBar.AutoSize = true;
            this.lblSpeedBar.Location = new System.Drawing.Point(22, 444);
            this.lblSpeedBar.Name = "lblSpeedBar";
            this.lblSpeedBar.Size = new System.Drawing.Size(53, 17);
            this.lblSpeedBar.TabIndex = 6;
            this.lblSpeedBar.Text = "Speed:";
            // 
            // cbVoiceSelect
            // 
            this.cbVoiceSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbVoiceSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVoiceSelect.FormattingEnabled = true;
            this.cbVoiceSelect.Location = new System.Drawing.Point(81, 489);
            this.cbVoiceSelect.Name = "cbVoiceSelect";
            this.cbVoiceSelect.Size = new System.Drawing.Size(365, 24);
            this.cbVoiceSelect.TabIndex = 7;
            this.cbVoiceSelect.SelectedIndexChanged += new System.EventHandler(this.cbVoiceSelect_SelectedIndexChanged);
            // 
            // lblVoiceChoose
            // 
            this.lblVoiceChoose.AutoSize = true;
            this.lblVoiceChoose.Location = new System.Drawing.Point(22, 492);
            this.lblVoiceChoose.Name = "lblVoiceChoose";
            this.lblVoiceChoose.Size = new System.Drawing.Size(47, 17);
            this.lblVoiceChoose.TabIndex = 8;
            this.lblVoiceChoose.Text = "Voice:";
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(25, 594);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbLeft.Size = new System.Drawing.Size(1056, 23);
            this.pbLeft.TabIndex = 9;
            // 
            // startTimer
            // 
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Motorwerk", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(524, 562);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(32, 29);
            this.lblCounter.TabIndex = 10;
            this.lblCounter.Text = "5";
            this.lblCounter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 629);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.lblVoiceChoose);
            this.Controls.Add(this.cbVoiceSelect);
            this.Controls.Add(this.lblSpeedBar);
            this.Controls.Add(this.sliderSpeedControl);
            this.Controls.Add(this.btnStartSpeech);
            this.Controls.Add(this.lblTextFeeder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPasteHere);
            this.Controls.Add(this.txtFullText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderSpeedControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullText;
        private System.Windows.Forms.Label lblPasteHere;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTextFeeder;
        private System.Windows.Forms.Button btnStartSpeech;
        private System.Windows.Forms.TrackBar sliderSpeedControl;
        private System.Windows.Forms.Label lblSpeedBar;
        private System.Windows.Forms.ComboBox cbVoiceSelect;
        private System.Windows.Forms.Label lblVoiceChoose;
        private System.Windows.Forms.ProgressBar pbLeft;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Label lblCounter;
    }
}

