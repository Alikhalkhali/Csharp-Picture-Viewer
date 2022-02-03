
namespace Picture_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.picSample = new System.Windows.Forms.PictureBox();
            this.btnVisibility = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(257, 384);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(38, 23);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(182, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "<==";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(315, 384);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(38, 23);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(373, 384);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(55, 28);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "==>";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // picSample
            // 
            this.picSample.Location = new System.Drawing.Point(201, 130);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(193, 221);
            this.picSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSample.TabIndex = 9;
            this.picSample.TabStop = false;
            // 
            // btnVisibility
            // 
            this.btnVisibility.Location = new System.Drawing.Point(52, 223);
            this.btnVisibility.Name = "btnVisibility";
            this.btnVisibility.Size = new System.Drawing.Size(95, 45);
            this.btnVisibility.TabIndex = 10;
            this.btnVisibility.Text = "Hidden";
            this.btnVisibility.UseVisualStyleBackColor = true;
            this.btnVisibility.Click += new System.EventHandler(this.btnVisibility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 438);
            this.Controls.Add(this.btnVisibility);
            this.Controls.Add(this.picSample);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnZoomIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.Button btnVisibility;
    }
}

