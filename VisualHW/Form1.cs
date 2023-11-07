using System;
using System.Linq;
using System.Windows.Forms;

namespace SortVisualization
{
    public partial class Form1 : Form
    {
        private int[] mainNumbers = new int[5];
        private int powerballNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePowerballNumbers()
        {
            Random random = new Random();
            powerballNumber = random.Next(1, 70);

            for (int i = 0; i < 5; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 70);
                } while (mainNumbers.Contains(number));
                mainNumbers[i] = number;
            }
            Array.Sort(mainNumbers);

            lblPowerballNumbers.Text = $"Main Numbers: {string.Join(", ", mainNumbers)}\nPowerball Number: {powerballNumber}";
        }

        private void CheckUserNumbers()
        {
            int[] userNumbers = textBoxUserInput.Text.Split(',').Select(int.Parse).ToArray();
            Array.Sort(userNumbers);

            bool isWinner = userNumbers.SequenceEqual(mainNumbers) && userNumbers.Contains(powerballNumber);

            if (isWinner)
            {
                lblResult.Text = "Congratulations! You've won!";
            }
            else
            {
                lblResult.Text = "Sorry, you didn't win. Try again!";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePowerballNumbers();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckUserNumbers();
        }
    }
}
