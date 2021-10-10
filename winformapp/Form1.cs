using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace winformapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitializeDisplay();
        }

        /// <summary>
        /// 画面の表示を初期化する
        /// </summary>
        public void InitializeDisplay()
        {
            //入力箇所の初期化
            this.yearNowText.Text = DateTime.Now.Year.ToString();
            this.monthNowText.Text = DateTime.Now.Month.ToString();
            this.dayNowText.Text = DateTime.Now.Day.ToString();
            this.dayPlusRadioBtn.Checked = true;
            this.dayPlusText.Text = "1";
            this.weekPlusText.Text = "1";
            this.monthPlusText.Text = "1";

            //結果の初期化
            this.resultDateLabel.Text = "YYYY年MM月DD日（月曜日）";
        }


        public void execBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("動作確認");
        }
    }
}
