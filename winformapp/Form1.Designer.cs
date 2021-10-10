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
            this.SetupButtonControls();
        }

        private GroupBox inputGroup;
        private DateTimePicker picker;
        private ComboBox comboBox;
        private NumericUpDown plusDate;
        private Label numLabel;

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

            //元の日付ラベル
            var pickerLabel = new Label();
            pickerLabel.Location = new Point(10,25);
            pickerLabel.Size = new Size(75,25);
            pickerLabel.Text = "元の日付";
            pickerLabel.Font = new Font("Arial",8);
            this.inputGroup.Controls.Add(pickerLabel);

            //元の日付
            this.picker = new DateTimePicker();
            this.picker.Location = new Point(10,50);
            this.picker.Size = new Size(150,25);
            this.picker.CustomFormat = "yyyy年MM月dd日";
            this.inputGroup.Controls.Add(this.picker);

            //加算する日数ラベル
            var plusLabel = new Label();
            plusLabel.Location = new Point(10,90);
            plusLabel.Size = new Size(200,25);
            plusLabel.Text = "加算する値(1～100,000)";
            plusLabel.Font = new Font("Arial",8);
            this.inputGroup.Controls.Add(plusLabel);

            //加算する日数の種類
            this.comboBox = new ComboBox();
            this.comboBox.Location = new Point(10,115);
            this.comboBox.Size = new Size(60,25);
            this.comboBox.Items.Add("+日数");
            this.comboBox.Items.Add("+週数");
            this.comboBox.Items.Add("+月数");
            this.comboBox.TextChanged += new EventHandler(this.combobox_TextChanged);
            this.inputGroup.Controls.Add(this.comboBox);

            //加算する日数
            this.plusDate = new NumericUpDown();
            this.plusDate.Location = new Point(80,115);
            this.plusDate.Size = new Size(60,25);
            this.plusDate.ThousandsSeparator = true;
            this.plusDate.Minimum = 1;
            this.plusDate.Maximum = 100000;
            this.inputGroup.Controls.Add(this.plusDate);

            //ラベル（日後 or 週後 or 月後）
            this.numLabel = new Label();
            this.numLabel.Location = new Point(140,115);
            this.numLabel.Size = new Size(40,25);
            this.numLabel.Font = new Font("Arial",12);
            this.inputGroup.Controls.Add(this.numLabel);

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
            this.resultGroup.Location = new Point(10,175);
            this.resultGroup.Text = "結果";
            this.resultGroup.FlatStyle = FlatStyle.Standard;

            //結果表示
            this.resultDateLabel = new Label();
            this.resultDateLabel.AutoSize = false;
            this.resultDateLabel.Location = new Point(10,25);
            this.resultDateLabel.Size = new Size(175,50);
            this.resultDateLabel.Font = new Font("Arial",8);
            this.resultGroup.Controls.Add(this.resultDateLabel);

            this.Controls.Add(this.resultGroup);
        }

        /// <summary>
        /// ボタン類のコントロールの初期設定
        /// </summary>
        private void SetupButtonControls()
        {
            //計算実行ボタン
            var execBtn = new Button();
            execBtn.Location = new Point(225,125);
            execBtn.Size = new Size(50,25);
            execBtn.Text = "計算";
            execBtn.Font  = new Font("Arial",12);
            execBtn.Click += new EventHandler(this.execBtn_Click);
            this.Controls.Add(execBtn);
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
