using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private object txtAnswer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntDiv_Click(object sender, EventArgs e)
        {
            try
            {
                // Viết xử lí tính tổng trong sự kiện Div_click
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 / number2;
                txtAnswer1.Text = result.ToString();
            }
            catch (Exception ex) //Khi gặp bất kì lỗi nào sẽ vào catch
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Xử lí sự kiện cộng 2 số
                // Viết xử lí tính tổng trong sự kiện Add_click
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 + number2;
                txtAnswer1.Text = result.ToString();
            }
            catch (Exception ex) //Khi gặp bất kì lỗi nào sẽ vào catch
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            // Viết xử lí tính tổng trong sự kiện Add_click
            float number1 = float.Parse(txtNumber1.Text);
            float number2 = float.Parse(txtNumber2.Text);
            float result = number1 - number2;
            txtAnswer1.Text = result.ToString();
        }

        private void bntMul_Click(object sender, EventArgs e)
        {
            try
            {
                //Xử lí sự kiện chia 2 số
                // Viết xử lí tính tổng trong sự kiện Div_click
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 * number2;
                txtAnswer1.Text = result.ToString();
            }
            catch (Exception ex) //Khi gặp bất kì lỗi nào sẽ vào catch
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
