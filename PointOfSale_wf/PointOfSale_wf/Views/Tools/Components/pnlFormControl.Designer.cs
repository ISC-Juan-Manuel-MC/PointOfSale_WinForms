
namespace PointOfSale_wf.Views.Tools.Components
{
    partial class pnlFormControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxMaximize = new System.Windows.Forms.PictureBox();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pbxRestore = new System.Windows.Forms.PictureBox();
            this.pnlSpace = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = global::PointOfSale_wf.Properties.Resources.closewindowapplication_32x32_azul;
            this.pbxClose.Location = new System.Drawing.Point(830, 2);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(25, 25);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 2;
            this.pbxClose.TabStop = false;
            // 
            // pbxMaximize
            // 
            this.pbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMaximize.Image = global::PointOfSale_wf.Properties.Resources.maximizethewindow_32x32_azul;
            this.pbxMaximize.Location = new System.Drawing.Point(804, 2);
            this.pbxMaximize.Name = "pbxMaximize";
            this.pbxMaximize.Size = new System.Drawing.Size(25, 25);
            this.pbxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaximize.TabIndex = 3;
            this.pbxMaximize.TabStop = false;
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimize.Image = global::PointOfSale_wf.Properties.Resources.minimize_thewindow_32x32_azul;
            this.pbxMinimize.Location = new System.Drawing.Point(778, 2);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimize.TabIndex = 4;
            this.pbxMinimize.TabStop = false;
            // 
            // pbxRestore
            // 
            this.pbxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRestore.Image = global::PointOfSale_wf.Properties.Resources.restoration_window_32x32_azul;
            this.pbxRestore.Location = new System.Drawing.Point(804, 2);
            this.pbxRestore.Name = "pbxRestore";
            this.pbxRestore.Size = new System.Drawing.Size(25, 25);
            this.pbxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRestore.TabIndex = 5;
            this.pbxRestore.TabStop = false;
            // 
            // pnlSpace
            // 
            this.pnlSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSpace.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlSpace.Name = "pnlSpace";
            this.pnlSpace.Size = new System.Drawing.Size(772, 29);
            this.pnlSpace.TabIndex = 6;
            // 
            // pnlFormControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlSpace);
            this.Controls.Add(this.pbxMinimize);
            this.Controls.Add(this.pbxMaximize);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.pbxRestore);
            this.Name = "pnlFormControl";
            this.Size = new System.Drawing.Size(858, 29);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxMaximize;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.PictureBox pbxRestore;
        private System.Windows.Forms.Panel pnlSpace;
    }
}
