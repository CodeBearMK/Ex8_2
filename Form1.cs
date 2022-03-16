using System;
using System.Windows.Forms;

namespace Ex8_2
{
    public partial class Form1 : Form
    {
        int houseAmt = 0;
        int anotherSvcAmt = 0;
        int totalamount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = { "精緻雙人房3000元", "景觀雙人房4000元", "豪華雙人房6000元" };
            foreach (string op in options)
            {
                comboBox1.Items.Add(op);
            }

            checkedListBox1.CheckOnClick = true;
            string[] options2 = { "早餐200元", "午餐400元", "晚餐600元", "登山導覽300元" };
            foreach (string op2 in options2)
            {
                checkedListBox1.Items.Add(op2);
            }
        }

        private void subtotalAmt()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            houseAmt = 0;
            if (comboBox1.SelectedIndex == 0) houseAmt = 3000;
            else if (comboBox1.SelectedIndex == 1) houseAmt = 4000;
            else if (comboBox1.SelectedIndex == 2) houseAmt = 6000;
            totalamount = houseAmt + anotherSvcAmt;
            label3.Text = "合計　" + totalamount.ToString() + "　元";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            anotherSvcAmt = 0;
            if (checkedListBox1.GetItemChecked(0))
            {
                anotherSvcAmt += 200;
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                anotherSvcAmt += 400;
            }
            if (checkedListBox1.GetItemChecked(2))
            {
                anotherSvcAmt += 600;
            }
            if (checkedListBox1.GetItemChecked(3))
            {
                anotherSvcAmt += 300;
            }
            totalamount = houseAmt + anotherSvcAmt;
            label3.Text = "合計　" + totalamount.ToString() + "　元";
        }
    }
}
