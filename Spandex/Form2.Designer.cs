namespace Spandex
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            searchBox = new TextBox();
            resultlist = new ListBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(22, 21);
            searchBox.Margin = new Padding(2, 2, 2, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(537, 23);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // resultlist
            // 
            resultlist.FormattingEnabled = true;
            resultlist.ItemHeight = 15;
            resultlist.Location = new Point(22, 59);
            resultlist.Margin = new Padding(2, 2, 2, 2);
            resultlist.Name = "resultlist";
            resultlist.Size = new Size(535, 154);
            resultlist.TabIndex = 1;
            resultlist.SelectedIndexChanged += resultlist_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(228, 220);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 26);
            button1.TabIndex = 2;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 257);
            Controls.Add(button1);
            Controls.Add(resultlist);
            Controls.Add(searchBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Asset search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private ListBox resultlist;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}