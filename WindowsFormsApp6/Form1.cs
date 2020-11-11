using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();
            try
            {
                //新增N筆資料
                for (int i = 1; i < count; i++)
                {
                    result.Add(i);
                }

                //模擬發牌
                for (int i = count - 3; i > 1; i--)
                {
                    int lastIndex = i + 1;                    //方便閱讀
                    int randomIndex = (new Random()).Next(i); //抽牌

                    //交換
                    int temp = result[lastIndex];
                    result[lastIndex] = result[randomIndex];
                    result[randomIndex] = temp;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> poker = GetPoker(53);
            string msg = "";
            for (int i = 1; i < poker.Count; i++)
            {
                msg += $"您抽到了，{poker[i]} \n";
            }
            richTextBox1.AppendText(msg);
        }

        
    }
}
