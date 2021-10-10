using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System;

namespace winformapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SetupForms();
            this.SetupInputControls();
            this.SetupResultControls();
            //計算ボタン
            var execBtn = new Button();
            execBtn.Location = new Point(225,150);
            execBtn.Size = new Size(50,25);
            execBtn.Text = "計算";
            execBtn.Font  = new Font("Arial",12);
            execBtn.Click += new EventHandler(this.execBtn_Click);
            this.Controls.Add(execBtn);
        }

        private GroupBox inputGroup;
        private TextBox yearNowText;
        private TextBox monthNowText;
        private TextBox dayNowText;
        private RadioButton dayPlusRadioBtn;
        private RadioButton weekPlusRadioBtn;
        private RadioButton monthPlusRadioBtn;
        private TextBox dayPlusText;
        private TextBox weekPlusText;
        private TextBox monthPlusText;

        /// <summary>
        /// 入力箇所のコントロールの初期設定
        /// </summary>
        private void SetupInputControls()
        {
            this.inputGroup = new GroupBox();
            this.inputGroup.AutoSize = true;
            this.inputGroup.Location = new Point(10,10);
            this.inputGroup.Text = "日付";
            this.inputGroup.FlatStyle = FlatStyle.Standard;

            //年の入力欄
            this.yearNowText = new TextBox();
            this.yearNowText.Location = new Point(25,25);
            this.yearNowText.Size = new Size(50,25);
            this.yearNowText.MaxLength = 4;
            this.inputGroup.Controls.Add(this.yearNowText);

            //ラベル（年）
            var yearLabel = new Label();
            yearLabel.Location = new Point(75,25);
            yearLabel.Size = new Size(25,25);
            yearLabel.Text = "年";
            yearLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(yearLabel);

            //月の入力欄
            this.monthNowText = new TextBox();
            this.monthNowText.Location = new Point(100,25);
            this.monthNowText.Size = new Size(25,25);
            this.monthNowText.MaxLength = 2;
            this.inputGroup.Controls.Add(this.monthNowText);

            //ラベル（月）
            var monthLabel = new Label();
            monthLabel.Location = new Point(125,25);
            monthLabel.Size = new Size(25,25);
            monthLabel.Text = "月";
            monthLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(monthLabel);

            //日の入力欄
            this.dayNowText = new TextBox();
            this.dayNowText.Location = new Point(150,25);
            this.dayNowText.Size = new Size(25,25);
            this.dayNowText.MaxLength = 2;
            this.inputGroup.Controls.Add(this.dayNowText);

            //ラベル（日）
            var dayLabel = new Label();
            dayLabel.Location = new Point(175,25);
            dayLabel.Size = new Size(25,25);
            dayLabel.Text = "日";
            dayLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(dayLabel);

            //X日後のラジオボタン
            this.dayPlusRadioBtn = new RadioButton();
            this.dayPlusRadioBtn.Location = new Point(25,75);
            this.dayPlusRadioBtn.Size = new Size(25,25);
            this.dayPlusRadioBtn.CheckedChanged += new EventHandler(this.radiobutton_CheckedChanged);
            this.inputGroup.Controls.Add(this.dayPlusRadioBtn);

            //X日後の入力欄
            this.dayPlusText = new TextBox();
            this.dayPlusText.Location = new Point(50,75);
            this.dayPlusText.Size = new Size(50,25);
            this.dayPlusText.MaxLength = 5;
            this.inputGroup.Controls.Add(this.dayPlusText);

            //ラベル（日後）
            var dayPlusLabel = new Label();
            dayPlusLabel.Location = new Point(100,75);
            dayPlusLabel.Size = new Size(50,25);
            dayPlusLabel.Text = "日後";
            dayPlusLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(dayPlusLabel);

            //X週間後のラジオボタン
            this.weekPlusRadioBtn = new RadioButton();
            this.weekPlusRadioBtn.Location = new Point(25,100);
            this.weekPlusRadioBtn.Size = new Size(25,25);
            this.weekPlusRadioBtn.CheckedChanged += new EventHandler(this.radiobutton_CheckedChanged);
            this.inputGroup.Controls.Add(this.weekPlusRadioBtn);

            //X週間後の入力欄
            this.weekPlusText = new TextBox();
            this.weekPlusText.Location = new Point(50,100);
            this.weekPlusText.Size = new Size(50,25);
            this.weekPlusText.MaxLength = 5;
            this.inputGroup.Controls.Add(this.weekPlusText);

            //ラベル（週間後）
            var weekPlusLabel = new Label();
            weekPlusLabel.Location = new Point(100,100);
            weekPlusLabel.Size = new Size(50,25);
            weekPlusLabel.Text = "週後";
            weekPlusLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(weekPlusLabel);

            //XX月後のラジオボタン
            this.monthPlusRadioBtn = new RadioButton();
            this.monthPlusRadioBtn.Location = new Point(25,125);
            this.monthPlusRadioBtn.Size = new Size(25,25);
            this.monthPlusRadioBtn.CheckedChanged += new EventHandler(this.radiobutton_CheckedChanged);
            this.inputGroup.Controls.Add(this.monthPlusRadioBtn);

            //X月後の入力欄
            this.monthPlusText = new TextBox();
            this.monthPlusText.Location = new Point(50,125);
            this.monthPlusText.Size = new Size(50,25);
            this.monthPlusText.MaxLength = 5;
            this.inputGroup.Controls.Add(this.monthPlusText);

            //ラベル（月後）
            var monthPlusLabel = new Label();
            monthPlusLabel.Location = new Point(100,125);
            monthPlusLabel.Size = new Size(50,25);
            monthPlusLabel.Text = "月後";
            monthPlusLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(monthPlusLabel);

            this.Controls.Add(this.inputGroup);
        }

        private GroupBox resultGroup;
        private Label resultDateLabel;

        /// <summary>
        /// 結果表示のコントロールの初期設定
        /// </summary>
        private void SetupResultControls()
        {
            this.resultGroup = new GroupBox();
            this.resultGroup.AutoSize = true;
            this.resultGroup.Location = new Point(10,200);
            this.resultGroup.Text = "結果";
            this.resultGroup.FlatStyle = FlatStyle.Standard;

            //結果表示
            this.resultDateLabel = new Label();
            this.resultDateLabel.AutoSize = false;
            this.resultDateLabel.Location = new Point(25,25);
            this.resultDateLabel.Size = new Size(175,25);
            this.resultDateLabel.Font = new Font("Arial",10);
            this.resultGroup.Controls.Add(this.resultDateLabel);

            this.Controls.Add(this.resultGroup);
        }

        /// <summary>
        /// フォールの初期設定
        /// </summary>
        private void SetupForms()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ClientSize = new Size(300,300);
            this.Text = "日付計算";
        }

        #endregion
    }
}
