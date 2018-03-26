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
            this.bCopy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(4, 4);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(111, 45);
            this.bCopy.TabIndex = 0;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.onClickButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // UCCopyDeleteCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bCopy);
            this.Name = "UCCopyDeleteCut";
            this.Size = new System.Drawing.Size(352, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
