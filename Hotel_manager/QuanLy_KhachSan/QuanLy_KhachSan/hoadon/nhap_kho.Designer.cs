namespace QuanLy_KhachSan.hoadon
{
    partial class nhap_kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhap_kho));
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_slgnhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_spkho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.db1 = new System.Windows.Forms.DataGridView();
            this.lb_Tile = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.TongTien = new System.Windows.Forms.Button();
            this.lb_tien = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_chietKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dta2 = new System.Windows.Forms.DataGridView();
            this.dta_mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tienchu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).BeginInit();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(549, 14);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(103, 20);
            this.date1.TabIndex = 69;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(533, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 34);
            this.button3.TabIndex = 56;
            this.button3.Text = "Nhập Lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(533, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 57;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txt_gianhap);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.txt_slgnhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_spkho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 143);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Loại sản phẩm";
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Enabled = false;
            this.txt_gianhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.Location = new System.Drawing.Point(116, 103);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(93, 23);
            this.txt_gianhap.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Gía Nhập";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Enabled = false;
            this.txt_tensp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensp.Location = new System.Drawing.Point(116, 64);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(168, 23);
            this.txt_tensp.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Enabled = false;
            this.txt_ma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(116, 25);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(72, 23);
            this.txt_ma.TabIndex = 0;
            this.txt_ma.TextChanged += new System.EventHandler(this.txt_mathuoc_TextChanged);
            // 
            // txt_slgnhap
            // 
            this.txt_slgnhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slgnhap.Location = new System.Drawing.Point(508, 66);
            this.txt_slgnhap.Name = "txt_slgnhap";
            this.txt_slgnhap.Size = new System.Drawing.Size(85, 23);
            this.txt_slgnhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng Nhập";
            // 
            // txt_spkho
            // 
            this.txt_spkho.Enabled = false;
            this.txt_spkho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_spkho.Location = new System.Drawing.Point(508, 27);
            this.txt_spkho.Name = "txt_spkho";
            this.txt_spkho.Size = new System.Drawing.Size(85, 23);
            this.txt_spkho.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng sản phẩm trong kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 113);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Tên Sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 2;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(20, 28);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(166, 37);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // db1
            // 
            this.db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db1.Location = new System.Drawing.Point(219, 44);
            this.db1.Name = "db1";
            this.db1.Size = new System.Drawing.Size(433, 113);
            this.db1.TabIndex = 52;
            this.db1.Click += new System.EventHandler(this.db1_Click);
            // 
            // lb_Tile
            // 
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.ForeColor = System.Drawing.Color.Red;
            this.lb_Tile.Location = new System.Drawing.Point(229, 9);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(177, 25);
            this.lb_Tile.TabIndex = 68;
            this.lb_Tile.Text = "Nhập Sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "Mã hóa đơn";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(479, 541);
            this.txt_mahd.Multiline = true;
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(177, 32);
            this.txt_mahd.TabIndex = 60;
            // 
            // TongTien
            // 
            this.TongTien.Image = ((System.Drawing.Image)(resources.GetObject("TongTien.Image")));
            this.TongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TongTien.Location = new System.Drawing.Point(533, 579);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(124, 35);
            this.TongTien.TabIndex = 61;
            this.TongTien.Text = "Xuat Excel";
            this.TongTien.UseVisualStyleBackColor = true;
            this.TongTien.Click += new System.EventHandler(this.TongTien_Click);
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.Location = new System.Drawing.Point(101, 591);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(76, 16);
            this.lb_tien.TabIndex = 66;
            this.lb_tien.Text = ".................";
            this.lb_tien.TextChanged += new System.EventHandler(this.lb_tien_TextChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(276, 312);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 34);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "( Ngàn Đồng )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Thành tiền:";
            // 
            // txt_chietKhau
            // 
            this.txt_chietKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chietKhau.Location = new System.Drawing.Point(104, 544);
            this.txt_chietKhau.Multiline = true;
            this.txt_chietKhau.Name = "txt_chietKhau";
            this.txt_chietKhau.Size = new System.Drawing.Size(39, 29);
            this.txt_chietKhau.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Chiếu Khấu";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(7, 312);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(119, 34);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dta2
            // 
            this.dta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dta_mathuoc,
            this.dta_tenthuoc,
            this.dta_giaban,
            this.dta_soluong,
            this.dta_tongTien});
            this.dta2.Location = new System.Drawing.Point(9, 352);
            this.dta2.Name = "dta2";
            this.dta2.Size = new System.Drawing.Size(643, 176);
            this.dta2.TabIndex = 58;
            this.dta2.Click += new System.EventHandler(this.dta2_Click);
            // 
            // dta_mathuoc
            // 
            this.dta_mathuoc.HeaderText = "Mã sản phẩm";
            this.dta_mathuoc.Name = "dta_mathuoc";
            this.dta_mathuoc.Width = 130;
            // 
            // dta_tenthuoc
            // 
            this.dta_tenthuoc.HeaderText = "Tên sản phẩm";
            this.dta_tenthuoc.Name = "dta_tenthuoc";
            this.dta_tenthuoc.Width = 130;
            // 
            // dta_giaban
            // 
            this.dta_giaban.HeaderText = "Giá bán";
            this.dta_giaban.Name = "dta_giaban";
            this.dta_giaban.Width = 110;
            // 
            // dta_soluong
            // 
            this.dta_soluong.HeaderText = "Số Lượng";
            this.dta_soluong.Name = "dta_soluong";
            this.dta_soluong.Width = 110;
            // 
            // dta_tongTien
            // 
            this.dta_tongTien.HeaderText = "Thành Tiền";
            this.dta_tongTien.Name = "dta_tongTien";
            this.dta_tongTien.Width = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 629);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "Thành chữ:";
            // 
            // txt_tienchu
            // 
            this.txt_tienchu.AutoSize = true;
            this.txt_tienchu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tienchu.Location = new System.Drawing.Point(101, 629);
            this.txt_tienchu.Name = "txt_tienchu";
            this.txt_tienchu.Size = new System.Drawing.Size(76, 16);
            this.txt_tienchu.TabIndex = 66;
            this.txt_tienchu.Text = ".................";
            // 
            // nhap_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(666, 663);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.db1);
            this.Controls.Add(this.lb_Tile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.txt_tienchu);
            this.Controls.Add(this.lb_tien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_chietKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dta2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nhap_kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn Hoa Mai";
            this.Load += new System.EventHandler(this.nhap_kho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_slgnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_spkho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView db1;
        private System.Windows.Forms.Label lb_Tile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Button TongTien;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_chietKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_tienchu;
    }
}