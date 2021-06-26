
namespace TestCode5
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.txtNumOut = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGra = new System.Windows.Forms.TextBox();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "사용자 번호 : ";
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(117, 351);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(267, 21);
            this.txtPri.TabIndex = 49;
            // 
            // txtNumOut
            // 
            this.txtNumOut.Location = new System.Drawing.Point(117, 293);
            this.txtNumOut.Name = "txtNumOut";
            this.txtNumOut.Size = new System.Drawing.Size(267, 21);
            this.txtNumOut.TabIndex = 47;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(117, 322);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(267, 21);
            this.txtTax.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "세금 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "총사용금액 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(37, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "출력";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "종료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 42;
            this.button1.Text = "사용액 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtGra
            // 
            this.txtGra.Location = new System.Drawing.Point(117, 121);
            this.txtGra.Name = "txtGra";
            this.txtGra.Size = new System.Drawing.Size(267, 21);
            this.txtGra.TabIndex = 40;
            // 
            // txtUse
            // 
            this.txtUse.Location = new System.Drawing.Point(117, 152);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(267, 21);
            this.txtUse.TabIndex = 41;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(117, 89);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(267, 21);
            this.txtNum.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "등급(1~3) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "사용량(KHz) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "사용자 번호 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "입력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPri);
            this.Controls.Add(this.txtNumOut);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGra);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.TextBox txtNumOut;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGra;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

