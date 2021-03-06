﻿namespace KesselRun.HomeLibrary.Ui.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLendings = new System.Windows.Forms.Button();
            this.lstMainViewLog = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTopArea = new System.Windows.Forms.Panel();
            this.logDisplayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDisplayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.MainContentPanel.Location = new System.Drawing.Point(6, 127);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(1070, 300);
            this.MainContentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPeople);
            this.panel1.Controls.Add(this.btnBooks);
            this.panel1.Controls.Add(this.btnLendings);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(8, 65);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(118, 23);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(8, 36);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(118, 23);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnLendings
            // 
            this.btnLendings.Location = new System.Drawing.Point(8, 10);
            this.btnLendings.Name = "btnLendings";
            this.btnLendings.Size = new System.Drawing.Size(118, 23);
            this.btnLendings.TabIndex = 0;
            this.btnLendings.Text = "LendingsViewModel";
            this.btnLendings.UseVisualStyleBackColor = true;
            this.btnLendings.Click += new System.EventHandler(this.btnLendings_Click);
            // 
            // lstMainViewLog
            // 
            this.lstMainViewLog.FormattingEnabled = true;
            this.lstMainViewLog.Location = new System.Drawing.Point(6, 431);
            this.lstMainViewLog.Name = "lstMainViewLog";
            this.lstMainViewLog.Size = new System.Drawing.Size(1069, 95);
            this.lstMainViewLog.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1001, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close App";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTopArea
            // 
            this.pnlTopArea.Location = new System.Drawing.Point(144, 13);
            this.pnlTopArea.Name = "pnlTopArea";
            this.pnlTopArea.Size = new System.Drawing.Size(931, 109);
            this.pnlTopArea.TabIndex = 5;
            // 
            // logDisplayBindingSource
            // 
            this.logDisplayBindingSource.DataSource = typeof(KesselRun.HomeLibrary.UiModel.ViewModels.MainViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 554);
            this.Controls.Add(this.pnlTopArea);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstMainViewLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainContentPanel);
            this.Name = "MainForm";
            this.Text = "Home Library";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDisplayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnLendings;
        private System.Windows.Forms.ListBox lstMainViewLog;
        private System.Windows.Forms.BindingSource logDisplayBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTopArea;
    }
}

