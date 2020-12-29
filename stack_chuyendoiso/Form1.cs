using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace stack_chuyendoiso
{
    public partial class Form1 : Form
    {
        int countmove;
        TimeSpan time;
        PictureBox [ ] disks;
        Stack<PictureBox> diskBanDau, diskTrungGian, diskKetThuc, firstClickedDisk, secondClickedDisk;
        const int diskfisrt = 531, diskHeight = 50, khoangcachdiadencoc = 28;
        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox [ ] { picDia1, picDia2 , picDia3,picDia4, picDia5, picDia6, picDia7, picDia8};
            picBatDau.Tag = diskBanDau = new Stack<PictureBox>();
            picTrungGian.Tag = diskTrungGian = new Stack<PictureBox>();
            picKetThuc.Tag = diskKetThuc = new Stack<PictureBox>();
        }

        //luật chơi
        private void btnLuatChoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ được di chuyển một lần trên một cọc. Đĩa nằm trên phải nhỏ hơn đĩa nằm dưới.", "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //chịu thua
        private void btnChiuThua_Click(object sender, EventArgs e)
        {
            countTime.Stop();
            //txSoLanDiChuyen.Enabled = false;
            btnChoi.Text = "Chơi";
            btnChiuThua.Enabled = false;
            numOptionSoDia.Enabled = true;
        }

        private void txTime_TextChanged(object sender, EventArgs e)
        {

        }


        //đếm thời gian
        private void countTime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            txTime.Text = string.Format("{0:00,}:{1:00}:{2:00} ", time.Hours, time.Minutes, time.Seconds);
        }
        //chơi
        private void btnChoi_Click(object sender, EventArgs e)
        {
            countTime.Stop();
            foreach ( PictureBox disk in disks )
            {
                //reset
                disk.Visible = false;
                time = new TimeSpan(0);
                countmove = 0;
                txTime.Text = "00:00:00";
                txSoLanDiChuyen.Text = "0 lần";
                diskBanDau.Clear();
                diskTrungGian.Clear();
                diskKetThuc.Clear();
                picBatDau.BorderStyle = picKetThuc.BorderStyle = picTrungGian.BorderStyle = BorderStyle.None;
                firstClickedDisk = secondClickedDisk = null;
                //khởi tạo chơi mới
                numOptionSoDia.Enabled = false;
                btnChiuThua.Enabled = true;
                btnChoi.Text = "Chơi Lại";
                int x = picBatDau.Location.X + khoangcachdiadencoc, y = diskfisrt;
                for ( int i = ( int )numOptionSoDia.Value - 1 ; i >= 0 ; --i, y -= diskHeight )
                {
                    disks [ i ].Location = new Point(x, y);
                    disks [ i ].Visible = true;
                    diskBanDau.Push(disks [ i ]);
                }
                countTime.Start();
            }

        }
        //chọn cọc
        private void pic_Click(object sender, EventArgs e)
        {
            //không được chơi
            if ( numOptionSoDia.Enabled ) return;
            PictureBox clickRod = (PictureBox)sender;
            Stack<PictureBox> diskOfClickedRod = (Stack<PictureBox>)clickRod.Tag;
            if ( firstClickedDisk == null )
            {
                if ( diskOfClickedRod.Count == 0 ) return;
                firstClickedDisk = diskOfClickedRod;
                clickRod.BorderStyle = BorderStyle.FixedSingle;
            }
            else if ( secondClickedDisk == null )
            {
                if ( diskOfClickedRod == firstClickedDisk )
                {
                    firstClickedDisk = null;
                    clickRod.BorderStyle = BorderStyle.None;
                    return;
                }
                secondClickedDisk = diskOfClickedRod;
                ProcessMovingDisk(clickRod);
            }
        }
        //quá trình di chuyển đĩa
        private void ProcessMovingDisk(PictureBox clickRod)
        {
            if ( secondClickedDisk.Count == 0 )
            {
                moveDisk(new Point(clickRod.Location.X + khoangcachdiadencoc, diskfisrt));
            }
            else
            {
                PictureBox firstTopDisk = firstClickedDisk.Peek();
                PictureBox secondTopDisk = secondClickedDisk.Peek();

                if ( int.Parse(firstTopDisk.Tag.ToString()) < int.Parse(secondTopDisk.Tag.ToString()) )

                    moveDisk(new Point(secondTopDisk.Location.X, secondTopDisk.Location.Y - diskHeight));

                else
                {
                    secondClickedDisk = null;
                }
            }
        }
        //di chuyển đĩa
        private void moveDisk(Point point)
        {
            PictureBox firstTopDisk = firstClickedDisk.Pop();
            firstTopDisk.Location = point;
            secondClickedDisk.Push(firstTopDisk);
            ++countmove;
            txSoLanDiChuyen.Text = string.Format("{0} Lần", countmove);
            firstClickedDisk = secondClickedDisk = null;
            picBatDau.BorderStyle = picKetThuc.BorderStyle = picTrungGian.BorderStyle = BorderStyle.None;

            if ( diskKetThuc.Count == numOptionSoDia.Value )
            {
                //Console.WriteLine(diskKetThuc);
                btnChiuThua.PerformClick();
                MessageBox.Show("Chúc mừng bạn đã hoàn thành trò chơi.", "Chúc mừng", MessageBoxButtons.OK);
            }
        }
        private void picDia_Click(object sender, EventArgs e)
        {
            PictureBox clickDisk = ( PictureBox )sender;
            if ( diskBanDau.Contains(clickDisk) )
            {
                pic_Click(picBatDau, new EventArgs());
            }
            else if ( diskTrungGian.Contains(clickDisk) )
            {
                pic_Click(picKetThuc, new EventArgs());
            }
            else if ( diskKetThuc.Contains(clickDisk) )
            {
                pic_Click(picTrungGian, new EventArgs());
            }
        }


    }
}
