namespace FishFactoryView
{
    partial class FormImplementer
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelWT = new System.Windows.Forms.Label();
            this.labelRT = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxWT = new System.Windows.Forms.TextBox();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(44, 39);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(139, 20);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО исполнителя:";
            // 
            // labelWT
            // 
            this.labelWT.AutoSize = true;
            this.labelWT.Location = new System.Drawing.Point(44, 95);
            this.labelWT.Name = "labelWT";
            this.labelWT.Size = new System.Drawing.Size(113, 20);
            this.labelWT.TabIndex = 1;
            this.labelWT.Text = "Время работы:";
            // 
            // labelRT
            // 
            this.labelRT.AutoSize = true;
            this.labelRT.Location = new System.Drawing.Point(44, 152);
            this.labelRT.Name = "labelRT";
            this.labelRT.Size = new System.Drawing.Size(110, 20);
            this.labelRT.TabIndex = 2;
            this.labelRT.Text = "Время отдыха:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(238, 32);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(221, 27);
            this.textBoxFIO.TabIndex = 3;
            // 
            // textBoxWT
            // 
            this.textBoxWT.Location = new System.Drawing.Point(238, 88);
            this.textBoxWT.Name = "textBoxWT";
            this.textBoxWT.Size = new System.Drawing.Size(221, 27);
            this.textBoxWT.TabIndex = 4;
            // 
            // textBoxPT
            // 
            this.textBoxPT.Location = new System.Drawing.Point(238, 145);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(221, 27);
            this.textBoxPT.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(238, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(365, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormImplementer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 304);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPT);
            this.Controls.Add(this.textBoxWT);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelRT);
            this.Controls.Add(this.labelWT);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormImplementer";
            this.Text = "Исполнитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFIO;
        private Label labelWT;
        private Label labelRT;
        private TextBox textBoxFIO;
        private TextBox textBoxWT;
        private TextBox textBoxPT;
        private Button buttonSave;
        private Button buttonCancel;
    }
}