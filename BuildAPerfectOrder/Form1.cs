using System;
using System.Windows.Forms;

namespace BuildAPerfectOrder
{
    public partial class Form1 : Form
    {

        public Int64 ChickenCount = 8;
        public Int64 SausageCount = 8;
        public Int64 BiscutCount = 64;
        public Int64 Score = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Chicken1_Click(object sender, EventArgs e)
        {

            ChickenSelected();

        }

        private void Chicken2_Click(object sender, EventArgs e)
        {

            ChickenSelected();

        }

        private void Chicken3_Click(object sender, EventArgs e)
        {

            ChickenSelected();

        }

        private void Biscut1_Click(object sender, EventArgs e)
        {

            BiscutSelected();

        }

        private void ChickenSelected()
        {

            if (ChickenCount == 0 )
            {

                MessageBox.Show("You need to make more chicken!");
                return;

            }

            if (Biscut.Visible != true)
            {

                MessageBox.Show("You need a Biscut, Bun, Muffin, or Griddle before this!");
                return;

            }

                ChickenCount = ChickenCount - 1;

            MessageBox.Show(string.Format("You selected Chicken. You have {0} left.", ChickenCount), "Chicken", MessageBoxButtons.OK);

            if (Biscut.Visible == true)
            {

                ChickenBiscut.Visible = true;
                Biscut.Visible = false;

            }

        }

        private void BiscutSelected ()
        {

            if (Biscut.Visible != true)
            {

                Biscut.Visible = true;

                BiscutCount = BiscutCount - 1;

                MessageBox.Show(string.Format("You selected Biscut. You have {0} left.", BiscutCount), "Biscuts", MessageBoxButtons.OK);

            }

        }

        private void ServeButton_Click(object sender, EventArgs e)
        {

            switch(Order1.Text)
            {

                case "Chicken Biscut":
                    if (ChickenBiscut.Visible == true)
                    {

                        MessageBox.Show("Order Correct!");
                        Score += 1;
                        return;

                    }
                    else
                    {
                        
                        MessageBox.Show("Order Incorrect!");
                        Score = Score - 1;
                        return;

                    }

            }

        }

    }

}
