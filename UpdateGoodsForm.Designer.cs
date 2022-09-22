namespace Coursework
{
    partial class UpdateGoodsForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.WH1Label = new System.Windows.Forms.Label();
            this.WH2Label = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriorityUpDown = new System.Windows.Forms.NumericUpDown();
            this.WH1UpDown = new System.Windows.Forms.NumericUpDown();
            this.WH2UpDown = new System.Windows.Forms.NumericUpDown();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.PriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.WH1CheckBox = new System.Windows.Forms.CheckBox();
            this.WH2CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WH1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WH2UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Enabled = false;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(33, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Enabled = false;
            this.PriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLabel.Location = new System.Drawing.Point(33, 57);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(71, 24);
            this.PriorityLabel.TabIndex = 1;
            this.PriorityLabel.Text = "Priority:";
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WH1Label
            // 
            this.WH1Label.AutoSize = true;
            this.WH1Label.Enabled = false;
            this.WH1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WH1Label.Location = new System.Drawing.Point(33, 93);
            this.WH1Label.Name = "WH1Label";
            this.WH1Label.Size = new System.Drawing.Size(168, 48);
            this.WH1Label.TabIndex = 2;
            this.WH1Label.Text = "Amount in\r\nthe 1st warehouse:";
            this.WH1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WH2Label
            // 
            this.WH2Label.AutoSize = true;
            this.WH2Label.Enabled = false;
            this.WH2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WH2Label.Location = new System.Drawing.Point(33, 153);
            this.WH2Label.Name = "WH2Label";
            this.WH2Label.Size = new System.Drawing.Size(177, 48);
            this.WH2Label.TabIndex = 3;
            this.WH2Label.Text = "Amount in\r\nthe 2nd warehouse:";
            this.WH2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(0, 228);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(384, 33);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(215, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(157, 26);
            this.NameTextBox.TabIndex = 5;
            // 
            // PriorityUpDown
            // 
            this.PriorityUpDown.Enabled = false;
            this.PriorityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityUpDown.Location = new System.Drawing.Point(215, 58);
            this.PriorityUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriorityUpDown.Name = "PriorityUpDown";
            this.PriorityUpDown.Size = new System.Drawing.Size(157, 26);
            this.PriorityUpDown.TabIndex = 9;
            this.PriorityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WH1UpDown
            // 
            this.WH1UpDown.Enabled = false;
            this.WH1UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WH1UpDown.Location = new System.Drawing.Point(215, 106);
            this.WH1UpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WH1UpDown.Name = "WH1UpDown";
            this.WH1UpDown.Size = new System.Drawing.Size(157, 26);
            this.WH1UpDown.TabIndex = 10;
            this.WH1UpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // WH2UpDown
            // 
            this.WH2UpDown.Enabled = false;
            this.WH2UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WH2UpDown.Location = new System.Drawing.Point(215, 166);
            this.WH2UpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WH2UpDown.Name = "WH2UpDown";
            this.WH2UpDown.Size = new System.Drawing.Size(157, 26);
            this.WH2UpDown.TabIndex = 11;
            this.WH2UpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(12, 29);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.NameCheckBox.TabIndex = 12;
            this.NameCheckBox.UseVisualStyleBackColor = true;
            this.NameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBox_CheckedChanged);
            // 
            // PriorityCheckBox
            // 
            this.PriorityCheckBox.AutoSize = true;
            this.PriorityCheckBox.Location = new System.Drawing.Point(12, 65);
            this.PriorityCheckBox.Name = "PriorityCheckBox";
            this.PriorityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PriorityCheckBox.TabIndex = 13;
            this.PriorityCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // WH1CheckBox
            // 
            this.WH1CheckBox.AutoSize = true;
            this.WH1CheckBox.Location = new System.Drawing.Point(12, 113);
            this.WH1CheckBox.Name = "WH1CheckBox";
            this.WH1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.WH1CheckBox.TabIndex = 14;
            this.WH1CheckBox.UseVisualStyleBackColor = true;
            this.WH1CheckBox.CheckedChanged += new System.EventHandler(this.WH1CheckBox_CheckedChanged);
            // 
            // WH2CheckBox
            // 
            this.WH2CheckBox.AutoSize = true;
            this.WH2CheckBox.Location = new System.Drawing.Point(12, 173);
            this.WH2CheckBox.Name = "WH2CheckBox";
            this.WH2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.WH2CheckBox.TabIndex = 15;
            this.WH2CheckBox.UseVisualStyleBackColor = true;
            this.WH2CheckBox.CheckedChanged += new System.EventHandler(this.WH2CheckBox_CheckedChanged);
            // 
            // UpdateGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.WH2CheckBox);
            this.Controls.Add(this.WH1CheckBox);
            this.Controls.Add(this.PriorityCheckBox);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.WH2UpDown);
            this.Controls.Add(this.WH1UpDown);
            this.Controls.Add(this.PriorityUpDown);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.WH2Label);
            this.Controls.Add(this.WH1Label);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateGoodsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PriorityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WH1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WH2UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label WH1Label;
        private System.Windows.Forms.Label WH2Label;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown PriorityUpDown;
        private System.Windows.Forms.NumericUpDown WH1UpDown;
        private System.Windows.Forms.NumericUpDown WH2UpDown;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox PriorityCheckBox;
        private System.Windows.Forms.CheckBox WH1CheckBox;
        private System.Windows.Forms.CheckBox WH2CheckBox;
    }
}