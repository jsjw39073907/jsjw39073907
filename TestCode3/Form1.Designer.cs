
namespace TestCode3
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
            this.labelFN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancof = new System.Windows.Forms.Button();
            this.btnCoco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJui = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCoff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.labelFN.ForeColor = System.Drawing.Color.Red;
            this.labelFN.Location = new System.Drawing.Point(201, 379);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(0, 27);
            this.labelFN.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(525, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "\\700원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(287, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "\\300원";
            // 
            // btnCancof
            // 
            this.btnCancof.Location = new System.Drawing.Point(444, 305);
            this.btnCancof.Name = "btnCancof";
            this.btnCancof.Size = new System.Drawing.Size(75, 23);
            this.btnCancof.TabIndex = 24;
            this.btnCancof.Text = "캔커피";
            this.btnCancof.UseVisualStyleBackColor = true;
            this.btnCancof.Click += new System.EventHandler(this.btnCancof_Click);
            // 
            // btnCoco
            // 
            this.btnCoco.Location = new System.Drawing.Point(206, 305);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(75, 23);
            this.btnCoco.TabIndex = 23;
            this.btnCoco.Text = "코코아";
            this.btnCoco.UseVisualStyleBackColor = true;
            this.btnCoco.Click += new System.EventHandler(this.btnCoco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(525, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "\\500원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(287, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "\\200원";
            // 
            // btnJui
            // 
            this.btnJui.Location = new System.Drawing.Point(444, 227);
            this.btnJui.Name = "btnJui";
            this.btnJui.Size = new System.Drawing.Size(75, 23);
            this.btnJui.TabIndex = 20;
            this.btnJui.Text = "음료수";
            this.btnJui.UseVisualStyleBackColor = true;
            this.btnJui.Click += new System.EventHandler(this.btnJui_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(227, 131);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(308, 21);
            this.txtCash.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "금액";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(541, 131);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 23);
            this.btnCash.TabIndex = 17;
            this.btnCash.Text = "투입";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCoff
            // 
            this.btnCoff.Location = new System.Drawing.Point(206, 227);
            this.btnCoff.Name = "btnCoff";
            this.btnCoff.Size = new System.Drawing.Size(75, 23);
            this.btnCoff.TabIndex = 16;
            this.btnCoff.Text = "커피";
            this.btnCoff.UseVisualStyleBackColor = true;
            this.btnCoff.Click += new System.EventHandler(this.btnCoff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(175, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "의료정보과에서 운영하는 자판기 입니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancof);
            this.Controls.Add(this.btnCoco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJui);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCoff);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancof;
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJui;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCoff;
        private System.Windows.Forms.Label label1;
    }
}

