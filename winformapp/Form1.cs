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
            this.comboBox.SelectedIndex = 0;
            this.plusDate.Value = 1;
            this.numLabel.Text = "日後";
            //結果の初期化
            this.resultDateLabel.Text = "YYYY年MM月DD日（月）";
        }

        /// <summary>
        /// コンボボックスの選択に合わせて、～後の表示を変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combobox_TextChanged(object sender, EventArgs e)
        {
            var idx = this.comboBox.SelectedIndex;
            if(idx == 0){
                this.numLabel.Text = "日後";
            }else if(idx == 1){
                this.numLabel.Text = "週後";
            }else{
                this.numLabel.Text = "月後";
            }
        }

        /// <summary>
        /// 計算ボタンクリック時、日付計算を実行する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void execBtn_Click(object sender, EventArgs e)
        {
            try{
                var afterDate = CalcDate(this.picker.Value, (int)this.plusDate.Value);
                this.ShowCalcResult(afterDate);
            }catch{
                MessageBox.Show("不正なエラーが発生しました");
            }
        }

        /// <summary>
        /// 計算結果を画面に表示する
        /// </summary>
        /// <param name="date">画面表示する日付</param>
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
        /// <param name="date">加算前の日付</param>
        /// <param name="d">加算する日付</param>
        /// <returns></returns>
        private DateTime CalcDate(DateTime date, int d)
        {
            var idx = this.comboBox.SelectedIndex;
            if(idx == 0){
                return date.AddDays(d);
            }
            if(idx == 1){
                return date.AddDays(d * 7);
            }
            return date.AddMonths(d);
        }
    }
}
