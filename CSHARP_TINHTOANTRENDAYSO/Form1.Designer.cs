namespace CSharp_TinhToanTrenDaySo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtBD = new TextBox();
            txtKT = new TextBox();
            txtTong = new TextBox();
            txtTich = new TextBox();
            txtTongChan = new TextBox();
            txtTongLe = new TextBox();
            btnTinh = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(286, 8);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 0;
            label1.Text = "Tính Toán Trên Dãy Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "kết quả :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 51);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới hạn của dãy số :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 51);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "số bắt đầu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 51);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "số kết thúc :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 130);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Tổng các số :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 160);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 6;
            label7.Text = "Tích các số:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 199);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 7;
            label8.Text = "Tổng các số chắn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 241);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 8;
            label9.Text = "Tổng các số lẻ:";
            label9.Click += label9_Click;
            // 
            // txtBD
            // 
            txtBD.Location = new Point(217, 45);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(51, 23);
            txtBD.TabIndex = 9;
            // 
            // txtKT
            // 
            txtKT.Location = new Point(382, 48);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(51, 23);
            txtKT.TabIndex = 9;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(110, 130);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(51, 23);
            txtTong.TabIndex = 9;
            // 
            // txtTich
            // 
            txtTich.Location = new Point(110, 159);
            txtTich.Name = "txtTich";
            txtTich.Size = new Size(51, 23);
            txtTich.TabIndex = 9;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(110, 199);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(51, 23);
            txtTongChan.TabIndex = 9;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(110, 241);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(51, 23);
            txtTongLe.TabIndex = 9;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(106, 316);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 10;
            btnTinh.Text = "Tính toán";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_07_31_182849;
            pictureBox1.Location = new Point(317, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 250);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnTinh);
            Controls.Add(txtTongLe);
            Controls.Add(txtTongChan);
            Controls.Add(txtTich);
            Controls.Add(txtTong);
            Controls.Add(txtKT);
            Controls.Add(txtBD);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBD;
        private TextBox txtKT;
        private TextBox txtTong;
        private TextBox txtTich;
        private TextBox txtTongChan;
        private TextBox txtTongLe;
        private Button btnTinh;
        private PictureBox pictureBox1;
    }
}
