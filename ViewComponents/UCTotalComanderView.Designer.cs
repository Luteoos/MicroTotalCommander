namespace TotalCOmmanderLab03
{
     partial class UCTotalComanderView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPath = new System.Windows.Forms.TextBox();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.listDrivesInclude = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(3, 3);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new System.Drawing.Size(361, 22);
            this.textPath.TabIndex = 0;
            // 
            // cbDrives
            // 
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(310, 31);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(54, 24);
            this.cbDrives.TabIndex = 1;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            this.cbDrives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDrives_MouseClick);
            // 
            // listDrivesInclude
            // 
            this.listDrivesInclude.FormattingEnabled = true;
            this.listDrivesInclude.ItemHeight = 16;
            this.listDrivesInclude.Location = new System.Drawing.Point(3, 78);
            this.listDrivesInclude.Name = "listDrivesInclude";
            this.listDrivesInclude.Size = new System.Drawing.Size(361, 308);
            this.listDrivesInclude.TabIndex = 2;
            this.listDrivesInclude.SelectedIndexChanged += new System.EventHandler(this.listSelected);
            this.listDrivesInclude.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listDrivesInclude_MouseDoubleClick);
            // 
            // UCTotalComanderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDrivesInclude);
            this.Controls.Add(this.cbDrives);
            this.Controls.Add(this.textPath);
            this.Name = "UCTotalComanderView";
            this.Size = new System.Drawing.Size(367, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.ListBox listDrivesInclude;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
