using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsgoDouble
{
    public partial class Form1 : Form
    {
        List<String> rolls;
        int InitialAmount;
        int Balance;
        int Limit;

        public Form1()
        {
            InitializeComponent();
            // Mang de luu tru toan bo roll
            rolls = new List<String>();
            // Load tu file text txt
            var fileStream = new FileStream(@"rolls.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    rolls.Add(line);
                }
            }
            rolls.Reverse();
        }

        private void bt_checkRoll_Click(object sender, EventArgs e)
        {
            CheckRoll form_CR = new CheckRoll(rolls);
            form_CR.ShowDialog();
        }

        private void bt_Go_Click(object sender, EventArgs e)
        {
            InitialAmount = Convert.ToInt32(tbIni.Text);
            Balance = Convert.ToInt32(tbBalance.Text);
            Limit = (tbLimit.Text.Trim() == "0") ? Balance : Convert.ToInt32(tbLimit.Text);
            bool wonLastRound = true;
            int BetAmount = InitialAmount;
            int count = 0;
            foreach (var roll in rolls)
            {
                count++;
                string betColor = getColor();
                BetAmount = getAmount(BetAmount,wonLastRound);
                if (betColor == roll)
                {
                    Balance += BetAmount;
                    wonLastRound = true;
                }
                else
                {
                    Balance -= BetAmount;
                    wonLastRound = false;
                    if (Balance <= 0)
                    {
                        richTextBox1.AppendText("Bạn đã thua hết tiền sau " + count + " vòng \r\n");
                        return;
                    }
                }
                if (count % 100 == 0)richTextBox1.AppendText(Balance + "\r\n");
            }
        }

        private int getAmount(int BetAmount,bool wonLastRound)
        {
            int temp = ((BetAmount * 2 + 1) > Limit) ? Limit : (BetAmount * 2 + 1);
            switch (cbBetType.SelectedItem.ToString())
            {
                case "Nhân đôi khi thắng":
                    return (wonLastRound) ? InitialAmount : temp;
                case "Nhân đôi khi thua":
                    return (!wonLastRound) ? InitialAmount : temp;
                default:
                    return 1;
            }
        }

        private string getColor()
        {
            Random rnd = new Random();
            switch (cbColor.SelectedItem.ToString())
            {
                case "Đỏ":
                    return "red";
                case "Đen":
                    return "black";
                default:
                    int color = rnd.Next(1, 3);
                    if (color == 1) return "red";
                    return "black";
            }
        }
    }
}
