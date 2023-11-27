namespace WinFormsAppGameMillioner
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
            components = new System.ComponentModel.Container();
            labelTimer = new Label();
            buttonAnswer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(203, 330);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(40, 20);
            labelTimer.TabIndex = 0;
           
            // 
            // buttonAnswer
            // 
            buttonAnswer.Location = new Point(380, 326);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(94, 29);
            buttonAnswer.TabIndex = 1;
            buttonAnswer.UseVisualStyleBackColor = true;
           
            // 
            // timer1
            // 
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnswer);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTimer;
        private Button buttonAnswer;
        private System.Windows.Forms.Timer timer1;
    }
}