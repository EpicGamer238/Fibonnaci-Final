namespace Fibonnaci_Final
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
            hScrollBar1 = new HScrollBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(9, 9);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(729, 17);
            hScrollBar1.TabIndex = 1;
            hScrollBar1.Value = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(label1);
            Controls.Add(hScrollBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private HScrollBar hScrollBar1;
        private Label label1;
    }
}