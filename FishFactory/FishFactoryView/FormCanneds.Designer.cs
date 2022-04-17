
namespace FishFactoryView
{
    partial class FormCanneds
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(467, 595);
            this.dataGridView.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(654, 47);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(86, 31);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(654, 87);
            this.Change_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(86, 31);
            this.Change_button.TabIndex = 2;
            this.Change_button.Text = "Изменить";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(654, 127);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(86, 31);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(654, 167);
            this.Update_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(86, 31);
            this.Update_button.TabIndex = 4;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // FormCanneds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCanneds";
            this.Text = "Консервы";
            this.Load += new System.EventHandler(this.FormCanneds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
    }
}