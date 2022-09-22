namespace Coursework
{
    partial class NewSaleForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(91, 100);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 40);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Good:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GoodComboBox
            // 
            this.GoodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodComboBox.FormattingEnabled = true;
            this.GoodComboBox.Location = new System.Drawing.Point(90, 20);
            this.GoodComboBox.Name = "GoodComboBox";
            this.GoodComboBox.Size = new System.Drawing.Size(172, 28);
            this.GoodComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CountUpDown
            // 
            this.CountUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUpDown.Location = new System.Drawing.Point(90, 58);
            this.CountUpDown.Name = "CountUpDown";
            this.CountUpDown.Size = new System.Drawing.Size(172, 26);
            this.CountUpDown.TabIndex = 4;
            this.CountUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // NewSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.CountUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSaleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sale";
            this.Load += new System.EventHandler(this.NewSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GoodComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CountUpDown;
    }
}