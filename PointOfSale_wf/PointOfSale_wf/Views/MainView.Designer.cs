namespace PointOfSale_wf.Views
{
    partial class MainView
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
            this.pnlWindowControl = new PointOfSale_wf.Views.Tools.Components.pnlFormControl();
            this.tlpDistribution = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.mnbMenu = new PointOfSale_wf.Views.Tools.Components.MenuBar();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDistribution.SuspendLayout();
            this.pnlMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindowControl
            // 
            this.pnlWindowControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWindowControl.Location = new System.Drawing.Point(0, 0);
            this.pnlWindowControl.Name = "pnlWindowControl";
            this.pnlWindowControl.Size = new System.Drawing.Size(858, 29);
            this.pnlWindowControl.TabIndex = 0;
            // 
            // tlpDistribution
            // 
            this.tlpDistribution.ColumnCount = 2;
            this.tlpDistribution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tlpDistribution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDistribution.Controls.Add(this.pnlMenuBar, 0, 0);
            this.tlpDistribution.Controls.Add(this.tlpBody, 1, 0);
            this.tlpDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDistribution.Location = new System.Drawing.Point(0, 29);
            this.tlpDistribution.Name = "tlpDistribution";
            this.tlpDistribution.RowCount = 1;
            this.tlpDistribution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDistribution.Size = new System.Drawing.Size(858, 404);
            this.tlpDistribution.TabIndex = 1;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuBar.Controls.Add(this.mnbMenu);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuBar.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(229, 398);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // mnbMenu
            // 
            this.mnbMenu.BackColor = System.Drawing.Color.Transparent;
            this.mnbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnbMenu.Location = new System.Drawing.Point(0, 0);
            this.mnbMenu.Name = "mnbMenu";
            this.mnbMenu.Size = new System.Drawing.Size(229, 398);
            this.mnbMenu.TabIndex = 0;
            // 
            // tlpBody
            // 
            this.tlpBody.BackColor = System.Drawing.Color.Transparent;
            this.tlpBody.ColumnCount = 1;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(238, 3);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 3;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpBody.Size = new System.Drawing.Size(617, 398);
            this.tlpBody.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 433);
            this.Controls.Add(this.tlpDistribution);
            this.Controls.Add(this.pnlWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Text = "MainView";
            this.tlpDistribution.ResumeLayout(false);
            this.pnlMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.Components.pnlFormControl pnlWindowControl;
        private System.Windows.Forms.TableLayoutPanel tlpDistribution;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private Tools.Components.MenuBar mnbMenu;
    }
}