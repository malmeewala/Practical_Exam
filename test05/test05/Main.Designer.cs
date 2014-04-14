namespace test05
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MainManu_Reg = new System.Windows.Forms.ToolStripMenuItem();
            this.MainManu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManuMain
            // 
            this.ManuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainManu_Reg,
            this.MainManu_Exit});
            this.ManuMain.Name = "ManuMain";
            this.ManuMain.Size = new System.Drawing.Size(50, 20);
            this.ManuMain.Text = "Menu";
            this.ManuMain.Click += new System.EventHandler(this.ManuMain_Click);
            // 
            // MainManu_Reg
            // 
            this.MainManu_Reg.Name = "MainManu_Reg";
            this.MainManu_Reg.Size = new System.Drawing.Size(164, 22);
            this.MainManu_Reg.Text = "New Registration";
            this.MainManu_Reg.Click += new System.EventHandler(this.MainManu_Reg_Click);
            // 
            // MainManu_Exit
            // 
            this.MainManu_Exit.Name = "MainManu_Exit";
            this.MainManu_Exit.Size = new System.Drawing.Size(164, 22);
            this.MainManu_Exit.Text = "Exit";
            this.MainManu_Exit.Click += new System.EventHandler(this.MainManu_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 337);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManuMain;
        private System.Windows.Forms.ToolStripMenuItem MainManu_Reg;
        private System.Windows.Forms.ToolStripMenuItem MainManu_Exit;
    }
}