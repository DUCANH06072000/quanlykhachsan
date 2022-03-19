namespace QuanLy_KhachSan.quanly
{
    partial class Warehouse_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_Manager));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_solg = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.truoc = new System.Windows.Forms.Button();
            this.dau = new System.Windows.Forms.Button();
            this.sau = new System.Windows.Forms.Button();
            this.cuoi = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_luachon = new System.Windows.Forms.ComboBox();
            this.TK = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_solg = new System.Windows.Forms.Label();
            this.data_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý thông tin Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gía bán";
            // 
            // txt_solg
            // 
            this.txt_solg.Location = new System.Drawing.Point(491, 34);
            this.txt_solg.Name = "txt_solg";
            this.txt_solg.Size = new System.Drawing.Size(161, 24);
            this.txt_solg.TabIndex = 1;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(491, 77);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(161, 24);
            this.txt_gia.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_gianhap);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.txt_solg);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 155);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(142, 77);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(161, 24);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(143, 116);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(161, 24);
            this.txt_gianhap.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(142, 34);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(161, 24);
            this.txt_ma.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gía nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.truoc);
            this.groupBox2.Controls.Add(this.dau);
            this.groupBox2.Controls.Add(this.sau);
            this.groupBox2.Controls.Add(this.cuoi);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.cb_luachon);
            this.groupBox2.Controls.Add(this.TK);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_nhaplai);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.lbl_solg);
            this.groupBox2.Controls.Add(this.data_gridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 393);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // truoc
            // 
            this.truoc.Location = new System.Drawing.Point(57, 350);
            this.truoc.Name = "truoc";
            this.truoc.Size = new System.Drawing.Size(46, 26);
            this.truoc.TabIndex = 57;
            this.truoc.Text = "<";
            this.truoc.UseVisualStyleBackColor = true;
            this.truoc.Click += new System.EventHandler(this.truoc_Click);
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(5, 350);
            this.dau.Name = "dau";
            this.dau.Size = new System.Drawing.Size(46, 26);
            this.dau.TabIndex = 56;
            this.dau.Text = "<<";
            this.dau.UseVisualStyleBackColor = true;
            this.dau.Click += new System.EventHandler(this.dau_Click);
            // 
            // sau
            // 
            this.sau.Location = new System.Drawing.Point(109, 350);
            this.sau.Name = "sau";
            this.sau.Size = new System.Drawing.Size(50, 26);
            this.sau.TabIndex = 58;
            this.sau.Text = ">";
            this.sau.UseVisualStyleBackColor = true;
            this.sau.Click += new System.EventHandler(this.sau_Click);
            // 
            // cuoi
            // 
            this.cuoi.Location = new System.Drawing.Point(165, 350);
            this.cuoi.Name = "cuoi";
            this.cuoi.Size = new System.Drawing.Size(51, 26);
            this.cuoi.TabIndex = 59;
            this.cuoi.Text = ">>";
            this.cuoi.UseVisualStyleBackColor = true;
            this.cuoi.Click += new System.EventHandler(this.cuoi_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(370, 39);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(189, 24);
            this.txt_search.TabIndex = 54;
            this.txt_search.Text = "Nhập từ khóa....";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // cb_luachon
            // 
            this.cb_luachon.FormattingEnabled = true;
            this.cb_luachon.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.cb_luachon.Location = new System.Drawing.Point(165, 39);
            this.cb_luachon.Name = "cb_luachon";
            this.cb_luachon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_luachon.Size = new System.Drawing.Size(199, 26);
            this.cb_luachon.TabIndex = 53;
            this.cb_luachon.Text = "-- Lựa chọn trường tìm kiếm--";
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TK.Location = new System.Drawing.Point(29, 43);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(130, 20);
            this.TK.TabIndex = 55;
            this.TK.Text = "Tìm kiếm theo :";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(565, 290);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(173, 45);
            this.btn_thoat.TabIndex = 52;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nhaplai.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaplai.Image")));
            this.btn_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaplai.Location = new System.Drawing.Point(565, 235);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(173, 49);
            this.btn_nhaplai.TabIndex = 51;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(565, 186);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(173, 43);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(565, 88);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(173, 40);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(565, 134);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(173, 46);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_solg
            // 
            this.lbl_solg.AutoSize = true;
            this.lbl_solg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_solg.Location = new System.Drawing.Point(366, 353);
            this.lbl_solg.Name = "lbl_solg";
            this.lbl_solg.Size = new System.Drawing.Size(199, 20);
            this.lbl_solg.TabIndex = 46;
            this.lbl_solg.Text = "Số lượng bản ghi...........";
            // 
            // data_gridview
            // 
            this.data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridview.Location = new System.Drawing.Point(6, 69);
            this.data_gridview.Name = "data_gridview";
            this.data_gridview.Size = new System.Drawing.Size(553, 275);
            this.data_gridview.TabIndex = 0;
            this.data_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gridview_CellClick);
            // 
            // Warehouse_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouse_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn Hoa Mai";
            this.Load += new System.EventHandler(this.Warehouse_Manager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_solg;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button truoc;
        private System.Windows.Forms.Button dau;
        private System.Windows.Forms.Button sau;
        private System.Windows.Forms.Button cuoi;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_luachon;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_solg;
        private System.Windows.Forms.DataGridView data_gridview;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label6;

    }
}