namespace BA_V1
{
    partial class Frm_MainMenu
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
            testToolStripMenuItem = new ToolStripMenuItem();
            conductAssessmentToolStripMenuItem = new ToolStripMenuItem();
            showLastResultsToolStripMenuItem = new ToolStripMenuItem();
            exportLastResultsToolStripMenuItem = new ToolStripMenuItem();
            importResultsFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(304, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conductAssessmentToolStripMenuItem, showLastResultsToolStripMenuItem, exportLastResultsToolStripMenuItem, importResultsFileToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(39, 20);
            testToolStripMenuItem.Text = "Test";
            // 
            // conductAssessmentToolStripMenuItem
            // 
            conductAssessmentToolStripMenuItem.Name = "conductAssessmentToolStripMenuItem";
            conductAssessmentToolStripMenuItem.Size = new Size(227, 22);
            conductAssessmentToolStripMenuItem.Text = "Test durchführen";
            conductAssessmentToolStripMenuItem.Click += conductAssessmentToolStripMenuItem_Click;
            // 
            // showLastResultsToolStripMenuItem
            // 
            showLastResultsToolStripMenuItem.Name = "showLastResultsToolStripMenuItem";
            showLastResultsToolStripMenuItem.Size = new Size(227, 22);
            showLastResultsToolStripMenuItem.Text = "Letzte Ergebnisse anzeigen";
            showLastResultsToolStripMenuItem.Click += showLastResultsToolStripMenuItem_Click;
            // 
            // exportLastResultsToolStripMenuItem
            // 
            exportLastResultsToolStripMenuItem.Name = "exportLastResultsToolStripMenuItem";
            exportLastResultsToolStripMenuItem.Size = new Size(227, 22);
            exportLastResultsToolStripMenuItem.Text = "Letzte Ergebnisse exportieren";
            exportLastResultsToolStripMenuItem.Click += exportLastResultsToolStripMenuItem_Click;
            // 
            // importResultsFileToolStripMenuItem
            // 
            importResultsFileToolStripMenuItem.Name = "importResultsFileToolStripMenuItem";
            importResultsFileToolStripMenuItem.Size = new Size(227, 22);
            importResultsFileToolStripMenuItem.Text = "Ergebnisdatei laden";
            importResultsFileToolStripMenuItem.Click += importResultsFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 20);
            toolStripMenuItem1.Text = " ";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(65, 20);
            exitToolStripMenuItem.Text = "Beenden";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // fileDialog
            // 
            fileDialog.DefaultExt = "xml";
            fileDialog.Title = "Please select file location";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "csv";
            // 
            // Frm_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 41);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(320, 80);
            MinimumSize = new Size(320, 80);
            Name = "Frm_MainMenu";
            Text = "Hauptmenü";
            Load += Frm_MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem conductAssessmentToolStripMenuItem;
        private ToolStripMenuItem showLastResultsToolStripMenuItem;
        private ToolStripMenuItem exportLastResultsToolStripMenuItem;
        private ToolStripMenuItem importResultsFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private OpenFileDialog fileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
