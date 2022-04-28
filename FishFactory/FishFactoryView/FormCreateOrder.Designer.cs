
namespace FishFactoryView
{
    partial class FormCreateOrder
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
            this.Canned_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Summ_label = new System.Windows.Forms.Label();
            this.Canned_comboBox = new System.Windows.Forms.ComboBox();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.Summ_textBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Client_label = new System.Windows.Forms.Label();
            this.Client_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Canned_label
            // 
            this.Canned_label.AutoSize = true;
            this.Canned_label.Location = new System.Drawing.Point(42, 87);
            this.Canned_label.Name = "Canned_label";
            this.Canned_label.Size = new System.Drawing.Size(71, 20);
            this.Canned_label.TabIndex = 0;
            this.Canned_label.Text = "Изделие:";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(42, 135);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(93, 20);
            this.Amount_label.TabIndex = 1;
            this.Amount_label.Text = "Количество:";
            // 
            // Summ_label
            // 
            this.Summ_label.AutoSize = true;
            this.Summ_label.Location = new System.Drawing.Point(42, 186);
            this.Summ_label.Name = "Summ_label";
            this.Summ_label.Size = new System.Drawing.Size(58, 20);
            this.Summ_label.TabIndex = 2;
            this.Summ_label.Text = "Сумма:";
            // 
            // Canned_comboBox
            // 
            this.Canned_comboBox.FormattingEnabled = true;
            this.Canned_comboBox.Location = new System.Drawing.Point(142, 83);
            this.Canned_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Canned_comboBox.Name = "Canned_comboBox";
            this.Canned_comboBox.Size = new System.Drawing.Size(214, 28);
            this.Canned_comboBox.TabIndex = 3;
            this.Canned_comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCanned_SelectedIndexChanged);
            this.Canned_comboBox.TextChanged += new System.EventHandler(this.comboBoxCars_SelectedIndexChanged);
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(142, 131);
            this.Amount_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(214, 27);
            this.Amount_textBox.TabIndex = 4;
            this.Amount_textBox.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // Summ_textBox
            // 
            this.Summ_textBox.Location = new System.Drawing.Point(142, 182);
            this.Summ_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Summ_textBox.Name = "Summ_textBox";
            this.Summ_textBox.Size = new System.Drawing.Size(214, 27);
            this.Summ_textBox.TabIndex = 5;
            this.Summ_textBox.TextChanged += new System.EventHandler(this.Summ_textBox_TextChanged);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(142, 242);
            this.Save_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(86, 31);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(271, 242);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(86, 31);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Client_label
            // 
            this.Client_label.AutoSize = true;
            this.Client_label.Location = new System.Drawing.Point(42, 38);
            this.Client_label.Name = "Client_label";
            this.Client_label.Size = new System.Drawing.Size(61, 20);
            this.Client_label.TabIndex = 8;
            this.Client_label.Text = "Клиент:";
            // 
            // Client_comboBox
            // 
            this.Client_comboBox.FormattingEnabled = true;
            this.Client_comboBox.Location = new System.Drawing.Point(143, 35);
            this.Client_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Client_comboBox.Name = "Client_comboBox";
            this.Client_comboBox.Size = new System.Drawing.Size(214, 28);
            this.Client_comboBox.TabIndex = 9;
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 334);
            this.Controls.Add(this.Client_comboBox);
            this.Controls.Add(this.Client_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Summ_textBox);
            this.Controls.Add(this.Amount_textBox);
            this.Controls.Add(this.Canned_comboBox);
            this.Controls.Add(this.Summ_label);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Canned_label);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Canned_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Label Summ_label;
        private System.Windows.Forms.ComboBox Canned_comboBox;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.TextBox Summ_textBox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private Label Client_label;
        private ComboBox Client_comboBox;
    }
}