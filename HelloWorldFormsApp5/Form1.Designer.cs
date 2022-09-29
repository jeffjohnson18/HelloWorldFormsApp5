namespace HelloWorldFormsApp5
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
            this.btnHelloButtonTest = new System.Windows.Forms.Button();
            this.lblHelloWorldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloButtonTest
            // 
            this.btnHelloButtonTest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelloButtonTest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHelloButtonTest.Location = new System.Drawing.Point(440, 78);
            this.btnHelloButtonTest.Name = "btnHelloButtonTest";
            this.btnHelloButtonTest.Size = new System.Drawing.Size(140, 50);
            this.btnHelloButtonTest.TabIndex = 0;
            this.btnHelloButtonTest.Text = "Click Here";
            this.btnHelloButtonTest.UseVisualStyleBackColor = true;
            this.btnHelloButtonTest.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // lblHelloWorldLabel
            // 
            this.lblHelloWorldLabel.AutoSize = true;
            this.lblHelloWorldLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHelloWorldLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelloWorldLabel.Location = new System.Drawing.Point(514, 181);
            this.lblHelloWorldLabel.Name = "lblHelloWorldLabel";
            this.lblHelloWorldLabel.Size = new System.Drawing.Size(80, 36);
            this.lblHelloWorldLabel.TabIndex = 1;
            this.lblHelloWorldLabel.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHelloWorldLabel);
            this.Controls.Add(this.btnHelloButtonTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHelloButtonTest;
        private Label lblHelloWorldLabel;
        private Label label1;
        private Label label2;
    }
}