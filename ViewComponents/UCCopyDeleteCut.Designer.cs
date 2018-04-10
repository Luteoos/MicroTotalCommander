namespace TotalCOmmanderLab03
{
    partial class UCCopyDeleteCut
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
            this.Copy = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(4, 4);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(111, 45);
            this.Copy.TabIndex = 0;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.onClickButton);
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(121, 4);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(111, 45);
            this.Move.TabIndex = 1;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.onClickButton);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(238, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 45);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.onClickButton);
            // 
            // UCCopyDeleteCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.Copy);
            this.Name = "UCCopyDeleteCut";
            this.Size = new System.Drawing.Size(352, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button Delete;
    }
}
