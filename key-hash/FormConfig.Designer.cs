namespace key_hash
{
    partial class FormConfig
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.editPreQues = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editPreAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editPostStr = new System.Windows.Forms.TextBox();
            this.btnRand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.editRandDigits = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.editSalt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editSalt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editSalt3 = new System.Windows.Forms.TextBox();
            this.editText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelExpect = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editRandDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "预设问题：";
            // 
            // editPreQues
            // 
            this.editPreQues.Location = new System.Drawing.Point(94, 10);
            this.editPreQues.Name = "editPreQues";
            this.editPreQues.Size = new System.Drawing.Size(557, 21);
            this.editPreQues.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "答案：";
            // 
            // editPreAns
            // 
            this.editPreAns.ForeColor = System.Drawing.Color.Red;
            this.editPreAns.Location = new System.Drawing.Point(94, 37);
            this.editPreAns.Name = "editPreAns";
            this.editPreAns.Size = new System.Drawing.Size(557, 21);
            this.editPreAns.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "追加字符串：";
            // 
            // editPostStr
            // 
            this.editPostStr.ForeColor = System.Drawing.Color.Red;
            this.editPostStr.Location = new System.Drawing.Point(94, 64);
            this.editPostStr.Name = "editPostStr";
            this.editPostStr.Size = new System.Drawing.Size(393, 21);
            this.editPostStr.TabIndex = 1;
            this.editPostStr.TextChanged += new System.EventHandler(this.editPostStr_TextChanged);
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(576, 63);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(75, 23);
            this.btnRand.TabIndex = 3;
            this.btnRand.Text = "随机生成";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "位";
            // 
            // editRandDigits
            // 
            this.editRandDigits.Location = new System.Drawing.Point(493, 63);
            this.editRandDigits.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editRandDigits.Name = "editRandDigits";
            this.editRandDigits.Size = new System.Drawing.Size(54, 21);
            this.editRandDigits.TabIndex = 5;
            this.editRandDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.editRandDigits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "盐1：";
            // 
            // editSalt1
            // 
            this.editSalt1.Location = new System.Drawing.Point(94, 91);
            this.editSalt1.Name = "editSalt1";
            this.editSalt1.Size = new System.Drawing.Size(557, 21);
            this.editSalt1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "盐2：";
            // 
            // editSalt2
            // 
            this.editSalt2.Location = new System.Drawing.Point(94, 118);
            this.editSalt2.Name = "editSalt2";
            this.editSalt2.Size = new System.Drawing.Size(557, 21);
            this.editSalt2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "盐3：";
            // 
            // editSalt3
            // 
            this.editSalt3.Location = new System.Drawing.Point(94, 145);
            this.editSalt3.Name = "editSalt3";
            this.editSalt3.Size = new System.Drawing.Size(557, 21);
            this.editSalt3.TabIndex = 1;
            // 
            // editText
            // 
            this.editText.ForeColor = System.Drawing.Color.Red;
            this.editText.Location = new System.Drawing.Point(94, 173);
            this.editText.Multiline = true;
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(557, 176);
            this.editText.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(47, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "明文：";
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(13, 413);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnSpeed.TabIndex = 7;
            this.btnSpeed.Text = "测速";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(94, 418);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(65, 12);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "测速结果。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "预计时间：";
            // 
            // labelExpect
            // 
            this.labelExpect.AutoSize = true;
            this.labelExpect.Location = new System.Drawing.Point(389, 418);
            this.labelExpect.Name = "labelExpect";
            this.labelExpect.Size = new System.Drawing.Size(11, 12);
            this.labelExpect.TabIndex = 10;
            this.labelExpect.Text = "?";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(576, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 448);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelExpect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.editText);
            this.Controls.Add(this.editRandDigits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editPostStr);
            this.Controls.Add(this.editSalt3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editSalt2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editSalt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editPreAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editPreQues);
            this.Controls.Add(this.label1);
            this.Name = "FormConfig";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.editRandDigits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editPreQues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editPreAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editPostStr;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown editRandDigits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editSalt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editSalt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editSalt3;
        private System.Windows.Forms.TextBox editText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelExpect;
        private System.Windows.Forms.Button btnSave;
    }
}

