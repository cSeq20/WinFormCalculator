namespace Calculator
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
            this.displayBox = new System.Windows.Forms.TextBox();
            this.n1Btn = new System.Windows.Forms.Button();
            this.n2Btn = new System.Windows.Forms.Button();
            this.n3Btn = new System.Windows.Forms.Button();
            this.n4Btn = new System.Windows.Forms.Button();
            this.n5Btn = new System.Windows.Forms.Button();
            this.n6Btn = new System.Windows.Forms.Button();
            this.n7Btn = new System.Windows.Forms.Button();
            this.n8Btn = new System.Windows.Forms.Button();
            this.n9Btn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.historyDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.Window;
            this.displayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(-1, 28);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(254, 45);
            this.displayBox.TabIndex = 0;
            this.displayBox.Text = "0";
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1Btn
            // 
            this.n1Btn.Location = new System.Drawing.Point(-1, 120);
            this.n1Btn.Name = "n1Btn";
            this.n1Btn.Size = new System.Drawing.Size(65, 54);
            this.n1Btn.TabIndex = 1;
            this.n1Btn.Text = "1";
            this.n1Btn.UseVisualStyleBackColor = true;
            this.n1Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n2Btn
            // 
            this.n2Btn.Location = new System.Drawing.Point(62, 120);
            this.n2Btn.Name = "n2Btn";
            this.n2Btn.Size = new System.Drawing.Size(65, 54);
            this.n2Btn.TabIndex = 2;
            this.n2Btn.Text = "2";
            this.n2Btn.UseVisualStyleBackColor = true;
            this.n2Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n3Btn
            // 
            this.n3Btn.Location = new System.Drawing.Point(125, 120);
            this.n3Btn.Name = "n3Btn";
            this.n3Btn.Size = new System.Drawing.Size(65, 54);
            this.n3Btn.TabIndex = 3;
            this.n3Btn.Text = "3";
            this.n3Btn.UseVisualStyleBackColor = true;
            this.n3Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n4Btn
            // 
            this.n4Btn.Location = new System.Drawing.Point(-1, 170);
            this.n4Btn.Name = "n4Btn";
            this.n4Btn.Size = new System.Drawing.Size(65, 54);
            this.n4Btn.TabIndex = 4;
            this.n4Btn.Text = "4";
            this.n4Btn.UseVisualStyleBackColor = true;
            this.n4Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n5Btn
            // 
            this.n5Btn.Location = new System.Drawing.Point(62, 170);
            this.n5Btn.Name = "n5Btn";
            this.n5Btn.Size = new System.Drawing.Size(65, 54);
            this.n5Btn.TabIndex = 5;
            this.n5Btn.Text = "5";
            this.n5Btn.UseVisualStyleBackColor = true;
            this.n5Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n6Btn
            // 
            this.n6Btn.Location = new System.Drawing.Point(125, 170);
            this.n6Btn.Name = "n6Btn";
            this.n6Btn.Size = new System.Drawing.Size(65, 54);
            this.n6Btn.TabIndex = 6;
            this.n6Btn.Text = "6";
            this.n6Btn.UseVisualStyleBackColor = true;
            this.n6Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n7Btn
            // 
            this.n7Btn.Location = new System.Drawing.Point(-1, 221);
            this.n7Btn.Name = "n7Btn";
            this.n7Btn.Size = new System.Drawing.Size(65, 54);
            this.n7Btn.TabIndex = 7;
            this.n7Btn.Text = "7";
            this.n7Btn.UseVisualStyleBackColor = true;
            this.n7Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n8Btn
            // 
            this.n8Btn.Location = new System.Drawing.Point(62, 221);
            this.n8Btn.Name = "n8Btn";
            this.n8Btn.Size = new System.Drawing.Size(65, 54);
            this.n8Btn.TabIndex = 8;
            this.n8Btn.Text = "8";
            this.n8Btn.UseVisualStyleBackColor = true;
            this.n8Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // n9Btn
            // 
            this.n9Btn.Location = new System.Drawing.Point(125, 221);
            this.n9Btn.Name = "n9Btn";
            this.n9Btn.Size = new System.Drawing.Size(65, 54);
            this.n9Btn.TabIndex = 9;
            this.n9Btn.Text = "9";
            this.n9Btn.UseVisualStyleBackColor = true;
            this.n9Btn.Click += new System.EventHandler(this.number_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Location = new System.Drawing.Point(125, 271);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(65, 54);
            this.dotBtn.TabIndex = 10;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(62, 271);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(65, 54);
            this.zeroBtn.TabIndex = 11;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.number_Click);
            // 
            // cBtn
            // 
            this.cBtn.Location = new System.Drawing.Point(-1, 72);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(65, 54);
            this.cBtn.TabIndex = 12;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(188, 271);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(65, 54);
            this.equalBtn.TabIndex = 13;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(188, 221);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(65, 54);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(188, 170);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(65, 54);
            this.minusBtn.TabIndex = 15;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.Location = new System.Drawing.Point(188, 120);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(65, 54);
            this.multBtn.TabIndex = 16;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(188, 72);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(65, 54);
            this.divideBtn.TabIndex = 17;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "+ -";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // percentBtn
            // 
            this.percentBtn.Location = new System.Drawing.Point(62, 72);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(65, 54);
            this.percentBtn.TabIndex = 19;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.operationBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 54);
            this.button3.TabIndex = 20;
            this.button3.Text = "x²";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // historyDisplay
            // 
            this.historyDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDisplay.Location = new System.Drawing.Point(-1, 0);
            this.historyDisplay.Multiline = true;
            this.historyDisplay.Name = "historyDisplay";
            this.historyDisplay.Size = new System.Drawing.Size(254, 29);
            this.historyDisplay.TabIndex = 21;
            this.historyDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 324);
            this.Controls.Add(this.historyDisplay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.percentBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.n9Btn);
            this.Controls.Add(this.n8Btn);
            this.Controls.Add(this.n7Btn);
            this.Controls.Add(this.n6Btn);
            this.Controls.Add(this.n5Btn);
            this.Controls.Add(this.n4Btn);
            this.Controls.Add(this.n3Btn);
            this.Controls.Add(this.n2Btn);
            this.Controls.Add(this.n1Btn);
            this.Controls.Add(this.displayBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button n1Btn;
        private System.Windows.Forms.Button n2Btn;
        private System.Windows.Forms.Button n3Btn;
        private System.Windows.Forms.Button n4Btn;
        private System.Windows.Forms.Button n5Btn;
        private System.Windows.Forms.Button n6Btn;
        private System.Windows.Forms.Button n7Btn;
        private System.Windows.Forms.Button n8Btn;
        private System.Windows.Forms.Button n9Btn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox historyDisplay;
    }
}

