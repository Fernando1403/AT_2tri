
namespace At_2_tri
{
    partial class Form1
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
            this.lblalt = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalt.Location = new System.Drawing.Point(33, 70);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(397, 16);
            this.lblalt.TabIndex = 0;
            this.lblalt.Text = "Coloque a altura do seu caminhão em metros (apenas o número):";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkg.Location = new System.Drawing.Point(33, 207);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(369, 16);
            this.lblkg.TabIndex = 1;
            this.lblkg.Text = "Coloque o peso do seu caminhão em kg (apenas o número):";
            // 
            // txtalt
            // 
            this.txtalt.Location = new System.Drawing.Point(45, 90);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(100, 20);
            this.txtalt.TabIndex = 2;
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(36, 227);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(100, 20);
            this.txtkg.TabIndex = 3;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(539, 152);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 4;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 402);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.lblalt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalt;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.Button btncal;
    }
}

