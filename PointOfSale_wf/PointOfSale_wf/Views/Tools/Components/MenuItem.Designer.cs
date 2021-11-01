
namespace PointOfSale_wf.Views.Tools.Components
{
    partial class MenuItem
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
            this.pbxMenuIcon = new System.Windows.Forms.PictureBox();
            this.btnMenuTitle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMenuIcon
            // 
            this.pbxMenuIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxMenuIcon.Location = new System.Drawing.Point(0, 0);
            this.pbxMenuIcon.Name = "pbxMenuIcon";
            this.pbxMenuIcon.Size = new System.Drawing.Size(50, 50);
            this.pbxMenuIcon.TabIndex = 0;
            this.pbxMenuIcon.TabStop = false;
            // 
            // btnMenuTitle
            // 
            this.btnMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuTitle.FlatAppearance.BorderSize = 0;
            this.btnMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTitle.Location = new System.Drawing.Point(50, 0);
            this.btnMenuTitle.Name = "btnMenuTitle";
            this.btnMenuTitle.Size = new System.Drawing.Size(150, 50);
            this.btnMenuTitle.TabIndex = 1;
            this.btnMenuTitle.Text = "Menu item";
            this.btnMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTitle.UseVisualStyleBackColor = true;
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMenuTitle);
            this.Controls.Add(this.pbxMenuIcon);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(200, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenuIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMenuIcon;
        private System.Windows.Forms.Button btnMenuTitle;
    }
}
