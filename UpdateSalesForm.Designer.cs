namespace Coursework
{
    partial class UpdateSalesForm
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
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GoodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CountUpDown
            // 
            this.CountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUpDown.Location = new System.Drawing.Point(90, 58);
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(172, 26);
            this.CountUpDown.TabIndex = 9;
            this.CountUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GoodComboBox
            // 
            this.GoodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodComboBox.FormattingEnabled = true;
            this.GoodComboBox.Location = new System.Drawing.Point(90, 20);
            this.GoodComboBox.Name = "GoodComboBox";
            this.GoodComboBox.Size = new System.Drawing.Size(172, 28);
            this.GoodComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Good:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(91, 100);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(103, 40);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Name = "UpdateSalesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSalesForm";
            this.Load += new System.EventHandler(this.UpdateSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CountUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GoodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateButton;
    }
}