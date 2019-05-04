namespace WindowsFormsApp1
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
            this.carYearLbl = new System.Windows.Forms.Label();
            this.carMakeLbl = new System.Windows.Forms.Label();
            this.carModelLbl = new System.Windows.Forms.Label();
            this.carMPGLbl = new System.Windows.Forms.Label();
            this.intlPurchasePrcLbl = new System.Windows.Forms.Label();
            this.annualRprCostLbl = new System.Windows.Forms.Label();
            this.calcLbl = new System.Windows.Forms.Label();
            this.calcFuelLbl = new System.Windows.Forms.Label();
            this.calcAllCostLbl = new System.Windows.Forms.Label();
            this.carOneLbl = new System.Windows.Forms.Label();
            this.carTwoLbl = new System.Windows.Forms.Label();
            this.carOneYrManufTxt = new System.Windows.Forms.TextBox();
            this.carTwoYrManufTxt = new System.Windows.Forms.TextBox();
            this.carOneMakeTxt = new System.Windows.Forms.TextBox();
            this.carTwoMakeTxt = new System.Windows.Forms.TextBox();
            this.carOneModelTxt = new System.Windows.Forms.TextBox();
            this.carTwoModelTxt = new System.Windows.Forms.TextBox();
            this.carOneMpgTxt = new System.Windows.Forms.TextBox();
            this.carTwoMpgTxt = new System.Windows.Forms.TextBox();
            this.carOnePurchPriceTxt = new System.Windows.Forms.TextBox();
            this.carTwoPurchPriceTxt = new System.Windows.Forms.TextBox();
            this.carOneRepairCostTxt = new System.Windows.Forms.TextBox();
            this.carTwoRepairCostTxt = new System.Windows.Forms.TextBox();
            this.carOneInsCostTxt = new System.Windows.Forms.TextBox();
            this.carTwoInsCostTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.annualInsCostLbl = new System.Windows.Forms.Label();
            this.calcCarOneFuelTxt = new System.Windows.Forms.Label();
            this.calcCarTwoFuelTxt = new System.Windows.Forms.Label();
            this.calcCarOneTotalTxt = new System.Windows.Forms.Label();
            this.calcCarTwoTotalTxt = new System.Windows.Forms.Label();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carYearLbl
            // 
            this.carYearLbl.AutoSize = true;
            this.carYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carYearLbl.Location = new System.Drawing.Point(13, 39);
            this.carYearLbl.Name = "carYearLbl";
            this.carYearLbl.Size = new System.Drawing.Size(146, 17);
            this.carYearLbl.TabIndex = 0;
            this.carYearLbl.Text = "Year Manufactured";
            // 
            // carMakeLbl
            // 
            this.carMakeLbl.AutoSize = true;
            this.carMakeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carMakeLbl.Location = new System.Drawing.Point(13, 73);
            this.carMakeLbl.Name = "carMakeLbl";
            this.carMakeLbl.Size = new System.Drawing.Size(46, 17);
            this.carMakeLbl.TabIndex = 1;
            this.carMakeLbl.Text = "Make";
            // 
            // carModelLbl
            // 
            this.carModelLbl.AutoSize = true;
            this.carModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLbl.Location = new System.Drawing.Point(13, 103);
            this.carModelLbl.Name = "carModelLbl";
            this.carModelLbl.Size = new System.Drawing.Size(51, 17);
            this.carModelLbl.TabIndex = 2;
            this.carModelLbl.Text = "Model";
            // 
            // carMPGLbl
            // 
            this.carMPGLbl.AutoSize = true;
            this.carMPGLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carMPGLbl.Location = new System.Drawing.Point(13, 135);
            this.carMPGLbl.Name = "carMPGLbl";
            this.carMPGLbl.Size = new System.Drawing.Size(242, 17);
            this.carMPGLbl.TabIndex = 3;
            this.carMPGLbl.Text = "Published Miles Per Gallon MPG";
            // 
            // intlPurchasePrcLbl
            // 
            this.intlPurchasePrcLbl.AutoSize = true;
            this.intlPurchasePrcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intlPurchasePrcLbl.Location = new System.Drawing.Point(13, 167);
            this.intlPurchasePrcLbl.Name = "intlPurchasePrcLbl";
            this.intlPurchasePrcLbl.Size = new System.Drawing.Size(158, 17);
            this.intlPurchasePrcLbl.TabIndex = 4;
            this.intlPurchasePrcLbl.Text = "Intial Purchase Price";
            // 
            // annualRprCostLbl
            // 
            this.annualRprCostLbl.AutoSize = true;
            this.annualRprCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualRprCostLbl.Location = new System.Drawing.Point(13, 200);
            this.annualRprCostLbl.Name = "annualRprCostLbl";
            this.annualRprCostLbl.Size = new System.Drawing.Size(148, 17);
            this.annualRprCostLbl.TabIndex = 5;
            this.annualRprCostLbl.Text = "Annual Repair Cost";
            // 
            // calcLbl
            // 
            this.calcLbl.AutoSize = true;
            this.calcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcLbl.Location = new System.Drawing.Point(13, 338);
            this.calcLbl.Name = "calcLbl";
            this.calcLbl.Size = new System.Drawing.Size(124, 17);
            this.calcLbl.TabIndex = 6;
            this.calcLbl.Text = "CALCULATIONS";
            // 
            // calcFuelLbl
            // 
            this.calcFuelLbl.AutoSize = true;
            this.calcFuelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcFuelLbl.Location = new System.Drawing.Point(13, 368);
            this.calcFuelLbl.Name = "calcFuelLbl";
            this.calcFuelLbl.Size = new System.Drawing.Size(260, 17);
            this.calcFuelLbl.TabIndex = 7;
            this.calcFuelLbl.Text = "Calculated 1 Year Total FUEL Cost";
            // 
            // calcAllCostLbl
            // 
            this.calcAllCostLbl.AutoSize = true;
            this.calcAllCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcAllCostLbl.Location = new System.Drawing.Point(13, 405);
            this.calcAllCostLbl.Name = "calcAllCostLbl";
            this.calcAllCostLbl.Size = new System.Drawing.Size(276, 17);
            this.calcAllCostLbl.TabIndex = 8;
            this.calcAllCostLbl.Text = "Calculated 5 Year Total of ALL Costs";
            // 
            // carOneLbl
            // 
            this.carOneLbl.AutoSize = true;
            this.carOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carOneLbl.Location = new System.Drawing.Point(359, 13);
            this.carOneLbl.Name = "carOneLbl";
            this.carOneLbl.Size = new System.Drawing.Size(68, 17);
            this.carOneLbl.TabIndex = 9;
            this.carOneLbl.Text = "Car One";
            // 
            // carTwoLbl
            // 
            this.carTwoLbl.AutoSize = true;
            this.carTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTwoLbl.Location = new System.Drawing.Point(558, 13);
            this.carTwoLbl.Name = "carTwoLbl";
            this.carTwoLbl.Size = new System.Drawing.Size(67, 17);
            this.carTwoLbl.TabIndex = 10;
            this.carTwoLbl.Text = "Car Two";
            // 
            // carOneYrManufTxt
            // 
            this.carOneYrManufTxt.Location = new System.Drawing.Point(362, 39);
            this.carOneYrManufTxt.Name = "carOneYrManufTxt";
            this.carOneYrManufTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneYrManufTxt.TabIndex = 11;
            // 
            // carTwoYrManufTxt
            // 
            this.carTwoYrManufTxt.Location = new System.Drawing.Point(561, 39);
            this.carTwoYrManufTxt.Name = "carTwoYrManufTxt";
            this.carTwoYrManufTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoYrManufTxt.TabIndex = 12;
            // 
            // carOneMakeTxt
            // 
            this.carOneMakeTxt.Location = new System.Drawing.Point(362, 70);
            this.carOneMakeTxt.Name = "carOneMakeTxt";
            this.carOneMakeTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneMakeTxt.TabIndex = 13;
            // 
            // carTwoMakeTxt
            // 
            this.carTwoMakeTxt.Location = new System.Drawing.Point(561, 70);
            this.carTwoMakeTxt.Name = "carTwoMakeTxt";
            this.carTwoMakeTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoMakeTxt.TabIndex = 14;
            // 
            // carOneModelTxt
            // 
            this.carOneModelTxt.Location = new System.Drawing.Point(362, 100);
            this.carOneModelTxt.Name = "carOneModelTxt";
            this.carOneModelTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneModelTxt.TabIndex = 15;
            // 
            // carTwoModelTxt
            // 
            this.carTwoModelTxt.Location = new System.Drawing.Point(561, 100);
            this.carTwoModelTxt.Name = "carTwoModelTxt";
            this.carTwoModelTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoModelTxt.TabIndex = 16;
            // 
            // carOneMpgTxt
            // 
            this.carOneMpgTxt.Location = new System.Drawing.Point(362, 132);
            this.carOneMpgTxt.Name = "carOneMpgTxt";
            this.carOneMpgTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneMpgTxt.TabIndex = 17;
            // 
            // carTwoMpgTxt
            // 
            this.carTwoMpgTxt.Location = new System.Drawing.Point(561, 132);
            this.carTwoMpgTxt.Name = "carTwoMpgTxt";
            this.carTwoMpgTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoMpgTxt.TabIndex = 18;
            // 
            // carOnePurchPriceTxt
            // 
            this.carOnePurchPriceTxt.Location = new System.Drawing.Point(362, 163);
            this.carOnePurchPriceTxt.Name = "carOnePurchPriceTxt";
            this.carOnePurchPriceTxt.Size = new System.Drawing.Size(143, 22);
            this.carOnePurchPriceTxt.TabIndex = 19;
            // 
            // carTwoPurchPriceTxt
            // 
            this.carTwoPurchPriceTxt.Location = new System.Drawing.Point(561, 163);
            this.carTwoPurchPriceTxt.Name = "carTwoPurchPriceTxt";
            this.carTwoPurchPriceTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoPurchPriceTxt.TabIndex = 20;
            // 
            // carOneRepairCostTxt
            // 
            this.carOneRepairCostTxt.Location = new System.Drawing.Point(362, 197);
            this.carOneRepairCostTxt.Name = "carOneRepairCostTxt";
            this.carOneRepairCostTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneRepairCostTxt.TabIndex = 21;
            // 
            // carTwoRepairCostTxt
            // 
            this.carTwoRepairCostTxt.Location = new System.Drawing.Point(561, 197);
            this.carTwoRepairCostTxt.Name = "carTwoRepairCostTxt";
            this.carTwoRepairCostTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoRepairCostTxt.TabIndex = 22;
            // 
            // carOneInsCostTxt
            // 
            this.carOneInsCostTxt.Location = new System.Drawing.Point(362, 229);
            this.carOneInsCostTxt.Name = "carOneInsCostTxt";
            this.carOneInsCostTxt.Size = new System.Drawing.Size(143, 22);
            this.carOneInsCostTxt.TabIndex = 23;
            // 
            // carTwoInsCostTxt
            // 
            this.carTwoInsCostTxt.Location = new System.Drawing.Point(561, 229);
            this.carTwoInsCostTxt.Name = "carTwoInsCostTxt";
            this.carTwoInsCostTxt.Size = new System.Drawing.Size(143, 22);
            this.carTwoInsCostTxt.TabIndex = 24;
            // 
            // calcBtn
            // 
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calcBtn.Location = new System.Drawing.Point(362, 277);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(340, 37);
            this.calcBtn.TabIndex = 25;
            this.calcBtn.Text = "Calculate Totals For Both Cars";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // annualInsCostLbl
            // 
            this.annualInsCostLbl.AutoSize = true;
            this.annualInsCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInsCostLbl.Location = new System.Drawing.Point(13, 232);
            this.annualInsCostLbl.Name = "annualInsCostLbl";
            this.annualInsCostLbl.Size = new System.Drawing.Size(171, 17);
            this.annualInsCostLbl.TabIndex = 26;
            this.annualInsCostLbl.Text = "Annual Insurance Cost";
            // 
            // calcCarOneFuelTxt
            // 
            this.calcCarOneFuelTxt.BackColor = System.Drawing.SystemColors.Control;
            this.calcCarOneFuelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCarOneFuelTxt.Location = new System.Drawing.Point(359, 368);
            this.calcCarOneFuelTxt.Name = "calcCarOneFuelTxt";
            this.calcCarOneFuelTxt.Size = new System.Drawing.Size(171, 17);
            this.calcCarOneFuelTxt.TabIndex = 27;
            // 
            // calcCarTwoFuelTxt
            // 
            this.calcCarTwoFuelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCarTwoFuelTxt.Location = new System.Drawing.Point(558, 368);
            this.calcCarTwoFuelTxt.Name = "calcCarTwoFuelTxt";
            this.calcCarTwoFuelTxt.Size = new System.Drawing.Size(171, 17);
            this.calcCarTwoFuelTxt.TabIndex = 28;
            // 
            // calcCarOneTotalTxt
            // 
            this.calcCarOneTotalTxt.BackColor = System.Drawing.SystemColors.Control;
            this.calcCarOneTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCarOneTotalTxt.Location = new System.Drawing.Point(359, 405);
            this.calcCarOneTotalTxt.Name = "calcCarOneTotalTxt";
            this.calcCarOneTotalTxt.Size = new System.Drawing.Size(171, 17);
            this.calcCarOneTotalTxt.TabIndex = 29;
            // 
            // calcCarTwoTotalTxt
            // 
            this.calcCarTwoTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcCarTwoTotalTxt.Location = new System.Drawing.Point(558, 405);
            this.calcCarTwoTotalTxt.Name = "calcCarTwoTotalTxt";
            this.calcCarTwoTotalTxt.Size = new System.Drawing.Size(171, 17);
            this.calcCarTwoTotalTxt.TabIndex = 30;
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(362, 470);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(342, 35);
            this.saveFileBtn.TabIndex = 31;
            this.saveFileBtn.Text = "Save Data to File";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 586);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.calcCarTwoTotalTxt);
            this.Controls.Add(this.calcCarOneTotalTxt);
            this.Controls.Add(this.calcCarTwoFuelTxt);
            this.Controls.Add(this.calcCarOneFuelTxt);
            this.Controls.Add(this.annualInsCostLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.carTwoInsCostTxt);
            this.Controls.Add(this.carOneInsCostTxt);
            this.Controls.Add(this.carTwoRepairCostTxt);
            this.Controls.Add(this.carOneRepairCostTxt);
            this.Controls.Add(this.carTwoPurchPriceTxt);
            this.Controls.Add(this.carOnePurchPriceTxt);
            this.Controls.Add(this.carTwoMpgTxt);
            this.Controls.Add(this.carOneMpgTxt);
            this.Controls.Add(this.carTwoModelTxt);
            this.Controls.Add(this.carOneModelTxt);
            this.Controls.Add(this.carTwoMakeTxt);
            this.Controls.Add(this.carOneMakeTxt);
            this.Controls.Add(this.carTwoYrManufTxt);
            this.Controls.Add(this.carOneYrManufTxt);
            this.Controls.Add(this.carTwoLbl);
            this.Controls.Add(this.carOneLbl);
            this.Controls.Add(this.calcAllCostLbl);
            this.Controls.Add(this.calcFuelLbl);
            this.Controls.Add(this.calcLbl);
            this.Controls.Add(this.annualRprCostLbl);
            this.Controls.Add(this.intlPurchasePrcLbl);
            this.Controls.Add(this.carMPGLbl);
            this.Controls.Add(this.carModelLbl);
            this.Controls.Add(this.carMakeLbl);
            this.Controls.Add(this.carYearLbl);
            this.Name = "Form1";
            this.Text = "Car Cost Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carYearLbl;
        private System.Windows.Forms.Label carMakeLbl;
        private System.Windows.Forms.Label carModelLbl;
        private System.Windows.Forms.Label carMPGLbl;
        private System.Windows.Forms.Label intlPurchasePrcLbl;
        private System.Windows.Forms.Label annualRprCostLbl;
        private System.Windows.Forms.Label calcLbl;
        private System.Windows.Forms.Label calcFuelLbl;
        private System.Windows.Forms.Label calcAllCostLbl;
        private System.Windows.Forms.Label carOneLbl;
        private System.Windows.Forms.Label carTwoLbl;
        private System.Windows.Forms.TextBox carOneYrManufTxt;
        private System.Windows.Forms.TextBox carTwoYrManufTxt;
        private System.Windows.Forms.TextBox carOneMakeTxt;
        private System.Windows.Forms.TextBox carTwoMakeTxt;
        private System.Windows.Forms.TextBox carOneModelTxt;
        private System.Windows.Forms.TextBox carTwoModelTxt;
        private System.Windows.Forms.TextBox carOneMpgTxt;
        private System.Windows.Forms.TextBox carTwoMpgTxt;
        private System.Windows.Forms.TextBox carOnePurchPriceTxt;
        private System.Windows.Forms.TextBox carTwoPurchPriceTxt;
        private System.Windows.Forms.TextBox carOneRepairCostTxt;
        private System.Windows.Forms.TextBox carTwoRepairCostTxt;
        private System.Windows.Forms.TextBox carOneInsCostTxt;
        private System.Windows.Forms.TextBox carTwoInsCostTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label annualInsCostLbl;
        private System.Windows.Forms.Label calcCarOneFuelTxt;
        private System.Windows.Forms.Label calcCarTwoFuelTxt;
        private System.Windows.Forms.Label calcCarOneTotalTxt;
        private System.Windows.Forms.Label calcCarTwoTotalTxt;
        private System.Windows.Forms.Button saveFileBtn;
    }
}

