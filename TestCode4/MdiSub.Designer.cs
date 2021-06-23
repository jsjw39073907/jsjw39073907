
namespace study
{
    partial class btnHi
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
            this.btnHi1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHi1
            // 
            this.btnHi1.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHi1.Location = new System.Drawing.Point(12, 12);
            this.btnHi1.Name = "btnHi1";
            this.btnHi1.Size = new System.Drawing.Size(397, 375);
            this.btnHi1.TabIndex = 0;
            this.btnHi1.Text = "안녕";
            this.btnHi1.UseVisualStyleBackColor = true;
            // 
            // btnHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 399);
            this.Controls.Add(this.btnHi1);
            this.Name = "btnHi";
            this.Text = "MdiSub";
            this.Load += new System.EventHandler(this.BtnHi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHi1;
    }
}