namespace Q1_1A2B遊戲
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.answerLabel = new System.Windows.Forms.Label();
			this.stsrtButton = new System.Windows.Forms.Button();
			this.ansBox = new System.Windows.Forms.TextBox();
			this.confirmButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(79, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(127, 22);
			this.textBox1.TabIndex = 0;
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(272, 145);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(63, 12);
			this.answerLabel.TabIndex = 1;
			this.answerLabel.Text = "answerLabel";
			// 
			// stsrtButton
			// 
			this.stsrtButton.Location = new System.Drawing.Point(242, 21);
			this.stsrtButton.Name = "stsrtButton";
			this.stsrtButton.Size = new System.Drawing.Size(114, 40);
			this.stsrtButton.TabIndex = 2;
			this.stsrtButton.Text = "新遊戲";
			this.stsrtButton.UseVisualStyleBackColor = true;
			this.stsrtButton.Click += new System.EventHandler(this.stsrtButton_Click);
			// 
			// ansBox
			// 
			this.ansBox.Location = new System.Drawing.Point(79, 110);
			this.ansBox.Multiline = true;
			this.ansBox.Name = "ansBox";
			this.ansBox.Size = new System.Drawing.Size(127, 184);
			this.ansBox.TabIndex = 3;
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point(242, 67);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(114, 32);
			this.confirmButton.TabIndex = 4;
			this.confirmButton.Text = "確認";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 356);
			this.Controls.Add(this.confirmButton);
			this.Controls.Add(this.ansBox);
			this.Controls.Add(this.stsrtButton);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Button stsrtButton;
		private System.Windows.Forms.TextBox ansBox;
		private System.Windows.Forms.Button confirmButton;
	}
}

