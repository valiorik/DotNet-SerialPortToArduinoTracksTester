namespace SerialPortToArduinoTracksTester
{
    partial class ControllerForm
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
            this.ComPortListConnectButton = new System.Windows.Forms.Button();
            this.RightTrackBar = new System.Windows.Forms.TrackBar();
            this.LeftTrackBar = new System.Windows.Forms.TrackBar();
            this.ComPortListComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortListRefreshButton = new System.Windows.Forms.Button();
            this.TracksStopButton = new System.Windows.Forms.Button();
            this.LogListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ComPortListConnectButton
            // 
            this.ComPortListConnectButton.Location = new System.Drawing.Point(220, 13);
            this.ComPortListConnectButton.Name = "ComPortListConnectButton";
            this.ComPortListConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ComPortListConnectButton.TabIndex = 0;
            this.ComPortListConnectButton.Text = "Connect";
            this.ComPortListConnectButton.UseVisualStyleBackColor = true;
            this.ComPortListConnectButton.Click += new System.EventHandler(this.ComPortListConnectButton_Click);
            // 
            // RightTrackBar
            // 
            this.RightTrackBar.Location = new System.Drawing.Point(138, 58);
            this.RightTrackBar.Maximum = 255;
            this.RightTrackBar.Minimum = -255;
            this.RightTrackBar.Name = "RightTrackBar";
            this.RightTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightTrackBar.Size = new System.Drawing.Size(45, 303);
            this.RightTrackBar.TabIndex = 1;
            this.RightTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // LeftTrackBar
            // 
            this.LeftTrackBar.Location = new System.Drawing.Point(12, 58);
            this.LeftTrackBar.Maximum = 255;
            this.LeftTrackBar.Minimum = -255;
            this.LeftTrackBar.Name = "LeftTrackBar";
            this.LeftTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftTrackBar.Size = new System.Drawing.Size(45, 303);
            this.LeftTrackBar.TabIndex = 2;
            this.LeftTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // ComPortListComboBox
            // 
            this.ComPortListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortListComboBox.Location = new System.Drawing.Point(12, 14);
            this.ComPortListComboBox.Name = "ComPortListComboBox";
            this.ComPortListComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComPortListComboBox.Sorted = true;
            this.ComPortListComboBox.TabIndex = 3;
            // 
            // ComPortListRefreshButton
            // 
            this.ComPortListRefreshButton.Location = new System.Drawing.Point(139, 13);
            this.ComPortListRefreshButton.Name = "ComPortListRefreshButton";
            this.ComPortListRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.ComPortListRefreshButton.TabIndex = 4;
            this.ComPortListRefreshButton.Text = "Refresh";
            this.ComPortListRefreshButton.UseVisualStyleBackColor = true;
            this.ComPortListRefreshButton.Click += new System.EventHandler(this.comPortListRefreshButton_Click);
            // 
            // TracksStopButton
            // 
            this.TracksStopButton.Location = new System.Drawing.Point(58, 198);
            this.TracksStopButton.Name = "TracksStopButton";
            this.TracksStopButton.Size = new System.Drawing.Size(75, 23);
            this.TracksStopButton.TabIndex = 5;
            this.TracksStopButton.Text = "Stop";
            this.TracksStopButton.UseVisualStyleBackColor = true;
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Items.AddRange(new object[] {
            "Log:"});
            this.LogListBox.Location = new System.Drawing.Point(189, 46);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(654, 498);
            this.LogListBox.TabIndex = 6;
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 552);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.TracksStopButton);
            this.Controls.Add(this.ComPortListRefreshButton);
            this.Controls.Add(this.ComPortListComboBox);
            this.Controls.Add(this.LeftTrackBar);
            this.Controls.Add(this.RightTrackBar);
            this.Controls.Add(this.ComPortListConnectButton);
            this.Name = "ControllerForm";
            this.Text = "Serial Port To Arduino Tracks Tester";
            this.Load += new System.EventHandler(this.ControllerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComPortListConnectButton;
        private System.Windows.Forms.TrackBar RightTrackBar;
        private System.Windows.Forms.TrackBar LeftTrackBar;
        private System.Windows.Forms.ComboBox ComPortListComboBox;
        private System.Windows.Forms.Button ComPortListRefreshButton;
        private System.Windows.Forms.Button TracksStopButton;
        private System.Windows.Forms.ListBox LogListBox;
    }
}

