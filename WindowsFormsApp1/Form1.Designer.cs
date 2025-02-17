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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBang = new System.Windows.Forms.TextBox();
            this.lstBCC = new System.Windows.Forms.ListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lstToanBo = new System.Windows.Forms.ListBox();
            this.btnTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TẠO BẢNG CỬU CHƯƠNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số tạo bảng:";
            // 
            // txtBang
            // 
            this.txtBang.Location = new System.Drawing.Point(185, 37);
            this.txtBang.Name = "txtBang";
            this.txtBang.Size = new System.Drawing.Size(100, 27);
            this.txtBang.TabIndex = 2;
            // 
            // lstBCC
            // 
            this.lstBCC.FormattingEnabled = true;
            this.lstBCC.ItemHeight = 19;
            this.lstBCC.Location = new System.Drawing.Point(52, 136);
            this.lstBCC.Name = "lstBCC";
            this.lstBCC.Size = new System.Drawing.Size(242, 213);
            this.lstBCC.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(52, 88);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(112, 38);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tạo";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lstToanBo
            // 
            this.lstToanBo.FormattingEnabled = true;
            this.lstToanBo.ItemHeight = 19;
            this.lstToanBo.Location = new System.Drawing.Point(318, 136);
            this.lstToanBo.Name = "lstToanBo";
            this.lstToanBo.Size = new System.Drawing.Size(255, 213);
            this.lstToanBo.TabIndex = 5;
            // 
            // btnTB
            // 
            this.btnTB.Location = new System.Drawing.Point(318, 88);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(126, 38);
            this.btnTB.TabIndex = 6;
            this.btnTB.Text = "Toàn bộ";
            this.btnTB.UseVisualStyleBackColor = true;
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 365);
            this.Controls.Add(this.btnTB);
            this.Controls.Add(this.lstToanBo);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lstBCC);
            this.Controls.Add(this.txtBang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBang;
        private System.Windows.Forms.ListBox lstBCC;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lstToanBo;
        private System.Windows.Forms.Button btnTB;
    }
}

