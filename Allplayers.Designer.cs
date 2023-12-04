namespace Catan
{
    partial class All_players
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
            this.playerlist = new System.Windows.Forms.ListBox();
            this.changeplayerbutton = new System.Windows.Forms.Button();
            this.deleteplayerbutton = new System.Windows.Forms.Button();
            this.changeplayerinputtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerlist
            // 
            this.playerlist.FormattingEnabled = true;
            this.playerlist.ItemHeight = 25;
            this.playerlist.Location = new System.Drawing.Point(187, 56);
            this.playerlist.Name = "playerlist";
            this.playerlist.Size = new System.Drawing.Size(382, 254);
            this.playerlist.TabIndex = 0;
            // 
            // changeplayerbutton
            // 
            this.changeplayerbutton.Location = new System.Drawing.Point(624, 56);
            this.changeplayerbutton.Name = "changeplayerbutton";
            this.changeplayerbutton.Size = new System.Drawing.Size(112, 34);
            this.changeplayerbutton.TabIndex = 1;
            this.changeplayerbutton.Text = "Change player";
            this.changeplayerbutton.UseVisualStyleBackColor = true;
            this.changeplayerbutton.Click += new System.EventHandler(this.changeplayerbutton_Click);
            // 
            // deleteplayerbutton
            // 
            this.deleteplayerbutton.Location = new System.Drawing.Point(624, 96);
            this.deleteplayerbutton.Name = "deleteplayerbutton";
            this.deleteplayerbutton.Size = new System.Drawing.Size(112, 34);
            this.deleteplayerbutton.TabIndex = 2;
            this.deleteplayerbutton.Text = "Delete player";
            this.deleteplayerbutton.UseVisualStyleBackColor = true;
            this.deleteplayerbutton.Click += new System.EventHandler(this.deleteplayerbutton_Click);
            // 
            // changeplayerinputtextbox
            // 
            this.changeplayerinputtextbox.Location = new System.Drawing.Point(187, 342);
            this.changeplayerinputtextbox.Name = "changeplayerinputtextbox";
            this.changeplayerinputtextbox.Size = new System.Drawing.Size(303, 31);
            this.changeplayerinputtextbox.TabIndex = 3;
            // 
            // All_players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeplayerinputtextbox);
            this.Controls.Add(this.deleteplayerbutton);
            this.Controls.Add(this.changeplayerbutton);
            this.Controls.Add(this.playerlist);
            this.Name = "All_players";
            this.Text = "All_players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox playerlist;
        private Button changeplayerbutton;
        private Button deleteplayerbutton;
        private TextBox changeplayerinputtextbox;
    }
}