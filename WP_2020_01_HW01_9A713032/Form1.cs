using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_9A713032
{
    public partial class Form1 : Form
    {
        string[] msg = { "一輩子單身QQ", "妹仔幹不玩啦RR", "是下一個比爾蓋茲", "賺不到甚麼錢哭阿", "風趣幽默人緣好", "難笑尷尬沒朋友" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            byte[] source = Encoding.Default.GetBytes(tB.Text);
            byte[] crypto = md5.ComputeHash(source);
            int word = ((int)crypto[0]) % 6;
            rTB.Text = ("分析你的名字我認為你: \n" + msg[word]);

        }
    }
}
