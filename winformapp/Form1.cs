﻿using System;
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
            this.plusDate.Text = "1";
            //結果の初期化
            this.resultDateLabel.Text = "YYYY年MM月DD日（月）";
        }

        /// <summary>
        /// 計算ボタンクリック時、日付計算を実行する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void execBtn_Click(object sender, EventArgs e)
        {
            try{
                var date = this.picker.Value;
                var d = int.Parse(this.plusDate.Text);
                var afterDate = CalcDate(date,d);
                this.ShowCalcResult(afterDate);
            }catch{
                MessageBox.Show("不正なエラーが発生しました");
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
