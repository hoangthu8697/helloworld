namespace Hello_World
{
    partial class frmHelloWorld
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShow.Location = new System.Drawing.Point(84, 190);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 37);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Hello World";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.Location = new System.Drawing.Point(5, 93);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 44);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnShow);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

