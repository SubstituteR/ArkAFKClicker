namespace KlickerGUI
{
    partial class MainUI
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
            this.FoundgameLabel = new System.Windows.Forms.Label();
            this.ClickingLabel = new System.Windows.Forms.Label();
            this.GamefocusedLabel = new System.Windows.Forms.Label();
            this.FoundgamestatusLabel = new System.Windows.Forms.Label();
            this.GamefocusedstatusLabel = new System.Windows.Forms.Label();
            this.ClickingstatusLabel = new System.Windows.Forms.Label();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.GamesearchTimer = new System.Windows.Forms.Timer(this.components);
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.HotkeyenabledLabel = new System.Windows.Forms.Label();
            this.HotkeyenabledstatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FoundgameLabel
            // 
            this.FoundgameLabel.AutoSize = true;
            this.FoundgameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundgameLabel.Location = new System.Drawing.Point(12, 9);
            this.FoundgameLabel.Name = "FoundgameLabel";
            this.FoundgameLabel.Size = new System.Drawing.Size(107, 20);
            this.FoundgameLabel.TabIndex = 0;
            this.FoundgameLabel.Text = "Found Game:";
            // 
            // ClickingLabel
            // 
            this.ClickingLabel.AutoSize = true;
            this.ClickingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickingLabel.Location = new System.Drawing.Point(12, 69);
            this.ClickingLabel.Name = "ClickingLabel";
            this.ClickingLabel.Size = new System.Drawing.Size(67, 20);
            this.ClickingLabel.TabIndex = 1;
            this.ClickingLabel.Text = "Clicking:";
            // 
            // GamefocusedLabel
            // 
            this.GamefocusedLabel.AutoSize = true;
            this.GamefocusedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamefocusedLabel.Location = new System.Drawing.Point(12, 49);
            this.GamefocusedLabel.Name = "GamefocusedLabel";
            this.GamefocusedLabel.Size = new System.Drawing.Size(159, 20);
            this.GamefocusedLabel.TabIndex = 2;
            this.GamefocusedLabel.Text = "Game is Foreground:";
            // 
            // FoundgamestatusLabel
            // 
            this.FoundgamestatusLabel.AutoSize = true;
            this.FoundgamestatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundgamestatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FoundgamestatusLabel.Location = new System.Drawing.Point(197, 9);
            this.FoundgamestatusLabel.Name = "FoundgamestatusLabel";
            this.FoundgamestatusLabel.Size = new System.Drawing.Size(19, 20);
            this.FoundgamestatusLabel.TabIndex = 3;
            this.FoundgamestatusLabel.Text = "✖️";
            // 
            // GamefocusedstatusLabel
            // 
            this.GamefocusedstatusLabel.AutoSize = true;
            this.GamefocusedstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamefocusedstatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.GamefocusedstatusLabel.Location = new System.Drawing.Point(197, 49);
            this.GamefocusedstatusLabel.Name = "GamefocusedstatusLabel";
            this.GamefocusedstatusLabel.Size = new System.Drawing.Size(19, 20);
            this.GamefocusedstatusLabel.TabIndex = 4;
            this.GamefocusedstatusLabel.Text = "✖️";
            // 
            // ClickingstatusLabel
            // 
            this.ClickingstatusLabel.AutoSize = true;
            this.ClickingstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickingstatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ClickingstatusLabel.Location = new System.Drawing.Point(197, 69);
            this.ClickingstatusLabel.Name = "ClickingstatusLabel";
            this.ClickingstatusLabel.Size = new System.Drawing.Size(19, 20);
            this.ClickingstatusLabel.TabIndex = 5;
            this.ClickingstatusLabel.Text = "✖️";
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Enabled = false;
            this.ConfigureButton.Location = new System.Drawing.Point(16, 92);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(197, 23);
            this.ConfigureButton.TabIndex = 6;
            this.ConfigureButton.Text = "Configure";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // GamesearchTimer
            // 
            this.GamesearchTimer.Enabled = true;
            this.GamesearchTimer.Interval = 1000;
            this.GamesearchTimer.Tick += new System.EventHandler(this.GamesearchTimer_Tick);
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 10;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // HotkeyenabledLabel
            // 
            this.HotkeyenabledLabel.AutoSize = true;
            this.HotkeyenabledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyenabledLabel.Location = new System.Drawing.Point(12, 29);
            this.HotkeyenabledLabel.Name = "HotkeyenabledLabel";
            this.HotkeyenabledLabel.Size = new System.Drawing.Size(126, 20);
            this.HotkeyenabledLabel.TabIndex = 7;
            this.HotkeyenabledLabel.Text = "Hotkey Enabled:";
            // 
            // HotkeyenabledstatusLabel
            // 
            this.HotkeyenabledstatusLabel.AutoSize = true;
            this.HotkeyenabledstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyenabledstatusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.HotkeyenabledstatusLabel.Location = new System.Drawing.Point(197, 29);
            this.HotkeyenabledstatusLabel.Name = "HotkeyenabledstatusLabel";
            this.HotkeyenabledstatusLabel.Size = new System.Drawing.Size(19, 20);
            this.HotkeyenabledstatusLabel.TabIndex = 8;
            this.HotkeyenabledstatusLabel.Text = "✖️";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 127);
            this.Controls.Add(this.HotkeyenabledstatusLabel);
            this.Controls.Add(this.HotkeyenabledLabel);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.ClickingstatusLabel);
            this.Controls.Add(this.GamefocusedstatusLabel);
            this.Controls.Add(this.FoundgamestatusLabel);
            this.Controls.Add(this.GamefocusedLabel);
            this.Controls.Add(this.ClickingLabel);
            this.Controls.Add(this.FoundgameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoundgameLabel;
        private System.Windows.Forms.Label ClickingLabel;
        private System.Windows.Forms.Label GamefocusedLabel;
        private System.Windows.Forms.Label FoundgamestatusLabel;
        private System.Windows.Forms.Label GamefocusedstatusLabel;
        private System.Windows.Forms.Label ClickingstatusLabel;
        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Timer GamesearchTimer;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label HotkeyenabledLabel;
        private System.Windows.Forms.Label HotkeyenabledstatusLabel;
    }
}