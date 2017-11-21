namespace MissingNumbers
{
    partial class frmMissingNumbers
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFirstList = new System.Windows.Forms.GroupBox();
            this.gbSecondList = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.rtbValLst1 = new System.Windows.Forms.RichTextBox();
            this.rtbValLst2 = new System.Windows.Forms.RichTextBox();
            this.gbFirstList.SuspendLayout();
            this.gbSecondList.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFirstList
            // 
            this.gbFirstList.Controls.Add(this.rtbValLst1);
            this.gbFirstList.Location = new System.Drawing.Point(12, 12);
            this.gbFirstList.Name = "gbFirstList";
            this.gbFirstList.Size = new System.Drawing.Size(260, 83);
            this.gbFirstList.TabIndex = 0;
            this.gbFirstList.TabStop = false;
            this.gbFirstList.Text = "First List";
            // 
            // gbSecondList
            // 
            this.gbSecondList.Controls.Add(this.rtbValLst2);
            this.gbSecondList.Location = new System.Drawing.Point(12, 101);
            this.gbSecondList.Name = "gbSecondList";
            this.gbSecondList.Size = new System.Drawing.Size(260, 83);
            this.gbSecondList.TabIndex = 0;
            this.gbSecondList.TabStop = false;
            this.gbSecondList.Text = "Second List";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(77, 190);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find Missing Numbers";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.rtbResult);
            this.gbResult.Location = new System.Drawing.Point(12, 219);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(260, 90);
            this.gbResult.TabIndex = 0;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(9, 20);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(245, 64);
            this.rtbResult.TabIndex = 4;
            this.rtbResult.Text = "";
            // 
            // rtbValLst1
            // 
            this.rtbValLst1.Location = new System.Drawing.Point(6, 13);
            this.rtbValLst1.Name = "rtbValLst1";
            this.rtbValLst1.Size = new System.Drawing.Size(245, 64);
            this.rtbValLst1.TabIndex = 1;
            this.rtbValLst1.Text = "";
            // 
            // rtbValLst2
            // 
            this.rtbValLst2.Location = new System.Drawing.Point(6, 13);
            this.rtbValLst2.Name = "rtbValLst2";
            this.rtbValLst2.Size = new System.Drawing.Size(245, 64);
            this.rtbValLst2.TabIndex = 2;
            this.rtbValLst2.Text = "";
            // 
            // frmMissingNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gbSecondList);
            this.Controls.Add(this.gbFirstList);
            this.Name = "frmMissingNumbers";
            this.Text = "Missing Numbers";
            this.gbFirstList.ResumeLayout(false);
            this.gbSecondList.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFirstList;
        private System.Windows.Forms.GroupBox gbSecondList;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox rtbValLst1;
        private System.Windows.Forms.RichTextBox rtbValLst2;
    }
}

