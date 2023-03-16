namespace EmployeesAndProjects
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
            this.EmployeesAndProjects = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.Pairs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesAndProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pairs)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesAndProjects
            // 
            this.EmployeesAndProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesAndProjects.Location = new System.Drawing.Point(12, 90);
            this.EmployeesAndProjects.Name = "EmployeesAndProjects";
            this.EmployeesAndProjects.RowHeadersWidth = 51;
            this.EmployeesAndProjects.RowTemplate.Height = 24;
            this.EmployeesAndProjects.Size = new System.Drawing.Size(689, 425);
            this.EmployeesAndProjects.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parse and Display Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 49);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(527, 22);
            this.filePath.TabIndex = 2;
            // 
            // Pairs
            // 
            this.Pairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pairs.Location = new System.Drawing.Point(728, 96);
            this.Pairs.Name = "Pairs";
            this.Pairs.RowHeadersWidth = 51;
            this.Pairs.RowTemplate.Height = 24;
            this.Pairs.Size = new System.Drawing.Size(643, 419);
            this.Pairs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(814, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pair of employees who have worked together on common project for the longest time" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pairs);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeesAndProjects);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesAndProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesAndProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.DataGridView Pairs;
        private System.Windows.Forms.Label label1;
    }
}

