namespace WP_2020_01_HW01_9A713032
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGo = new System.Windows.Forms.Button();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnGo.Location = new System.Drawing.Point(499, 106);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(95, 71);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "確認";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rTB
            // 
            this.rTB.Location = new System.Drawing.Point(218, 163);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(171, 96);
            this.rTB.TabIndex = 1;
            this.rTB.Text = "";
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(218, 106);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(171, 22);
            this.tB.TabIndex = 2;
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("新細明體", 16F);
            this.t1.Location = new System.Drawing.Point(341, 40);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 33);
            this.t1.TabIndex = 3;
            this.t1.Text = "請輸入你的名字:";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(192, 49);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 22);
            this.t2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
    }
}

