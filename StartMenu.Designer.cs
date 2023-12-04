namespace Catan
{
    partial class StartMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.playersbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 205);
            this.button1.TabIndex = 0;
            this.button1.Text = "SPEEL!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playersbutton
            // 
            this.playersbutton.Location = new System.Drawing.Point(292, 66);
            this.playersbutton.Name = "playersbutton";
            this.playersbutton.Size = new System.Drawing.Size(169, 45);
            this.playersbutton.TabIndex = 1;
            this.playersbutton.Text = "Spelers";
            this.playersbutton.UseVisualStyleBackColor = true;
            this.playersbutton.Click += new System.EventHandler(this.playersbutton_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playersbutton);
            this.Controls.Add(this.button1);
            this.Name = "StartMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button playersbutton;
    }
}