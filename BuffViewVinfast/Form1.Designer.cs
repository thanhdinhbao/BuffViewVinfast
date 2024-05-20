
namespace BuffViewVinfast
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
            this.btnStartView = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radView = new System.Windows.Forms.RadioButton();
            this.radShare = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartView
            // 
            this.btnStartView.Location = new System.Drawing.Point(115, 209);
            this.btnStartView.Name = "btnStartView";
            this.btnStartView.Size = new System.Drawing.Size(89, 51);
            this.btnStartView.TabIndex = 0;
            this.btnStartView.Text = "Start";
            this.btnStartView.UseVisualStyleBackColor = true;
            this.btnStartView.Click += new System.EventHandler(this.btnStartView_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(47, 83);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(194, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.Checked = true;
            this.radView.Location = new System.Drawing.Point(47, 164);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(48, 17);
            this.radView.TabIndex = 3;
            this.radView.TabStop = true;
            this.radView.Text = "View";
            this.radView.UseVisualStyleBackColor = true;
            // 
            // radShare
            // 
            this.radShare.AutoSize = true;
            this.radShare.Location = new System.Drawing.Point(188, 164);
            this.radShare.Name = "radShare";
            this.radShare.Size = new System.Drawing.Size(53, 17);
            this.radShare.TabIndex = 4;
            this.radShare.Text = "Share";
            this.radShare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buff View Vinfast by ThanhDB";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Location = new System.Drawing.Point(32, 251);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(0, 13);
            this.lblTimeRemain.TabIndex = 6;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(47, 123);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(194, 20);
            this.txtLink.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Link:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblTimeRemain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radShare);
            this.Controls.Add(this.radView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnStartView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buff View Vinfast Camp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartView;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.RadioButton radShare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

