using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8]; //8x8 lik bir buton arrayi.
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)  //GetUpperBound(0)  0.satırın en büyük alabileceği değere karşılık gelir. Yani 7.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;  //[i,j] nin forma göre Lefte uzaklığını şu an left=0 yaptık. 
                    buttons[i, j].Top = top;
                    left += 50;  //ikinci butonu sağa kaydırmak için lefti 50 karakter artırmalıyız.
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]); //this form a karşılık gelir. //Bu cümle formun kontrollerini ekle demek.

                }
                left = 0;               
                top += 50;
            }
           
        }
    }
}
