using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2四顆骰子遊戲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			int ans = 0;
			int numberOne = 0;
			int numberTwo = 0;
			int numberThree = 0;
			int numberFour = 0;

			for (int i = 0; i < 1; i++)
			{
				Random random = new Random();

				numberOne = random.Next(1, 7);
				numberTwo = random.Next(1, 7);
				numberThree = random.Next(1, 7);
				numberFour = random.Next(1, 7);

				ans = numberOne * 1000 + numberTwo * 100 + numberThree * 10 + numberFour;

				if (numberOne == numberTwo || numberOne == numberThree || numberOne == numberFour ||
				   numberTwo == numberThree || numberTwo == numberFour ||
				   numberThree == numberFour)
				{
					i++;
				}
				else 
				{
					i = -1;
				}
			}

			ansLabel.Text = ans.ToString();
			int result = 0;



			
			if (numberOne == numberTwo) { result = numberFour + numberThree; }
			if (numberOne == numberThree) { result = numberFour + numberTwo; }
			if (numberOne == numberFour) { result = numberTwo + numberThree; }
			if (numberTwo == numberThree) { result = numberFour + numberOne; }
			if (numberTwo == numberFour) { result = numberOne + numberThree; }
			if (numberThree == numberFour) { result = numberOne + numberTwo; }

			resultLabel.Text = result.ToString();
		}
	}
}
