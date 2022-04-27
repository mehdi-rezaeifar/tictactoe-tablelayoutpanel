using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tak_toe
{
    public partial class Form1 : Form
    {
        Button[,] dokmeha;
        int ply; 
        public Form1()
        {
            InitializeComponent();


            dokmeha = new Button[3, 3];
            b_button();

            new_game();
        }
        private void b_button()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i,j] = new Button();
                    dokmeha[i,j].Click += new EventHandler(button1_Click);
                    dokmeha[i, j].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                    tableLayoutPanel2.Controls.Add(dokmeha[i, j], i, j);
                }
            }
        }
        private void new_game()
        {
            ply = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.Green;
                    this_button.BackColor = Color.LightGreen;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
                check_game();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_game();
        }
        
        private void check_game()
        {
            
            if (dokmeha[1, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "X" && dokmeha[2, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 0].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 1].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 2].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "X" && dokmeha[1, 1].Text == "X" && dokmeha[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره 1 برنده شد");
                new_game();
            }


            if (dokmeha[0, 0].Text == "O" && dokmeha[0, 1].Text == "O" && dokmeha[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[1, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[2, 0].Text == "O" && dokmeha[2, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 0].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 1].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 1].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 2].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 2].Text == "O" && dokmeha[1, 1].Text == "O" && dokmeha[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره 2 برنده شد");
                new_game();
            }
            if (dokmeha[0, 0].Text != "" && dokmeha[0, 1].Text != "" && dokmeha[0, 2].Text != "" &&
               dokmeha[1, 0].Text != "" && dokmeha[1, 1].Text != "" && dokmeha[1, 2].Text != "" &&
               dokmeha[2, 0].Text != "" && dokmeha[2, 1].Text != "" && dokmeha[2, 2].Text != "")
            {
                MessageBox.Show("مساوی");
                new_game();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
