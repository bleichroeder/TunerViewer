
namespace TunerViewer2
{
    partial class RemoteHostRequest
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
            this.RemoteHostRequestHostTextBox = new System.Windows.Forms.TextBox();
            this.RemoteHostRequestUserTextBox = new System.Windows.Forms.TextBox();
            this.RemoteHostRequestPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RemoteHostRequestConfirmButton = new System.Windows.Forms.Button();
            this.RemoteHostRequestCancelButton = new System.Windows.Forms.Button();
            this.RemoteHostRequestHostLabel = new System.Windows.Forms.Label();
            this.RemoteHostRequestUserLabel = new System.Windows.Forms.Label();
            this.RemoteHostRequestPasswordLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoteHostRequestHostTextBox
            // 
            this.RemoteHostRequestHostTextBox.Location = new System.Drawing.Point(99, 76);
            this.RemoteHostRequestHostTextBox.Name = "RemoteHostRequestHostTextBox";
            this.RemoteHostRequestHostTextBox.Size = new System.Drawing.Size(172, 20);
            this.RemoteHostRequestHostTextBox.TabIndex = 0;
            // 
            // RemoteHostRequestUserTextBox
            // 
            this.RemoteHostRequestUserTextBox.Location = new System.Drawing.Point(99, 112);
            this.RemoteHostRequestUserTextBox.Name = "RemoteHostRequestUserTextBox";
            this.RemoteHostRequestUserTextBox.Size = new System.Drawing.Size(172, 20);
            this.RemoteHostRequestUserTextBox.TabIndex = 1;
            // 
            // RemoteHostRequestPasswordTextBox
            // 
            this.RemoteHostRequestPasswordTextBox.Location = new System.Drawing.Point(99, 148);
            this.RemoteHostRequestPasswordTextBox.Name = "RemoteHostRequestPasswordTextBox";
            this.RemoteHostRequestPasswordTextBox.PasswordChar = '*';
            this.RemoteHostRequestPasswordTextBox.Size = new System.Drawing.Size(172, 20);
            this.RemoteHostRequestPasswordTextBox.TabIndex = 2;
            // 
            // RemoteHostRequestConfirmButton
            // 
            this.RemoteHostRequestConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RemoteHostRequestConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteHostRequestConfirmButton.Location = new System.Drawing.Point(230, 198);
            this.RemoteHostRequestConfirmButton.Name = "RemoteHostRequestConfirmButton";
            this.RemoteHostRequestConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.RemoteHostRequestConfirmButton.TabIndex = 3;
            this.RemoteHostRequestConfirmButton.Text = "Confirm";
            this.RemoteHostRequestConfirmButton.UseVisualStyleBackColor = true;
            this.RemoteHostRequestConfirmButton.Click += new System.EventHandler(this.RemoteHostRequestConfirmButton_Click);
            // 
            // RemoteHostRequestCancelButton
            // 
            this.RemoteHostRequestCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RemoteHostRequestCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoteHostRequestCancelButton.Location = new System.Drawing.Point(12, 198);
            this.RemoteHostRequestCancelButton.Name = "RemoteHostRequestCancelButton";
            this.RemoteHostRequestCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RemoteHostRequestCancelButton.TabIndex = 4;
            this.RemoteHostRequestCancelButton.Text = "Cancel";
            this.RemoteHostRequestCancelButton.UseVisualStyleBackColor = true;
            // 
            // RemoteHostRequestHostLabel
            // 
            this.RemoteHostRequestHostLabel.AutoSize = true;
            this.RemoteHostRequestHostLabel.Location = new System.Drawing.Point(37, 79);
            this.RemoteHostRequestHostLabel.Name = "RemoteHostRequestHostLabel";
            this.RemoteHostRequestHostLabel.Size = new System.Drawing.Size(60, 13);
            this.RemoteHostRequestHostLabel.TabIndex = 5;
            this.RemoteHostRequestHostLabel.Text = "Host Name";
            // 
            // RemoteHostRequestUserLabel
            // 
            this.RemoteHostRequestUserLabel.AutoSize = true;
            this.RemoteHostRequestUserLabel.Location = new System.Drawing.Point(64, 115);
            this.RemoteHostRequestUserLabel.Name = "RemoteHostRequestUserLabel";
            this.RemoteHostRequestUserLabel.Size = new System.Drawing.Size(29, 13);
            this.RemoteHostRequestUserLabel.TabIndex = 6;
            this.RemoteHostRequestUserLabel.Text = "User";
            // 
            // RemoteHostRequestPasswordLabel
            // 
            this.RemoteHostRequestPasswordLabel.AutoSize = true;
            this.RemoteHostRequestPasswordLabel.Location = new System.Drawing.Point(40, 151);
            this.RemoteHostRequestPasswordLabel.Name = "RemoteHostRequestPasswordLabel";
            this.RemoteHostRequestPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.RemoteHostRequestPasswordLabel.TabIndex = 7;
            this.RemoteHostRequestPasswordLabel.Text = "Password";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(68, 18);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(186, 13);
            this.MessageLabel.TabIndex = 8;
            this.MessageLabel.Text = "Unable to locate devices on this LAN.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = " Would you like to search using a remote host?";
            // 
            // RemoteHostRequest
            // 
            this.AcceptButton = this.RemoteHostRequestConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RemoteHostRequestCancelButton;
            this.ClientSize = new System.Drawing.Size(317, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.RemoteHostRequestPasswordLabel);
            this.Controls.Add(this.RemoteHostRequestUserLabel);
            this.Controls.Add(this.RemoteHostRequestHostLabel);
            this.Controls.Add(this.RemoteHostRequestCancelButton);
            this.Controls.Add(this.RemoteHostRequestConfirmButton);
            this.Controls.Add(this.RemoteHostRequestPasswordTextBox);
            this.Controls.Add(this.RemoteHostRequestUserTextBox);
            this.Controls.Add(this.RemoteHostRequestHostTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoteHostRequest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Host Request";
            this.Load += new System.EventHandler(this.RemoteHostRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemoteHostRequestHostTextBox;
        private System.Windows.Forms.TextBox RemoteHostRequestUserTextBox;
        private System.Windows.Forms.TextBox RemoteHostRequestPasswordTextBox;
        private System.Windows.Forms.Button RemoteHostRequestConfirmButton;
        private System.Windows.Forms.Button RemoteHostRequestCancelButton;
        private System.Windows.Forms.Label RemoteHostRequestHostLabel;
        private System.Windows.Forms.Label RemoteHostRequestUserLabel;
        private System.Windows.Forms.Label RemoteHostRequestPasswordLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label1;
    }
}