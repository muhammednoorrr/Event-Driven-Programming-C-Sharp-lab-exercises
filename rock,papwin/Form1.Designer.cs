namespace rock_papwin
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
            label1 = new Label();
            comboBoxPlayer1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            comboBoxPlayer2 = new ComboBox();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 66);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Player1";
            // 
            // comboBoxPlayer1
            // 
            comboBoxPlayer1.FormattingEnabled = true;
            comboBoxPlayer1.Items.AddRange(new object[] { "Rock", "Paper", "Scissors" });
            comboBoxPlayer1.Location = new Point(307, 66);
            comboBoxPlayer1.Name = "comboBoxPlayer1";
            comboBoxPlayer1.Size = new Size(182, 33);
            comboBoxPlayer1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(318, 325);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "GO!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 130);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Player2";
            // 
            // comboBoxPlayer2
            // 
            comboBoxPlayer2.FormattingEnabled = true;
            comboBoxPlayer2.Items.AddRange(new object[] { "Rock", "Paper", "Scissors" });
            comboBoxPlayer2.Location = new Point(307, 130);
            comboBoxPlayer2.Name = "comboBoxPlayer2";
            comboBoxPlayer2.Size = new Size(182, 33);
            comboBoxPlayer2.TabIndex = 4;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(283, 228);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(comboBoxPlayer2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBoxPlayer1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxPlayer1;
        private Button button1;
        private Label label2;
        private ComboBox comboBoxPlayer2;
        private Label labelResult;
    }
}