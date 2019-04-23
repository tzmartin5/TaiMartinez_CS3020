namespace Sudoku
{
    partial class frmMain
    {
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SolveButton = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(1130, 428);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(265, 69);
            this.SolveButton.TabIndex = 6;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(1130, 96);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(265, 78);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(1130, 196);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(265, 83);
            this.LoadBtn.TabIndex = 7;
            this.LoadBtn.Text = "Load Preloaded";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(1130, 533);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(261, 72);
            this.CheckBtn.TabIndex = 8;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1061);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.SolveButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMain";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button CheckBtn;
    }
}

