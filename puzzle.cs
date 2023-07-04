using System;
using System.Windows.Forms;

public class Puzzle : Form
{
    private Button b1, b2, b3, b4, b5, b6, b7, b8, b9, next;

    public Puzzle()
    {
        Text = "Puzzle Game - JavaTpoint";
        b1 = new Button { Text = "1", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(10, 30) };
        b2 = new Button { Text = " ", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(70, 30) };
        b3 = new Button { Text = "3", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(130, 30) };
        b4 = new Button { Text = "4", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(10, 80) };
        b5 = new Button { Text = "5", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(70, 80) };
        b6 = new Button { Text = "6", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(130, 80) };
        b7 = new Button { Text = "7", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(10, 130) };
        b8 = new Button { Text = "8", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(70, 130) };
        b9 = new Button { Text = "2", Size = new System.Drawing.Size(50, 40), Location = new System.Drawing.Point(130, 130) };
        next = new Button { Text = "next", Size = new System.Drawing.Size(100, 40), Location = new System.Drawing.Point(70, 200) };

        Controls.Add(b1);
        Controls.Add(b2);
        Controls.Add(b3);
        Controls.Add(b4);
        Controls.Add(b5);
        Controls.Add(b6);
        Controls.Add(b7);
        Controls.Add(b8);
        Controls.Add(b9);
        Controls.Add(next);

        b1.Click += Button_Click;
        b2.Click += Button_Click;
        b3.Click += Button_Click;
        b4.Click += Button_Click;
        b5.Click += Button_Click;
        b6.Click += Button_Click;
        b7.Click += Button_Click;
        b8.Click += Button_Click;
        b9.Click += Button_Click;
        next.Click += Button_Click;

        next.BackColor = System.Drawing.Color.Black;
        next.ForeColor = System.Drawing.Color.Green;
        Size = new System.Drawing.Size(250, 300);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Show();
    }

    private void Button_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (button == next)
        {
            string s = b4.Text;
            b4.Text = b9.Text;
            b9.Text = s;
            s = b1.Text;
            b1.Text = b5.Text;
            b5.Text = s;
            s = b2.Text;
            b2.Text = b7.Text;
            b7.Text = s;
        }

        if (button == b1)
        {
            string s = b1.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b1.Text = " ";
            }
            else if (b4.Text == " ")
            {
                b4.Text = s;
                b1.Text = " ";
            }
        }

        if (button == b3)
        {
            string s = b3.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b3.Text = " ";
            }
            else if (b6.Text == " ")
            {
                b6.Text = s;
                b3.Text = " ";
            }
        }

        if (button == b2)
        {
            string s = b2.Text;
            if (b1.Text == " ")
            {
                b1.Text = s;
                b2.Text = " ";
            }
            else if (b3.Text == " ")
            {
                b3.Text = s;
                b2.Text = " ";
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b2.Text = " ";
            }
        }

        if (button == b4)
        {
            string s = b4.Text;
            if (b1.Text == " ")
            {
                b1.Text = s;
                b4.Text = " ";
            }
            else if (b7.Text == " ")
            {
                b7.Text = s;
                b4.Text = " ";
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b4.Text = " ";
            }
        }

        if (button == b5)
        {
            string s = b5.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b5.Text = " ";
            }
            else if (b4.Text == " ")
            {
                b4.Text = s;
                b5.Text = " ";
            }
            else if (b6.Text == " ")
            {
                b6.Text = s;
                b5.Text = " ";
            }
            else if (b8.Text == " ")
            {
                b8.Text = s;
                b5.Text = " ";
            }
        }

        if (button == b6)
        {
            string s = b6.Text;
            if (b9.Text == " ")
            {
                b9.Text = s;
                b6.Text = " ";
            }
            else if (b3.Text == " ")
            {
                b3.Text = s;
                b6.Text = " ";
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b6.Text = " ";
            }
        }

        if (button == b7)
        {
            string s = b7.Text;
            if (b4.Text == " ")
            {
                b4.Text = s;
                b7.Text = " ";
            }
            else if (b8.Text == " ")
            {
                b8.Text = s;
                b7.Text = " ";
            }
        }

        if (button == b8)
        {
            string s = b8.Text;
            if (b7.Text == " ")
            {
                b7.Text = s;
                b8.Text = " ";
            }
            else if (b9.Text == " ")
            {
                b9.Text = s;
                b8.Text = " ";
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b8.Text = " ";
            }
        }

        if (button == b9)
        {
            string s = b9.Text;
            if (b6.Text == " ")
            {
                b6.Text = s;
                b9.Text = " ";
            }
            else if (b8.Text == " ")
            {
                b8.Text = s;
                b9.Text = " ";
            }

            if (b1.Text == "1" && b2.Text == "2" && b3.Text == "3" && b4.Text == "4" && b5.Text == "5" && b6.Text == "6" && b7.Text == "7" && b8.Text == "8" && b9.Text == " ")
            {
                MessageBox.Show("!!!you won!!!");
            }
        }
    }

    public static void Main()
    {
        Application.Run(new Puzzle());
    }
}
