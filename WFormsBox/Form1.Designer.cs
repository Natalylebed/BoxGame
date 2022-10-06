
namespace WFormsBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_BoxeSise = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetSize
            // 
            this.GetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetSize.Location = new System.Drawing.Point(313, 152);
            this.GetSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetSize.Name = "GetSize";
            this.GetSize.Size = new System.Drawing.Size(84, 48);
            this.GetSize.TabIndex = 0;
            this.GetSize.Text = "ок";
            this.GetSize.UseVisualStyleBackColor = false;
            this.GetSize.Click += new System.EventHandler(this.GetSize_Click);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите размер поля";
            // 
            // textBox1_BoxeSise
            // 
            this.textBox1_BoxeSise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_BoxeSise.Location = new System.Drawing.Point(9, 37);
            this.textBox1_BoxeSise.Name = "textBox1_BoxeSise";
            this.textBox1_BoxeSise.Size = new System.Drawing.Size(388, 27);
            this.textBox1_BoxeSise.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(409, 213);
            this.Controls.Add(this.textBox1_BoxeSise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetSize);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SmartCube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_BoxeSise;
    }
}

