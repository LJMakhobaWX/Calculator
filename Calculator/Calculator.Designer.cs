namespace Calculator
{
    partial class Calculator
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
            txtDisplay = new TextBox();
            btnSeven = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnZero = new Button();
            btnPoint = new Button();
            btnTwo = new Button();
            btnFive = new Button();
            btnEight = new Button();
            btnEquals = new Button();
            btnOne = new Button();
            btnSix = new Button();
            btnNine = new Button();
            btnPlusMinus = new Button();
            btnDivision = new Button();
            btnSubtraction = new Button();
            btnClear = new Button();
            btnPercentage = new Button();
            btnMultiplication = new Button();
            btnAddition = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(448, 43);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 12F);
            btnSeven.Location = new Point(3, 80);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 59);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 12F);
            btnFour.Location = new Point(3, 145);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 59);
            btnFour.TabIndex = 2;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 12F);
            btnThree.Location = new Point(165, 210);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 59);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F);
            btnZero.Location = new Point(3, 275);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 59);
            btnZero.TabIndex = 4;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Segoe UI", 12F);
            btnPoint.Location = new Point(84, 275);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(75, 59);
            btnPoint.TabIndex = 8;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 12F);
            btnTwo.Location = new Point(84, 210);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 59);
            btnTwo.TabIndex = 7;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 12F);
            btnFive.Location = new Point(84, 145);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 59);
            btnFive.TabIndex = 6;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 12F);
            btnEight.Location = new Point(84, 80);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 59);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 12F);
            btnEquals.Location = new Point(165, 275);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 59);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 12F);
            btnOne.Location = new Point(3, 210);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 59);
            btnOne.TabIndex = 11;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 12F);
            btnSix.Location = new Point(165, 145);
            btnSix.Name = "btnSix";
            btnSix.RightToLeft = RightToLeft.Yes;
            btnSix.Size = new Size(75, 59);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 12F);
            btnNine.Location = new Point(165, 80);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 59);
            btnNine.TabIndex = 9;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new Font("Segoe UI", 12F);
            btnPlusMinus.Location = new Point(295, 275);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(75, 59);
            btnPlusMinus.TabIndex = 16;
            btnPlusMinus.Text = "-/+";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 12F);
            btnDivision.Location = new Point(295, 210);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 59);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Font = new Font("Segoe UI", 12F);
            btnSubtraction.Location = new Point(295, 145);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(75, 59);
            btnSubtraction.TabIndex = 14;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(295, 80);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 59);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPercentage
            // 
            btnPercentage.Font = new Font("Segoe UI", 12F);
            btnPercentage.Location = new Point(376, 275);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(75, 59);
            btnPercentage.TabIndex = 20;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("Segoe UI", 12F);
            btnMultiplication.Location = new Point(376, 210);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(75, 59);
            btnMultiplication.TabIndex = 19;
            btnMultiplication.Text = "x";
            btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btnAddition
            // 
            btnAddition.Font = new Font("Segoe UI", 12F);
            btnAddition.Location = new Point(376, 145);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(75, 59);
            btnAddition.TabIndex = 18;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 342);
            Controls.Add(btnPercentage);
            Controls.Add(btnMultiplication);
            Controls.Add(btnAddition);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDivision);
            Controls.Add(btnSubtraction);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnOne);
            Controls.Add(btnSix);
            Controls.Add(btnNine);
            Controls.Add(btnPoint);
            Controls.Add(btnTwo);
            Controls.Add(btnFive);
            Controls.Add(btnEight);
            Controls.Add(btnZero);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnSeven);
            Controls.Add(txtDisplay);
            Name = "Calculator";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnSeven;
        private Button btnFour;
        private Button btnThree;
        private Button btnZero;
        private Button btnPoint;
        private Button btnTwo;
        private Button btnFive;
        private Button btnEight;
        private Button btnEquals;
        private Button btnOne;
        private Button btnSix;
        private Button btnNine;
        private Button btnPlusMinus;
        private Button btnDivision;
        private Button btnSubtraction;
        private Button btnClear;
        private Button btnPercentage;
        private Button btnMultiplication;
        private Button btnAddition;
    }
}
