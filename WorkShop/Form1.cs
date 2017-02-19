using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WorkShop
{
    public partial class Form1 : Form
    {
        //関数の宣言
        int flag1 = 1;
        int flag2 = 1;
        int flag3 = 1;
        string FolderPath;
        string movie1, movie2, movie3;
        int count_top = 0;
        int count_org = 0;
        int count_par = 0;
        int count = 0;
        WindowsMediaPlayer player;

        public Form1()
        {
            InitializeComponent();
            musicList.Items.Add("情熱大陸OP");
            musicList.Items.Add("情熱大陸ED");
            musicList.Items.Add("プロフェッショナル");
            musicList.Items.Add("カンブリア宮殿");
            musicList.Items.Add("プロジェクトX");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Multiview Video Editor";
            TopView.uiMode = "none";
            OrgView.uiMode = "none";
            ParView.uiMode = "none";

            Play.SizeMode = PictureBoxSizeMode.StretchImage;
            Stop.SizeMode = PictureBoxSizeMode.StretchImage;
            PlaySpeed.SizeMode = PictureBoxSizeMode.StretchImage;
            PlaySpeedValue.SizeMode = PictureBoxSizeMode.StretchImage;
            Select.SizeMode = PictureBoxSizeMode.StretchImage;
            Create.SizeMode = PictureBoxSizeMode.StretchImage;
            fade.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Listen.SizeMode = PictureBoxSizeMode.StretchImage;

            Play.ImageLocation = @"C:\play_off.png";
            Stop.ImageLocation = @"C:\stop.png";
            PlaySpeed.ImageLocation = @"C:\playspeed.png";
            PlaySpeedValue.ImageLocation = @"C:\1.png";
            Select.ImageLocation = @"C:\select.png";
            Create.ImageLocation = @"C:\create.png";
            fade.ImageLocation = @"C:\fade.png";
            pictureBox1.ImageLocation = @"C:\music.png";
            Listen.ImageLocation = @"C:\Listen.jpg";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }


        Image createThumbnail(Image image, int w, int h)
        {
            Bitmap canvas = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, w, h);

            float fw = (float)w / (float)image.Width;
            float fh = (float)h / (float)image.Height;

            float scale = Math.Min(fw, fh);
            fw = image.Width * scale;
            fh = image.Height * scale;

            g.DrawImage(image, (w - fw) / 2, (h - fh) / 2, fw, fh);
            g.Dispose();

            return canvas;
        }
        
        private void Select_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"C:\Windows";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                flag1 = 0;
            }
            FolderPath = fbd.SelectedPath;
            flag2 = 0;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            flag3 = 1;
            if (flag2 == 0)
            {
                movie1 = FolderPath + "top.mp4";
                movie2 = FolderPath + "org.mp4";
                movie3 = FolderPath + "par.mp4";

                TopView.URL = movie1;
                TopView.stretchToFit = true;

                OrgView.URL = movie2;
                OrgView.stretchToFit = true;

                ParView.URL = movie3;
                ParView.stretchToFit = true;

                Play.ImageLocation = @"C:\play_on.png";

                flag2 = 1;

                CurrentPosition.Maximum = (int)TopView.currentMedia.duration;
                if (CurrentPosition.Maximum < (int)OrgView.currentMedia.duration)
                {
                    CurrentPosition.Maximum = (int)OrgView.currentMedia.duration;
                }
                if (CurrentPosition.Maximum < (int)ParView.currentMedia.duration)
                {
                    CurrentPosition.Maximum = (int)ParView.currentMedia.duration;
                }
            }
            else if (flag2 == 1)
            {
                TopView.Ctlcontrols.play();
                OrgView.Ctlcontrols.play();
                ParView.Ctlcontrols.play();
                Play.ImageLocation = @"C:\play_on.png";

            }
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.pause();
            OrgView.Ctlcontrols.pause();
            ParView.Ctlcontrols.pause();
            Play.ImageLocation = @"C:\play_off.png";

            timer1.Stop();
        }

        private void CurrentPosition_Scroll(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (double)CurrentPosition.Value;
            OrgView.Ctlcontrols.currentPosition = (double)CurrentPosition.Value;
            ParView.Ctlcontrols.currentPosition = (double)CurrentPosition.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentPosition.Value = (int)TopView.Ctlcontrols.currentPosition;
        }


        string command = "-i C:\\ffmpeg\\bin\\movie\\output1.mp4 ";

        private void Create_Click(object sender, EventArgs e)
        {
            int count_all = count_top + count_org + count_par;
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            
            for (int i = 1; i < count; i++)
            {

                if (i >= 2)
                {
                    command = command + "-i C:\\ffmpeg\\bin\\movie\\output" + i + ".mp4 ";
                }
            }
            
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @"" + command + "-filter_complex " + "\"concat=n=" + count + ":v=1:a=1\" C:\\ffmpeg\\bin\\movie\\output.mp4");
            
        }

        private void TopView_Enter(object sender, EventArgs e)
        {

            OpenCVTest.Class1.thumtop(CurrentPosition.Value);

            Bitmap bmp = new Bitmap(TopView.Width, TopView.Height);

            string url = "C:\\thum\\thum.png";
            string ImageDir = "C:\\thum";

            
            string[] pngFiles = System.IO.Directory.GetFiles(ImageDir, "*.png");

            int width = TopView.Width / 4;
            int height = TopView.Height / 4;


            imageList1.ImageSize = new Size(width, height);
            Thumbnail1.LargeImageList = imageList1;


            Image original = Bitmap.FromFile("C:\\thum\\thum.png");
            Image thumbnail = createThumbnail(original, TopView.Width, TopView.Height);

            imageList1.Images.Add(thumbnail);
            Thumbnail1.Items.Add("C:\\thum\\thum.png", count);

            original.Dispose();
            thumbnail.Dispose();
            count++;

            System.IO.File.Delete(url);
            
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            string command = @"-i C:\\ffmpeg\\bin\\top.mp4 -t 10 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            //count = count + 1;
            this.ActiveControl = this.dummy;
        }

        private void OrgView_Enter(object sender, EventArgs e)
        {
            OpenCVTest.Class1.thumorg(CurrentPosition.Value);

            Bitmap bmp = new Bitmap(OrgView.Width, OrgView.Height);

            string url = "C:\\thum\\thum.png";
            string ImageDir = "C:\\thum";


            string[] pngFiles = System.IO.Directory.GetFiles(ImageDir, "*.png");

            int width = TopView.Width / 4;
            int height = TopView.Height / 4;


            imageList1.ImageSize = new Size(width, height);
            Thumbnail1.LargeImageList = imageList1;


            Image original = Bitmap.FromFile("C:\\thum\\thum.png");
            Image thumbnail = createThumbnail(original, OrgView.Width, OrgView.Height);

            imageList1.Images.Add(thumbnail);
            Thumbnail1.Items.Add("C:\\thum\\thum.png", count);

            original.Dispose();
            thumbnail.Dispose();
            count++;

            System.IO.File.Delete(url);
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            string command = @"-i C:\\ffmpeg\\bin\\org.mp4 -t 10 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count  + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            //count = count + 1;
            this.ActiveControl = this.dummy;
        }

        private void ParView_Enter(object sender, EventArgs e)
        {
            OpenCVTest.Class1.thumpar(CurrentPosition.Value);

            Bitmap bmp = new Bitmap(TopView.Width, TopView.Height);

            string url = "C:\\thum\\thum.png";
            string ImageDir = "C:\\thum";


            string[] pngFiles = System.IO.Directory.GetFiles(ImageDir, "*.png");

            int width = TopView.Width / 4;
            int height = TopView.Height / 4;


            imageList1.ImageSize = new Size(width, height);
            Thumbnail1.LargeImageList = imageList1;


            Image original = Bitmap.FromFile("C:\\thum\\thum.png");
            Image thumbnail = createThumbnail(original, ParView.Width, ParView.Height);

            imageList1.Images.Add(thumbnail);
            Thumbnail1.Items.Add("C:\\thum\\thum.png", count);
            //Thumbnail1.ScrollIntoView("C:\\thum\\thum.png", count-1);
            original.Dispose();
            thumbnail.Dispose();
            count++;

            System.IO.File.Delete(url);
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            
            string command = @"-i C:\\ffmpeg\\bin\\par.mp4 -t 10 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            //count = count + 1;
            this.ActiveControl = this.dummy;
        }

        private void TopView_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 6:
                    //pictureBox16.ImageLocation = @"C:\missload.jpg";
                    break;

                case 13:
                    //pictureBox16.ImageLocation = @"C:\playing.png";
                    
                    CurrentPosition.Maximum = (int)TopView.currentMedia.duration;

                    OpenCVTest.Class1.Top();
                    top0.SizeMode = PictureBoxSizeMode.StretchImage;
                    top0.ImageLocation = @"C:\topvar\0.png";
                    top1.SizeMode = PictureBoxSizeMode.StretchImage;
                    top1.ImageLocation = @"C:\topvar\1.png";
                    top2.SizeMode = PictureBoxSizeMode.StretchImage;
                    top2.ImageLocation = @"C:\topvar\2.png";
                    top3.SizeMode = PictureBoxSizeMode.StretchImage;
                    top3.ImageLocation = @"C:\topvar\3.png";
                    top4.SizeMode = PictureBoxSizeMode.StretchImage;
                    top4.ImageLocation = @"C:\topvar\4.png";
                    top5.SizeMode = PictureBoxSizeMode.StretchImage;
                    top5.ImageLocation = @"C:\topvar\5.png";
                    top6.SizeMode = PictureBoxSizeMode.StretchImage;
                    top6.ImageLocation = @"C:\topvar\6.png";
                    top7.SizeMode = PictureBoxSizeMode.StretchImage;
                    top7.ImageLocation = @"C:\topvar\7.png";
                    top8.SizeMode = PictureBoxSizeMode.StretchImage;
                    top8.ImageLocation = @"C:\topvar\8.png";
                    top9.SizeMode = PictureBoxSizeMode.StretchImage;
                    top9.ImageLocation = @"C:\topvar\9.png";

                    OpenCVTest.Class1.Org();
                    org0.SizeMode = PictureBoxSizeMode.StretchImage;
                    org0.ImageLocation = @"C:\orgvar\0.png";
                    org1.SizeMode = PictureBoxSizeMode.StretchImage;
                    org1.ImageLocation = @"C:\orgvar\1.png";
                    org2.SizeMode = PictureBoxSizeMode.StretchImage;
                    org2.ImageLocation = @"C:\orgvar\2.png";
                    org3.SizeMode = PictureBoxSizeMode.StretchImage;
                    org3.ImageLocation = @"C:\orgvar\3.png";
                    org4.SizeMode = PictureBoxSizeMode.StretchImage;
                    org4.ImageLocation = @"C:\orgvar\4.png";
                    org5.SizeMode = PictureBoxSizeMode.StretchImage;
                    org5.ImageLocation = @"C:\orgvar\5.png";
                    org6.SizeMode = PictureBoxSizeMode.StretchImage;
                    org6.ImageLocation = @"C:\orgvar\6.png";
                    org7.SizeMode = PictureBoxSizeMode.StretchImage;
                    org7.ImageLocation = @"C:\orgvar\7.png";
                    org8.SizeMode = PictureBoxSizeMode.StretchImage;
                    org8.ImageLocation = @"C:\orgvar\8.png";
                    org9.SizeMode = PictureBoxSizeMode.StretchImage;
                    org9.ImageLocation = @"C:\orgvar\9.png";

                    OpenCVTest.Class1.Par();
                    par0.SizeMode = PictureBoxSizeMode.StretchImage;
                    par0.ImageLocation = @"C:\parvar\0.png";
                    par1.SizeMode = PictureBoxSizeMode.StretchImage;
                    par1.ImageLocation = @"C:\parvar\1.png";
                    par2.SizeMode = PictureBoxSizeMode.StretchImage;
                    par2.ImageLocation = @"C:\parvar\2.png";
                    par3.SizeMode = PictureBoxSizeMode.StretchImage;
                    par3.ImageLocation = @"C:\parvar\3.png";
                    par4.SizeMode = PictureBoxSizeMode.StretchImage;
                    par4.ImageLocation = @"C:\parvar\4.png";
                    par5.SizeMode = PictureBoxSizeMode.StretchImage;
                    par5.ImageLocation = @"C:\parvar\5.png";
                    par6.SizeMode = PictureBoxSizeMode.StretchImage;
                    par6.ImageLocation = @"C:\parvar\6.png";
                    par7.SizeMode = PictureBoxSizeMode.StretchImage;
                    par7.ImageLocation = @"C:\parvar\7.png";
                    par8.SizeMode = PictureBoxSizeMode.StretchImage;
                    par8.ImageLocation = @"C:\parvar\8.png";
                    par9.SizeMode = PictureBoxSizeMode.StretchImage;
                    par9.ImageLocation = @"C:\parvar\9.png";
                    
                    break;

                case 20:
                    //pictureBox16.ImageLocation = @"C:\wait.jpg";
                    break;


                default:
                    break;
            }
        }

        private void OrgView_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 6:
                    //pictureBox16.ImageLocation = @"C:\missload.jpg";
                    break;

                case 13:
                    //pictureBox16.ImageLocation = @"C:\playing.png";
                    if (CurrentPosition.Maximum < (int)OrgView.currentMedia.duration)
                    {
                        CurrentPosition.Maximum = (int)OrgView.currentMedia.duration;
                    }
                    break;

                case 20:
                    //pictureBox16.ImageLocation = @"C:\wait.jpg";
                    break;


                default:
                    break;
            }
        }

        private void ParView_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 6:
                    //pictureBox16.ImageLocation = @"C:\missload.jpg";
                    break;

                case 13:
                    //pictureBox16.ImageLocation = @"C:\playing.png";
                    if (CurrentPosition.Maximum < (int)ParView.currentMedia.duration)
                    {
                        CurrentPosition.Maximum = (int)ParView.currentMedia.duration;
                    }
                    break;

                case 20:
                    //pictureBox16.ImageLocation = @"C:\wait.jpg";
                    break;


                default:
                    break;
            }
        }

        private void top0_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
        }

        private void top1_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
        }

        private void top2_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
        }

        private void top3_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
        }

        private void top4_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
        }

        private void top5_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
        }

        private void top6_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
        }

        private void top7_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
        }

        private void top8_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
        }

        private void top9_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
        }

        private void org0_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
        }

        private void org1_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
        }

        private void org2_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
        }

        private void org3_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
        }

        private void org4_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
        }

        private void org5_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
        }

        private void org6_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
        }

        private void org7_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
        }

        private void org8_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
        }

        private void org9_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
        }

        private void par0_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0;
        }

        private void par1_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.1;
        }

        private void par2_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.2;
        }

        private void par3_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.3;
        }

        private void par4_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.4;
        }

        private void par5_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.5;
        }

        private void par6_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.6;
        }

        private void par7_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.7;
        }

        private void par8_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.8;
        }

        private void par9_Click(object sender, EventArgs e)
        {
            TopView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            OrgView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
            ParView.Ctlcontrols.currentPosition = (int)CurrentPosition.Maximum * 0.9;
        }

        private void dummy_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\movie\\output.mp4 -vcodec copy -map 0:0 C:\\ffmpeg\\bin\\destination.mp4");
            if (musicList.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\destination.mp4 -i C:\\ffmpeg\\bin\\情熱大陸s.mp3 -vcodec copy -acodec copy C:\\ffmpeg\\bin\\movie\\Newoutput.mp4");
            }else if (musicList.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\destination.mp4 -i C:\\ffmpeg\\bin\\情熱大陸e.mp3 -vcodec copy -acodec copy C:\\ffmpeg\\bin\\movie\\Newoutput.mp4");
            }
            else if (musicList.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\destination.mp4 -i C:\\ffmpeg\\bin\\Progress.mp3 -vcodec copy -acodec copy C:\\ffmpeg\\bin\\movie\\Newoutput.mp4");
            }
            else if (musicList.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\destination.mp4 -i C:\\ffmpeg\\bin\\カンブリア宮殿.mp3 -vcodec copy -acodec copy C:\\ffmpeg\\bin\\movie\\Newoutput.mp4");
            }
            else if (musicList.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\destination.mp4 -i C:\\ffmpeg\\bin\\地上の星.mp3 -vcodec copy -acodec copy C:\\ffmpeg\\bin\\movie\\Newoutput.mp4");
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listen_Click(object sender, EventArgs e)
        {
            //player.controls.stop();
            player = new WindowsMediaPlayer();
            if (musicList.SelectedIndex == 0)
            {
                player.settings.setMode("loop", false);
                player.URL = @"C:\\ffmpeg\\bin\\情熱大陸s.mp3";
            }
            else if (musicList.SelectedIndex == 1)
            {
                player.settings.setMode("loop", false);
                player.URL = @"C:\\ffmpeg\\bin\\情熱大陸e.mp3";
            }
            else if (musicList.SelectedIndex == 2)
            {
                player.settings.setMode("loop", false);
                player.URL = @"C:\\ffmpeg\\bin\\Progress.mp3";
            }
            else if (musicList.SelectedIndex == 3)
            {
                player.settings.setMode("loop", false);
                player.URL = @"C:\\ffmpeg\\bin\\カンブリア宮殿.mp3";
            }
            else if (musicList.SelectedIndex == 4)
            {
                player.settings.setMode("loop", false);
                player.URL = @"C:\\ffmpeg\\bin\\地上の星.mp3";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TopView.settings.rate = trackBar1.Value;
            OrgView.settings.rate = trackBar1.Value;
            ParView.settings.rate = trackBar1.Value;
            if (trackBar1.Value == 1)
            {
                PlaySpeedValue.ImageLocation = @"C:\1.png";
            }
            else if (trackBar1.Value == 2)
            {
                PlaySpeedValue.ImageLocation = @"C:\2.png";
            }
            else if (trackBar1.Value == 3)
            {
                PlaySpeedValue.ImageLocation = @"C:\3.png";
            }
            else if (trackBar1.Value == 4)
            {
                PlaySpeedValue.ImageLocation = @"C:\4.png";
            }
            else if (trackBar1.Value == 5)
            {
                PlaySpeedValue.ImageLocation = @"C:\5.png";
            }
            else if (trackBar1.Value == 6)
            {
                PlaySpeedValue.ImageLocation = @"C:\6.png";
            }
            else if (trackBar1.Value == 7)
            {
                PlaySpeedValue.ImageLocation = @"C:\7.png";
            }
            else if (trackBar1.Value == 8)
            {
                PlaySpeedValue.ImageLocation = @"C:\8.png";
            }
        }

        private void fade_Click(object sender, EventArgs e)
        {
            int count_all = count_top + count_org + count_par;
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            for (int i = 1; i <= count; i++){
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\movie\\input" + i + ".mp4 -vf fade=in:0:15,fade=out:29*10-15:15 C:\\ffmpeg\\bin\\movie\\output" + i + ".mp4");
            }
        }

        
    }
}
