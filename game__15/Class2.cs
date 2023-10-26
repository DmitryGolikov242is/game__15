using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game15
{
    internal class Class2
    {
        public static void visual()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Form1.btns[i * 4 + j].Text = Form1.arr[i * 4 + j].ToString();
                    if (Form1.arr[i * 4 + j] != 0)
                    {
                        Form1.btns[i * 4 + j].BackColor = Color.White;
                        Form1.btns[i * 4 + j].Visible = true;
                    }
                    else
                    {
                        Form1.btns[i * 4 + j].Visible = false;
                    }

                }
            }
            //button17.Focus();
        }

        public static void check()
        {
            if (Form1.arr[15] == 0)
            {
                int flag = 0;
                for (int i = 0; i < 15; i++)
                {
                    if (Form1.arr[i] != i + 1) { flag = 1; break; }
                }
                if (flag == 0)
                {
                    MessageBox.Show("Игра закончена!", "ПОБЕДА!");
                }
            }
        }

    }
}
