namespace TPlivre
{
    partial class Form_Menu
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
            menuStrip1=new MenuStrip();
            quitterToolStripMenuItem=new ToolStripMenuItem();
            tabesToolStripMenuItem=new ToolStripMenuItem();
            auteurToolStripMenuItem=new ToolStripMenuItem();
            genresToolStripMenuItem=new ToolStripMenuItem();
            livresToolStripMenuItem=new ToolStripMenuItem();
            adhérentToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quitterToolStripMenuItem, tabesToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Padding=new Padding(7, 3, 0, 3);
            menuStrip1.Size=new Size(383, 30);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name="quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size=new Size(69, 24);
            quitterToolStripMenuItem.Text="Quitter";
            quitterToolStripMenuItem.Click+=quitterToolStripMenuItem_Click;
            // 
            // tabesToolStripMenuItem
            // 
            tabesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { auteurToolStripMenuItem, genresToolStripMenuItem, livresToolStripMenuItem, adhérentToolStripMenuItem });
            tabesToolStripMenuItem.Name="tabesToolStripMenuItem";
            tabesToolStripMenuItem.Size=new Size(60, 24);
            tabesToolStripMenuItem.Text="Bases";
            // 
            // auteurToolStripMenuItem
            // 
            auteurToolStripMenuItem.Name="auteurToolStripMenuItem";
            auteurToolStripMenuItem.Size=new Size(224, 26);
            auteurToolStripMenuItem.Text="Auteurs";
            auteurToolStripMenuItem.Click+=auteurToolStripMenuItem_Click;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Name="genresToolStripMenuItem";
            genresToolStripMenuItem.Size=new Size(224, 26);
            genresToolStripMenuItem.Text="Genres";
            // 
            // livresToolStripMenuItem
            // 
            livresToolStripMenuItem.Name="livresToolStripMenuItem";
            livresToolStripMenuItem.Size=new Size(224, 26);
            livresToolStripMenuItem.Text="Livres";
            // 
            // adhérentToolStripMenuItem
            // 
            adhérentToolStripMenuItem.Name="adhérentToolStripMenuItem";
            adhérentToolStripMenuItem.Size=new Size(224, 26);
            adhérentToolStripMenuItem.Text="Adhérent";
            // 
            // Form_Menu
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(383, 373);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Margin=new Padding(3, 4, 3, 4);
            Name="Form_Menu";
            Text="Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem tabesToolStripMenuItem;
        private ToolStripMenuItem auteurToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem livresToolStripMenuItem;
        private ToolStripMenuItem adhérentToolStripMenuItem;
    }
}