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
        private void InitializeDisplay()
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
            this.resultDateLabel.Text = "YYYY年MM月DD日（月）";
        }

        private void execBtn_Click(object sender, EventArgs e)
        {
            try{
                var y = int.Parse(this.yearNowText.Text);
                var m = int.Parse(this.monthNowText.Text);
                var d = int.Parse(this.dayNowText.Text);
                var date = new DateTime(y,m,d);
                var afterDate = CalcDate(date);
                this.ShowCalcResult(afterDate);
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 計算結果を画面に表示する
        /// </summary>
        private void ShowCalcResult(DateTime date)
        {
            var strdate = date.ToString("yyyy年MM月dd日");
            var culture = System.Globalization.CultureInfo.GetCultureInfo("ja-JP");
            var strdayofweek = date.ToString("ddd",culture);
            this.resultDateLabel.Text = $"{strdate}（{strdayofweek}）";
        }

        /// <summary>
        /// 加算後の日付を計算する
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private DateTime CalcDate(DateTime date)
        {
            if(this.dayPlusRadioBtn.Checked){
                var d = int.Parse(this.dayPlusText.Text);
                return date.AddDays(d);
            }

            if(this.weekPlusRadioBtn.Checked){
                var d = int.Parse(this.weekPlusText.Text) * 7;
                return date.AddDays(d);
            }

            var m = int.Parse(this.monthPlusText.Text);
            return date.AddMonths(m);
        }
    }
}
