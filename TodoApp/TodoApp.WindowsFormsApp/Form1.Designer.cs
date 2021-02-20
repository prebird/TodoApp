
namespace TodoApp.WindowsFormsApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.blnIsDone = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsDone = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "할 일:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(93, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(252, 31);
            this.txtTitle.TabIndex = 1;
            // 
            // blnIsDone
            // 
            this.blnIsDone.AutoSize = true;
            this.blnIsDone.Location = new System.Drawing.Point(93, 80);
            this.blnIsDone.Name = "blnIsDone";
            this.blnIsDone.Size = new System.Drawing.Size(74, 29);
            this.blnIsDone.TabIndex = 2;
            this.blnIsDone.Text = "완료";
            this.blnIsDone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-862, -96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "완 료:";
            // 
            // lblIsDone
            // 
            this.lblIsDone.AutoSize = true;
            this.lblIsDone.Location = new System.Drawing.Point(29, 80);
            this.lblIsDone.Name = "lblIsDone";
            this.lblIsDone.Size = new System.Drawing.Size(58, 25);
            this.lblIsDone.TabIndex = 4;
            this.lblIsDone.Text = "완 료:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(379, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 83);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(484, 278);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 439);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblIsDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blnIsDone);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "할 일 목록";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox blnIsDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

