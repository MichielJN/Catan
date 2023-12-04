namespace Catan
{
    partial class RobForm
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
            this.player1button = new System.Windows.Forms.Button();
            this.player3button = new System.Windows.Forms.Button();
            this.player2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1button
            // 
            this.player1button.Location = new System.Drawing.Point(33, 99);
            this.player1button.Name = "player1button";
            this.player1button.Size = new System.Drawing.Size(140, 66);
            this.player1button.TabIndex = 0;
            this.player1button.Text = "button1";
            this.player1button.UseVisualStyleBackColor = true;
            this.player1button.Visible = false;
            this.player1button.Click += new System.EventHandler(this.player1button_Click);
            // 
            // player3button
            // 
            this.player3button.Location = new System.Drawing.Point(325, 99);
            this.player3button.Name = "player3button";
            this.player3button.Size = new System.Drawing.Size(140, 66);
            this.player3button.TabIndex = 1;
            this.player3button.Text = "button2";
            this.player3button.UseVisualStyleBackColor = true;
            this.player3button.Visible = false;
            this.player3button.Click += new System.EventHandler(this.player3button_Click);
            // 
            // player2button
            // 
            this.player2button.Location = new System.Drawing.Point(179, 99);
            this.player2button.Name = "player2button";
            this.player2button.Size = new System.Drawing.Size(140, 66);
            this.player2button.TabIndex = 2;
            this.player2button.Text = "button3";
            this.player2button.UseVisualStyleBackColor = true;
            this.player2button.Visible = false;
            this.player2button.Click += new System.EventHandler(this.player2button_Click);
            // 
            // RobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 210);
            this.ControlBox = false;
            this.Controls.Add(this.player2button);
            this.Controls.Add(this.player3button);
            this.Controls.Add(this.player1button);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "RobForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kies een speler om van te stelen!";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Button player1button;
        private Button player3button;
        private Button player2button;
    }
}