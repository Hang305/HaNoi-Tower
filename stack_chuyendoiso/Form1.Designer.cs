namespace stack_chuyendoiso
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
            if ( disposing && ( components != null ) )
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
            this.components = new System.ComponentModel.Container();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbTrungGian = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.txTime = new System.Windows.Forms.TextBox();
            this.lbSoDia = new System.Windows.Forms.Label();
            this.lbDiChuyen = new System.Windows.Forms.Label();
            this.btnChoi = new System.Windows.Forms.Button();
            this.btnChiuThua = new System.Windows.Forms.Button();
            this.btnLuatChoi = new System.Windows.Forms.Button();
            this.numOptionSoDia = new System.Windows.Forms.NumericUpDown();
            this.txSoLanDiChuyen = new System.Windows.Forms.TextBox();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.picDia5 = new System.Windows.Forms.PictureBox();
            this.picDia3 = new System.Windows.Forms.PictureBox();
            this.picDia4 = new System.Windows.Forms.PictureBox();
            this.picDia6 = new System.Windows.Forms.PictureBox();
            this.picDia7 = new System.Windows.Forms.PictureBox();
            this.picDia8 = new System.Windows.Forms.PictureBox();
            this.picDia2 = new System.Windows.Forms.PictureBox();
            this.picDia1 = new System.Windows.Forms.PictureBox();
            this.picKetThuc = new System.Windows.Forms.PictureBox();
            this.picTrungGian = new System.Windows.Forms.PictureBox();
            this.picBatDau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionSoDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrungGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbStart.Location = new System.Drawing.Point(215, 678);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(107, 31);
            this.lbStart.TabIndex = 4;
            this.lbStart.Text = "Bắt đầu";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbEnd.Location = new System.Drawing.Point(1263, 678);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(114, 31);
            this.lbEnd.TabIndex = 4;
            this.lbEnd.Text = "Kết thúc";
            // 
            // lbTrungGian
            // 
            this.lbTrungGian.AutoSize = true;
            this.lbTrungGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTrungGian.Location = new System.Drawing.Point(721, 678);
            this.lbTrungGian.Name = "lbTrungGian";
            this.lbTrungGian.Size = new System.Drawing.Size(149, 31);
            this.lbTrungGian.TabIndex = 4;
            this.lbTrungGian.Text = "Trung Gian";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbThoiGian.Location = new System.Drawing.Point(1201, 24);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(95, 22);
            this.lbThoiGian.TabIndex = 4;
            this.lbThoiGian.Text = "Thời gian: ";
            // 
            // txTime
            // 
            this.txTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txTime.Location = new System.Drawing.Point(1302, 15);
            this.txTime.Name = "txTime";
            this.txTime.Size = new System.Drawing.Size(157, 45);
            this.txTime.TabIndex = 5;
            this.txTime.TextChanged += new System.EventHandler(this.txTime_TextChanged);
            // 
            // lbSoDia
            // 
            this.lbSoDia.AutoSize = true;
            this.lbSoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbSoDia.Location = new System.Drawing.Point(561, 24);
            this.lbSoDia.Name = "lbSoDia";
            this.lbSoDia.Size = new System.Drawing.Size(71, 22);
            this.lbSoDia.TabIndex = 4;
            this.lbSoDia.Text = "Số đĩa: ";
            // 
            // lbDiChuyen
            // 
            this.lbDiChuyen.AutoSize = true;
            this.lbDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbDiChuyen.Location = new System.Drawing.Point(561, 63);
            this.lbDiChuyen.Name = "lbDiChuyen";
            this.lbDiChuyen.Size = new System.Drawing.Size(153, 22);
            this.lbDiChuyen.TabIndex = 4;
            this.lbDiChuyen.Text = "Số lần di chuyển: ";
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnChoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChoi.Location = new System.Drawing.Point(565, 96);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(121, 36);
            this.btnChoi.TabIndex = 1;
            this.btnChoi.Text = "Chơi";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // btnChiuThua
            // 
            this.btnChiuThua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChiuThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnChiuThua.ForeColor = System.Drawing.Color.Black;
            this.btnChiuThua.Location = new System.Drawing.Point(727, 96);
            this.btnChiuThua.Name = "btnChiuThua";
            this.btnChiuThua.Size = new System.Drawing.Size(125, 36);
            this.btnChiuThua.TabIndex = 2;
            this.btnChiuThua.Text = "Chịu Thua";
            this.btnChiuThua.UseVisualStyleBackColor = false;
            this.btnChiuThua.Click += new System.EventHandler(this.btnChiuThua_Click);
            // 
            // btnLuatChoi
            // 
            this.btnLuatChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLuatChoi.Location = new System.Drawing.Point(896, 96);
            this.btnLuatChoi.Name = "btnLuatChoi";
            this.btnLuatChoi.Size = new System.Drawing.Size(124, 36);
            this.btnLuatChoi.TabIndex = 3;
            this.btnLuatChoi.Text = "Luật chơi";
            this.btnLuatChoi.UseVisualStyleBackColor = true;
            this.btnLuatChoi.Click += new System.EventHandler(this.btnLuatChoi_Click);
            // 
            // numOptionSoDia
            // 
            this.numOptionSoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOptionSoDia.Location = new System.Drawing.Point(727, 24);
            this.numOptionSoDia.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numOptionSoDia.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOptionSoDia.Name = "numOptionSoDia";
            this.numOptionSoDia.Size = new System.Drawing.Size(120, 27);
            this.numOptionSoDia.TabIndex = 0;
            this.numOptionSoDia.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txSoLanDiChuyen
            // 
            this.txSoLanDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSoLanDiChuyen.Location = new System.Drawing.Point(727, 58);
            this.txSoLanDiChuyen.Name = "txSoLanDiChuyen";
            this.txSoLanDiChuyen.Size = new System.Drawing.Size(120, 27);
            this.txSoLanDiChuyen.TabIndex = 7;
            // 
            // countTime
            // 
            this.countTime.Tick += new System.EventHandler(this.countTime_Tick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Location = new System.Drawing.Point(1302, 96);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // picDia5
            // 
            this.picDia5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDia5.Image = global::stack_chuyendoiso.Properties.Resources.coc54;
            this.picDia5.Location = new System.Drawing.Point(1089, 389);
            this.picDia5.Name = "picDia5";
            this.picDia5.Size = new System.Drawing.Size(437, 48);
            this.picDia5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia5.TabIndex = 8;
            this.picDia5.TabStop = false;
            this.picDia5.Tag = "5";
            this.picDia5.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia3
            // 
            this.picDia3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDia3.Image = global::stack_chuyendoiso.Properties.Resources.coc34;
            this.picDia3.Location = new System.Drawing.Point(1089, 293);
            this.picDia3.Name = "picDia3";
            this.picDia3.Size = new System.Drawing.Size(422, 48);
            this.picDia3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia3.TabIndex = 8;
            this.picDia3.TabStop = false;
            this.picDia3.Tag = "3";
            this.picDia3.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia4
            // 
            this.picDia4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDia4.Image = global::stack_chuyendoiso.Properties.Resources.coc43;
            this.picDia4.Location = new System.Drawing.Point(1089, 341);
            this.picDia4.Name = "picDia4";
            this.picDia4.Size = new System.Drawing.Size(437, 48);
            this.picDia4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia4.TabIndex = 8;
            this.picDia4.TabStop = false;
            this.picDia4.Tag = "4";
            this.picDia4.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia6
            // 
            this.picDia6.Image = global::stack_chuyendoiso.Properties.Resources.coc62;
            this.picDia6.Location = new System.Drawing.Point(1089, 437);
            this.picDia6.Name = "picDia6";
            this.picDia6.Size = new System.Drawing.Size(437, 48);
            this.picDia6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia6.TabIndex = 8;
            this.picDia6.TabStop = false;
            this.picDia6.Tag = "6";
            this.picDia6.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia7
            // 
            this.picDia7.Image = global::stack_chuyendoiso.Properties.Resources.coc73;
            this.picDia7.Location = new System.Drawing.Point(1089, 485);
            this.picDia7.Name = "picDia7";
            this.picDia7.Size = new System.Drawing.Size(437, 48);
            this.picDia7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia7.TabIndex = 8;
            this.picDia7.TabStop = false;
            this.picDia7.Tag = "7";
            this.picDia7.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia8
            // 
            this.picDia8.Image = global::stack_chuyendoiso.Properties.Resources.coc84;
            this.picDia8.Location = new System.Drawing.Point(1089, 531);
            this.picDia8.Name = "picDia8";
            this.picDia8.Size = new System.Drawing.Size(437, 48);
            this.picDia8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia8.TabIndex = 8;
            this.picDia8.TabStop = false;
            this.picDia8.Tag = "8";
            this.picDia8.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia2
            // 
            this.picDia2.Image = global::stack_chuyendoiso.Properties.Resources.coc22;
            this.picDia2.Location = new System.Drawing.Point(576, 531);
            this.picDia2.Name = "picDia2";
            this.picDia2.Size = new System.Drawing.Size(435, 48);
            this.picDia2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia2.TabIndex = 8;
            this.picDia2.TabStop = false;
            this.picDia2.Tag = "2";
            this.picDia2.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picDia1
            // 
            this.picDia1.Image = global::stack_chuyendoiso.Properties.Resources.coc12;
            this.picDia1.Location = new System.Drawing.Point(47, 531);
            this.picDia1.Name = "picDia1";
            this.picDia1.Size = new System.Drawing.Size(430, 48);
            this.picDia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDia1.TabIndex = 8;
            this.picDia1.TabStop = false;
            this.picDia1.Tag = "1";
            this.picDia1.Click += new System.EventHandler(this.picDia_Click);
            // 
            // picKetThuc
            // 
            this.picKetThuc.Image = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picKetThuc.InitialImage = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picKetThuc.Location = new System.Drawing.Point(1070, 144);
            this.picKetThuc.Name = "picKetThuc";
            this.picKetThuc.Size = new System.Drawing.Size(466, 507);
            this.picKetThuc.TabIndex = 3;
            this.picKetThuc.TabStop = false;
            this.picKetThuc.Tag = "2";
            this.picKetThuc.Click += new System.EventHandler(this.pic_Click);
            // 
            // picTrungGian
            // 
            this.picTrungGian.Image = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picTrungGian.InitialImage = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picTrungGian.Location = new System.Drawing.Point(557, 144);
            this.picTrungGian.Name = "picTrungGian";
            this.picTrungGian.Size = new System.Drawing.Size(466, 507);
            this.picTrungGian.TabIndex = 3;
            this.picTrungGian.TabStop = false;
            this.picTrungGian.Tag = "1";
            this.picTrungGian.Click += new System.EventHandler(this.pic_Click);
            // 
            // picBatDau
            // 
            this.picBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBatDau.Image = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picBatDau.InitialImage = global::stack_chuyendoiso.Properties.Resources.thap_HN;
            this.picBatDau.Location = new System.Drawing.Point(30, 144);
            this.picBatDau.Name = "picBatDau";
            this.picBatDau.Size = new System.Drawing.Size(466, 507);
            this.picBatDau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBatDau.TabIndex = 2;
            this.picBatDau.TabStop = false;
            this.picBatDau.Tag = "0";
            this.picBatDau.Click += new System.EventHandler(this.pic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 736);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picDia5);
            this.Controls.Add(this.picDia3);
            this.Controls.Add(this.picDia4);
            this.Controls.Add(this.picDia6);
            this.Controls.Add(this.picDia7);
            this.Controls.Add(this.picDia8);
            this.Controls.Add(this.picDia2);
            this.Controls.Add(this.picDia1);
            this.Controls.Add(this.txSoLanDiChuyen);
            this.Controls.Add(this.numOptionSoDia);
            this.Controls.Add(this.btnLuatChoi);
            this.Controls.Add(this.btnChiuThua);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.txTime);
            this.Controls.Add(this.lbTrungGian);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.lbDiChuyen);
            this.Controls.Add(this.lbSoDia);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.picKetThuc);
            this.Controls.Add(this.picTrungGian);
            this.Controls.Add(this.picBatDau);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tháp Hà Nội";
            this.Click += new System.EventHandler(this.pic_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numOptionSoDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrungGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBatDau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBatDau;
        private System.Windows.Forms.PictureBox picTrungGian;
        private System.Windows.Forms.PictureBox picKetThuc;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbTrungGian;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.TextBox txTime;
        private System.Windows.Forms.Label lbSoDia;
        private System.Windows.Forms.Label lbDiChuyen;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Button btnChiuThua;
        private System.Windows.Forms.Button btnLuatChoi;
        private System.Windows.Forms.NumericUpDown numOptionSoDia;
        private System.Windows.Forms.TextBox txSoLanDiChuyen;
        private System.Windows.Forms.PictureBox picDia2;
        private System.Windows.Forms.PictureBox picDia8;
        private System.Windows.Forms.PictureBox picDia7;
        private System.Windows.Forms.PictureBox picDia6;
        private System.Windows.Forms.PictureBox picDia4;
        private System.Windows.Forms.Timer countTime;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picDia1;
        private System.Windows.Forms.PictureBox picDia5;
        private System.Windows.Forms.PictureBox picDia3;
    }
}

