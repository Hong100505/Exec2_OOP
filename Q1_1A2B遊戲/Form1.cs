using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_1A2B遊戲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void stsrtButton_Click(object sender, EventArgs e)
		{
			int ans = 0;

			for (int i = 0; i < 1; i++)
			{


				Random random = new Random();
				int number = random.Next(0, 10000);
				string lenght = Convert.ToString(number);


				int numberOne = number / 1000 % 10;   //1
				int numberTwo = number / 100 % 10;
				int numberThree = number / 10 % 10; //123%10
				int numberFour = number / 1 % 10;   //4


				if (numberOne != numberTwo && numberOne != numberThree && numberOne != numberFour &&
					numberTwo != numberThree && numberTwo != numberFour &&
					numberThree != numberFour)
				{
					i++;
					ans = number;
				}
				else
				{
					i = -1;
				}
			}
			string ans1 = ans.ToString();
			answerLabel.Text = ans1;

		}

		private void confirmButton_Click(object sender, EventArgs e)
		{

			string C = textBox1.Text;
			string ans2  = answerLabel.Text;

			int[] answer = new int[] { ans2[0], ans2[1], ans2[2], ans2[3] };

			int[] userans = new int[] { C[0], C[1], C[2], C[3], };

			int B = 0;
			int A = 0;

			for (int i = 0; i < answer.Length; i++)
			{
				for (int k = 0; k < userans.Length; k++)
				{
					if (answer[i] == userans[k])
					{
						B++;
						if (i == k)
						{
							B = B - 1;
							A = A + 1;
						}


					}
				}
			}

			ansBox.Text += $"{A}A{B}B\r\n";
		}
	}
}
