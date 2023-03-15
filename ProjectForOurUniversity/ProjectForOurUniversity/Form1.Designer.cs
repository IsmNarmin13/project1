namespace ProjectForOurUniversity
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AValueTextBox = new System.Windows.Forms.TextBox();
            this.BValueTextBox = new System.Windows.Forms.TextBox();
            this.EpsValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.functionsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findRootOfTheEquationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.findDerivativeButton = new System.Windows.Forms.Button();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value of a: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value of b:";
            // 
            // AValueTextBox
            // 
            this.AValueTextBox.Location = new System.Drawing.Point(100, 21);
            this.AValueTextBox.Name = "AValueTextBox";
            this.AValueTextBox.Size = new System.Drawing.Size(164, 27);
            this.AValueTextBox.TabIndex = 2;
            // 
            // BValueTextBox
            // 
            this.BValueTextBox.Location = new System.Drawing.Point(100, 70);
            this.BValueTextBox.Name = "BValueTextBox";
            this.BValueTextBox.Size = new System.Drawing.Size(164, 27);
            this.BValueTextBox.TabIndex = 3;
            // 
            // EpsValueTextBox
            // 
            this.EpsValueTextBox.Location = new System.Drawing.Point(108, 125);
            this.EpsValueTextBox.Name = "EpsValueTextBox";
            this.EpsValueTextBox.Size = new System.Drawing.Size(164, 27);
            this.EpsValueTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value of Eps:";
            // 
            // functionsComboBox
            // 
            this.functionsComboBox.FormattingEnabled = true;
            this.functionsComboBox.Location = new System.Drawing.Point(344, 44);
            this.functionsComboBox.Name = "functionsComboBox";
            this.functionsComboBox.Size = new System.Drawing.Size(164, 28);
            this.functionsComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Function selection";
            // 
            // findRootOfTheEquationButton
            // 
            this.findRootOfTheEquationButton.Location = new System.Drawing.Point(344, 89);
            this.findRootOfTheEquationButton.Name = "findRootOfTheEquationButton";
            this.findRootOfTheEquationButton.Size = new System.Drawing.Size(164, 74);
            this.findRootOfTheEquationButton.TabIndex = 8;
            this.findRootOfTheEquationButton.Text = "Find root of the equation";
            this.findRootOfTheEquationButton.UseVisualStyleBackColor = true;
            this.findRootOfTheEquationButton.Click += new System.EventHandler(this.findRootOfTheEquationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(128, 178);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(229, 34);
            this.resultTextBox.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(12, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(185, 87);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Point!";
            // 
            // pointTextBox
            // 
            this.pointTextBox.Location = new System.Drawing.Point(537, 45);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(131, 27);
            this.pointTextBox.TabIndex = 13;
            // 
            // findDerivativeButton
            // 
            this.findDerivativeButton.Location = new System.Drawing.Point(537, 128);
            this.findDerivativeButton.Name = "findDerivativeButton";
            this.findDerivativeButton.Size = new System.Drawing.Size(131, 74);
            this.findDerivativeButton.TabIndex = 14;
            this.findDerivativeButton.Text = "Find derivative in point";
            this.findDerivativeButton.UseVisualStyleBackColor = true;
            this.findDerivativeButton.Click += new System.EventHandler(this.findDerivativeButton_Click);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(537, 89);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(131, 28);
            this.ordersComboBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 334);
            this.Controls.Add(this.ordersComboBox);
            this.Controls.Add(this.findDerivativeButton);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.findRootOfTheEquationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.functionsComboBox);
            this.Controls.Add(this.EpsValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BValueTextBox);
            this.Controls.Add(this.AValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AValueTextBox;
        private System.Windows.Forms.TextBox BValueTextBox;
        private System.Windows.Forms.TextBox EpsValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox functionsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findRootOfTheEquationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.Button findDerivativeButton;
        private System.Windows.Forms.ComboBox ordersComboBox;
    }
}
