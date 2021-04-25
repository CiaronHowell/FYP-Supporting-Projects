
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
            this.button1 = new System.Windows.Forms.Button();
            this._serialComPortTextBox = new System.Windows.Forms.TextBox();
            this._serialMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _startServerButton
            // 
            this._startServerButton.Location = new System.Drawing.Point(37, 27);
            this._startServerButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this._startServerButton.Name = "_startServerButton";
            this._startServerButton.Size = new System.Drawing.Size(81, 22);
            this._startServerButton.TabIndex = 0;
            this._startServerButton.Text = "Start Server";
            this._startServerButton.UseVisualStyleBackColor = true;
            this._startServerButton.Click += new System.EventHandler(this._startServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Received:";
            // 
            // _messageReceivedTextBox
            // 
            this._messageReceivedTextBox.Location = new System.Drawing.Point(37, 83);
            this._messageReceivedTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this._messageReceivedTextBox.Name = "_messageReceivedTextBox";
            this._messageReceivedTextBox.ReadOnly = true;
            this._messageReceivedTextBox.Size = new System.Drawing.Size(267, 92);
            this._messageReceivedTextBox.TabIndex = 2;
            this._messageReceivedTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Serial Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _serialComPortTextBox
            // 
            this._serialComPortTextBox.Location = new System.Drawing.Point(37, 219);
            this._serialComPortTextBox.Name = "_serialComPortTextBox";
            this._serialComPortTextBox.Size = new System.Drawing.Size(100, 23);
            this._serialComPortTextBox.TabIndex = 4;
            // 
            // _serialMessageTextBox
            // 
            this._serialMessageTextBox.Location = new System.Drawing.Point(37, 268);
            this._serialMessageTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this._serialMessageTextBox.Name = "_serialMessageTextBox";
            this._serialMessageTextBox.ReadOnly = true;
            this._serialMessageTextBox.Size = new System.Drawing.Size(267, 92);
            this._serialMessageTextBox.TabIndex = 6;
            this._serialMessageTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message Received:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 406);
            this.Controls.Add(this._serialMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._serialComPortTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._messageReceivedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._startServerButton);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Socket Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _startServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox _messageReceivedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _serialComPortTextBox;
        private System.Windows.Forms.RichTextBox _serialMessageTextBox;
        private System.Windows.Forms.Label label2;
    }
}

