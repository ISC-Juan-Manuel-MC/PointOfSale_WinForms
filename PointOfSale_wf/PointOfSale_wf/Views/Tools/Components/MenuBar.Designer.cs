
namespace PointOfSale_wf.Views.Tools.Components
{
    partial class MenuBar
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
            this.tlpMenuDistribution = new System.Windows.Forms.TableLayoutPanel();
            this.flpMenuItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.miLogout = new PointOfSale_wf.Views.Tools.Components.MenuItem();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMenuTitle = new System.Windows.Forms.Button();
            this.tlpMenuDistribution.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenuDistribution
            // 
            this.tlpMenuDistribution.ColumnCount = 1;
            this.tlpMenuDistribution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMenuDistribution.Controls.Add(this.flpMenuItemList, 0, 1);
            this.tlpMenuDistribution.Controls.Add(this.miLogout, 0, 2);
            this.tlpMenuDistribution.Controls.Add(this.pnlTitulo, 0, 0);
            this.tlpMenuDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuDistribution.Location = new System.Drawing.Point(0, 0);
            this.tlpMenuDistribution.Name = "tlpMenuDistribution";
            this.tlpMenuDistribution.RowCount = 3;
            this.tlpMenuDistribution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMenuDistribution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuDistribution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMenuDistribution.Size = new System.Drawing.Size(150, 300);
            this.tlpMenuDistribution.TabIndex = 0;
            // 
            // flpMenuItemList
            // 
            this.flpMenuItemList.AutoScroll = true;
            this.flpMenuItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuItemList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenuItemList.Location = new System.Drawing.Point(3, 53);
            this.flpMenuItemList.Name = "flpMenuItemList";
            this.flpMenuItemList.Size = new System.Drawing.Size(144, 194);
            this.flpMenuItemList.TabIndex = 0;
            this.flpMenuItemList.WrapContents = false;
            // 
            // miLogout
            // 
            this.miLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miLogout.Location = new System.Drawing.Point(3, 253);
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(144, 44);
            this.miLogout.TabIndex = 1;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnMenuTitle);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(144, 44);
            this.pnlTitulo.TabIndex = 2;
            // 
            // btnMenuTitle
            // 
            this.btnMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuTitle.FlatAppearance.BorderSize = 0;
            this.btnMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.btnMenuTitle.Name = "btnMenuTitle";
            this.btnMenuTitle.Size = new System.Drawing.Size(144, 44);
            this.btnMenuTitle.TabIndex = 3;
            this.btnMenuTitle.Text = "Nombre de la empresa";
            this.btnMenuTitle.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpMenuDistribution);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(150, 300);
            this.tlpMenuDistribution.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenuDistribution;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItemList;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnMenuTitle;
        private MenuItem miLogout;
    }
}
