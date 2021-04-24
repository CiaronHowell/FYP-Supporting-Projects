
namespace ServerWithGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._startServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._messageReceivedTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _startServerButton
            // 
            this._startServerButton.Location = new System.Drawing.Point(68, 58);
            this._startServerButton.Name = "_startServerButton";
            this._startServerButton.Size = new System.Drawing.Size(150, 46);
            this._startServerButton.TabIndex = 0;
            this._startServerButton.Text = "Start Server";
            this._startServerButton.UseVisualStyleBackColor = true;
            this._startServerButton.Click += new System.EventHandler(this._startServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Received:";
            // 
            // _messageReceivedTextBox
            // 
            this._messageReceivedTextBox.Location = new System.Drawing.Point(68, 178);
            this._messageReceivedTextBox.Name = "_messageReceivedTextBox";
            this._messageReceivedTextBox.ReadOnly = true;
            this._messageReceivedTextBox.Size = new System.Drawing.Size(492, 192);
            this._messageReceivedTextBox.TabIndex = 2;
            this._messageReceivedTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._messageReceivedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._startServerButton);
            this.Name = "Form1";
            this.Text = "Socket Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _startServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox _messageReceivedTextBox;
    }
}

