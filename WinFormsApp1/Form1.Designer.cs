namespace WinFormsApp1
{
    partial class frmMain
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
            btnhello = new Button();
            lblStatus = new Label();
            btnshow = new Button();
            btnclose = new Button();
            SuspendLayout();
            // 
            // btnhello
            // 
            btnhello.Location = new Point(185, 135);
            btnhello.Name = "btnhello";
            btnhello.Size = new Size(216, 107);
            btnhello.TabIndex = 2;
            btnhello.Text = "Hello button";
            btnhello.UseVisualStyleBackColor = true;
            btnhello.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Location = new Point(48, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(279, 109);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "LABEL1";
            lblStatus.Click += label1_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(-4, 135);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(193, 107);
            btnshow.TabIndex = 1;
            btnshow.Text = "show/hide";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.ForeColor = SystemColors.ControlText;
            btnclose.Location = new Point(516, -2);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(285, 124);
            btnclose.TabIndex = 3;
            btnclose.Text = "close program button";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclose);
            Controls.Add(btnshow);
            Controls.Add(lblStatus);
            Controls.Add(btnhello);
            Name = "frmMain";
            Text = "Our first program";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnhello;
        private Label lblStatus;
        private Button btnshow;
        private Button btnclose;
    }
}
