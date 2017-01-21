namespace BridgeProblem
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nuRight = new System.Windows.Forms.NumericUpDown();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nuLeft = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Location = new System.Drawing.Point(464, 93);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(183, 23);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Start Simulation";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autos Lado Derecho";
            // 
            // nuRight
            // 
            this.nuRight.Location = new System.Drawing.Point(593, 13);
            this.nuRight.Name = "nuRight";
            this.nuRight.Size = new System.Drawing.Size(54, 20);
            this.nuRight.TabIndex = 3;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 15);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(437, 398);
            this.log.TabIndex = 4;
            this.log.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Auto Lado Izquierdo";
            // 
            // nuLeft
            // 
            this.nuLeft.Location = new System.Drawing.Point(593, 51);
            this.nuLeft.Name = "nuLeft";
            this.nuLeft.Size = new System.Drawing.Size(54, 20);
            this.nuLeft.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 425);
            this.Controls.Add(this.nuLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.nuRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuRight;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nuLeft;
    }
}

