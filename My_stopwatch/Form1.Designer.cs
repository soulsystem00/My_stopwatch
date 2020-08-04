namespace My_stopwatch
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
            this.txt_hour = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_sec = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_hour
            // 
            this.txt_hour.Location = new System.Drawing.Point(90, 78);
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(100, 25);
            this.txt_hour.TabIndex = 0;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(242, 80);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(100, 25);
            this.txt_min.TabIndex = 1;
            // 
            // txt_sec
            // 
            this.txt_sec.Location = new System.Drawing.Point(402, 80);
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.Size = new System.Drawing.Size(100, 25);
            this.txt_sec.TabIndex = 2;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(561, 82);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(561, 82);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "end";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_sec);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_hour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hour;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_sec;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
    }
}

