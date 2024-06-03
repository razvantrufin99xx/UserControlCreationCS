namespace randomdinamic
{
    partial class rowseats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seat3 = new randomdinamic.seat();
            this.seat2 = new randomdinamic.seat();
            this.seat1 = new randomdinamic.seat();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seat3
            // 
            this.seat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat3.Location = new System.Drawing.Point(130, 21);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(52, 46);
            this.seat3.TabIndex = 2;
            // 
            // seat2
            // 
            this.seat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat2.Location = new System.Drawing.Point(71, 21);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(52, 46);
            this.seat2.TabIndex = 1;
            // 
            // seat1
            // 
            this.seat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seat1.Location = new System.Drawing.Point(12, 21);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(52, 46);
            this.seat1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // rowseats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seat3);
            this.Controls.Add(this.seat2);
            this.Controls.Add(this.seat1);
            this.Name = "rowseats";
            this.Size = new System.Drawing.Size(196, 80);
            this.Load += new System.EventHandler(this.rowseats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private seat seat1;
        private seat seat2;
        private seat seat3;
        private System.Windows.Forms.Label label1;
    }
}
