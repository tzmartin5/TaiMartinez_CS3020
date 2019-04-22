namespace SudoSolver
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenExisting = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.checkProgressToolStripMenuItem,
            this.solveToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1408, 58);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTestBoardToolStripMenuItem,
            this.loadPuzzleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadTestBoardToolStripMenuItem
            // 
            this.loadTestBoardToolStripMenuItem.Name = "loadTestBoardToolStripMenuItem";
            this.loadTestBoardToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.loadTestBoardToolStripMenuItem.Text = "New Game";
            this.loadTestBoardToolStripMenuItem.Click += new System.EventHandler(this.loadTestBoardToolStripMenuItem_Click);
            // 
            // loadPuzzleToolStripMenuItem
            // 
            this.loadPuzzleToolStripMenuItem.Name = "loadPuzzleToolStripMenuItem";
            this.loadPuzzleToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.loadPuzzleToolStripMenuItem.Text = "Load Preloaded";
            this.loadPuzzleToolStripMenuItem.Click += new System.EventHandler(this.loadPuzzleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkProgressToolStripMenuItem
            // 
            this.checkProgressToolStripMenuItem.Name = "checkProgressToolStripMenuItem";
            this.checkProgressToolStripMenuItem.Size = new System.Drawing.Size(111, 45);
            this.checkProgressToolStripMenuItem.Text = "Check";
            this.checkProgressToolStripMenuItem.Click += new System.EventHandler(this.checkProgressToolStripMenuItem_Click);
            // 
            // solveToolStripMenuItem1
            // 
            this.solveToolStripMenuItem1.Name = "solveToolStripMenuItem1";
            this.solveToolStripMenuItem1.Size = new System.Drawing.Size(101, 48);
            this.solveToolStripMenuItem1.Text = "Solve";
            this.solveToolStripMenuItem1.Click += new System.EventHandler(this.solveToolStripMenuItem_Click);
            // 
            // ofdOpenExisting
            // 
            this.ofdOpenExisting.Filter = "Sudoku File|*.sudo";
            // 
            // sfdSave
            // 
            this.sfdSave.Filter = "Sudoku File|*.sudo";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1061);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMain";
            this.Text = "Sudo Solver";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestBoardToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdOpenExisting;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.ToolStripMenuItem checkProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem1;
    }
}

