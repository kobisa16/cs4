namespace trgil2
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
            menuStrip1 = new MenuStrip();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            addAnimalToolStripMenuItem = new ToolStripMenuItem();
            viewSystemToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(348, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAnimalToolStripMenuItem, viewSystemToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(77, 20);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // addAnimalToolStripMenuItem
            // 
            addAnimalToolStripMenuItem.Name = "addAnimalToolStripMenuItem";
            addAnimalToolStripMenuItem.Size = new Size(180, 22);
            addAnimalToolStripMenuItem.Text = "Add animal";
            addAnimalToolStripMenuItem.Click += addAnimalToolStripMenuItem_Click;
            // 
            // viewSystemToolStripMenuItem
            // 
            viewSystemToolStripMenuItem.Name = "viewSystemToolStripMenuItem";
            viewSystemToolStripMenuItem.Size = new Size(180, 22);
            viewSystemToolStripMenuItem.Text = "View system";
            viewSystemToolStripMenuItem.Click += viewSystemToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem addAnimalToolStripMenuItem;
        private ToolStripMenuItem viewSystemToolStripMenuItem;
    }
}
