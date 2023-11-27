namespace WinFormsAppGameMillioner
{
    partial class PhoneFriendForm
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
            labelResponse = new Label();
            SuspendLayout();
            // 
            // labelResponse
            // 
            labelResponse.AutoSize = true;
            labelResponse.Location = new Point(329, 174);
            labelResponse.Name = "labelResponse";
            labelResponse.Size = new Size(50, 20);
            labelResponse.TabIndex = 0;
            labelResponse.Text = "label1";
            labelResponse.Click += labelResponse_Click;
            // 
            // PhoneFriendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResponse);
            Name = "PhoneFriendForm";
            Text = "PhoneFriendForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResponse;
    }
}