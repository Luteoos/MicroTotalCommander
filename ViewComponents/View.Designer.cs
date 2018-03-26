namespace TotalCOmmanderLab03
{
    partial class MainWIndow
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTotalComanderView1 = new TotalCOmmanderLab03.UCTotalComanderView();
            this.ucTotalComanderView2 = new TotalCOmmanderLab03.UCTotalComanderView();
            this.ucCopyDeleteCut1 = new TotalCOmmanderLab03.UCCopyDeleteCut();
            this.SuspendLayout();
            // 
            // ucTotalComanderView1
            // 
            this.ucTotalComanderView1.CurrentPath = "";
            this.ucTotalComanderView1.Location = new System.Drawing.Point(13, 13);
            this.ucTotalComanderView1.Name = "ucTotalComanderView1";
            this.ucTotalComanderView1.Size = new System.Drawing.Size(367, 393);
            this.ucTotalComanderView1.TabIndex = 0;
            // 
            // ucTotalComanderView2
            // 
            this.ucTotalComanderView2.CurrentPath = "";
            this.ucTotalComanderView2.Location = new System.Drawing.Point(387, 13);
            this.ucTotalComanderView2.Name = "ucTotalComanderView2";
            this.ucTotalComanderView2.Size = new System.Drawing.Size(367, 393);
            this.ucTotalComanderView2.TabIndex = 1;
            // 
            // ucCopyDeleteCut1
            // 
            this.ucCopyDeleteCut1.Location = new System.Drawing.Point(13, 413);
            this.ucCopyDeleteCut1.Name = "ucCopyDeleteCut1";
            this.ucCopyDeleteCut1.Size = new System.Drawing.Size(352, 54);
            //this.ucCopyDeleteCut1.TabIndex = 3;
            // 
            // MainWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 474);
            this.Controls.Add(this.ucCopyDeleteCut1);
            this.Controls.Add(this.ucTotalComanderView2);
            this.Controls.Add(this.ucTotalComanderView1);
            this.Name = "MainWIndow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTotalComanderView ucTotalComanderView1;
        private UCTotalComanderView ucTotalComanderView2;
        private UCCopyDeleteCut ucCopyDeleteCut1;
    }
}

