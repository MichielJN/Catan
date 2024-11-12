namespace Catan
{
    partial class PlayerMenu
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
            this.player1textbox = new System.Windows.Forms.TextBox();
            this.player2textbox = new System.Windows.Forms.TextBox();
            this.player3textbox = new System.Windows.Forms.TextBox();
            this.player4textbox = new System.Windows.Forms.TextBox();
            this.numberofplayerscombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1textbox
            // 
            this.player1textbox.Location = new System.Drawing.Point(366, 294);
            this.player1textbox.Name = "player1textbox";
            this.player1textbox.Size = new System.Drawing.Size(408, 31);
            this.player1textbox.TabIndex = 0;
            this.player1textbox.Text = "Player 1";
            this.player1textbox.Visible = false;
            // 
            // player2textbox
            // 
            this.player2textbox.Location = new System.Drawing.Point(366, 331);
            this.player2textbox.Name = "player2textbox";
            this.player2textbox.ShortcutsEnabled = false;
            this.player2textbox.Size = new System.Drawing.Size(408, 31);
            this.player2textbox.TabIndex = 1;
            this.player2textbox.Text = "Player 2";
            // 
            // player3textbox
            // 
            this.player3textbox.Location = new System.Drawing.Point(366, 368);
            this.player3textbox.Name = "player3textbox";
            this.player3textbox.ShortcutsEnabled = false;
            this.player3textbox.Size = new System.Drawing.Size(408, 31);
            this.player3textbox.TabIndex = 2;
            this.player3textbox.Text = "Player 3";
            // 
            // player4textbox
            // 
            this.player4textbox.Location = new System.Drawing.Point(366, 405);
            this.player4textbox.Name = "player4textbox";
            this.player4textbox.ShortcutsEnabled = false;
            this.player4textbox.Size = new System.Drawing.Size(408, 31);
            this.player4textbox.TabIndex = 3;
            this.player4textbox.Text = "Player 4";
            // 
            // numberofplayerscombobox
            // 
            this.numberofplayerscombobox.FormattingEnabled = true;
            this.numberofplayerscombobox.Items.AddRange(new object[] {
            "3 Players",
            "4 Players"});
            this.numberofplayerscombobox.Location = new System.Drawing.Point(366, 255);
            this.numberofplayerscombobox.Name = "numberofplayerscombobox";
            this.numberofplayerscombobox.Size = new System.Drawing.Size(408, 33);
            this.numberofplayerscombobox.TabIndex = 4;
            this.numberofplayerscombobox.Text = "Select the number of players";
            this.numberofplayerscombobox.SelectedIndexChanged += new System.EventHandler(this.numberofplayerscombobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 124);
            this.button1.TabIndex = 5;
            this.button1.Text = "START!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberofplayerscombobox);
            this.Controls.Add(this.player4textbox);
            this.Controls.Add(this.player3textbox);
            this.Controls.Add(this.player2textbox);
            this.Controls.Add(this.player1textbox);
            this.Name = "PlayerMenu";
            this.Text = "PlayerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox player1textbox;
        private TextBox player2textbox;
        private TextBox player3textbox;
        private TextBox player4textbox;
        private ComboBox numberofplayerscombobox;
        private Button button1;
    }
}