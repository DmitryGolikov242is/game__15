using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace game15
{
    public class Class1
    {
        public static void button_Click(object sender, EventArgs e)
        {
            move(((Button)sender).Text);
            Class2.visual();
            Program.Win.render();
            if (Class2.check())
            {
                MessageBox.Show("Игра закончена!", "ПОБЕДА!");
            };
        }

        public static  void move(String btn)
        {
            int pos;

            for (pos = 0; pos < 15; pos++)
            {
                if (Form1.arr[pos] == Convert.ToInt32(btn)) break;
            }
            int i = pos / 4, j = pos % 4;
            if (i == 0)
            {
                if (j == 0)
                {
                    if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else if (j == 3)
                {
                    if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else
                {
                    if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
            }
            else if (i == 3)
            {
                if (j == 0)
                {
                    if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else if (j == 3)
                {
                    if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else
                {
                    if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
            }
            else
            {
                if (j == 0)
                {
                    if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else if (j == 3)
                {
                    if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
                else
                {
                    if (Form1.arr[pos - 1] == 0)
                    {
                        Form1.arr[pos - 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 1] == 0)
                    {
                        Form1.arr[pos + 1] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos - 4] == 0)
                    {
                        Form1.arr[pos - 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                    else if (Form1.arr[pos + 4] == 0)
                    {
                        Form1.arr[pos + 4] = Form1.arr[pos];
                        Form1.arr[pos] = 0;
                    }
                }
            }

            
        }
    }
}
