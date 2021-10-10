using System.Drawing;
using System.Windows.Forms;

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
            //this.SetupControls();
        }

        /// <summary>
        /// フォールの初期設定
        /// </summary>
        private void SetupForms()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ClientSize = new Size(600,400);
            this.Text = "日付計算";
            this.Name = "日付計算";
        }


        #endregion
    }
}
