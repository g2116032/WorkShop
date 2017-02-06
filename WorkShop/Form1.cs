using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private float WithRatio_Select; // ボタンの横幅の比率
        private float HeightRatio_Select; // ボタンの縦幅の比率
        private float XRation_Select; // ボタンのx座標位置の比率
        private float YRation_Select; // ボタンのy座標位置の比率

        private float WithRatio_PlaySpeed; // ボタンの横幅の比率
        private float HeightRatio_PlaySpeed; // ボタンの縦幅の比率
        private float XRation_PlaySpeed; // ボタンのx座標位置の比率
        private float YRation_PlaySpeed; // ボタンのy座標位置の比率

        private float WithRatio_PlaySpeedValue; // ボタンの横幅の比率
        private float HeightRatio_PlaySpeedValue; // ボタンの縦幅の比率
        private float XRation_PlaySpeedValue; // ボタンのx座標位置の比率
        private float YRation_PlaySpeedValue; // ボタンのy座標位置の比率

        private float WithRatio_trackBar1; // ボタンの横幅の比率
        private float HeightRatio_trackBar1; // ボタンの縦幅の比率
        private float XRation_trackBar1; // ボタンのx座標位置の比率
        private float YRation_trackBar1; // ボタンのy座標位置の比率

        private float WithRatio_TopView; // ボタンの横幅の比率
        private float HeightRatio_TopView; // ボタンの縦幅の比率
        private float XRation_TopView; // ボタンのx座標位置の比率
        private float YRation_TopView; // ボタンのy座標位置の比率

        private float WithRatio_OrgView; // ボタンの横幅の比率
        private float HeightRatio_OrgView; // ボタンの縦幅の比率
        private float XRation_OrgView; // ボタンのx座標位置の比率
        private float YRation_OrgView; // ボタンのy座標位置の比率

        private float WithRatio_ParView; // ボタンの横幅の比率
        private float HeightRatio_ParView; // ボタンの縦幅の比率
        private float XRation_ParView; // ボタンのx座標位置の比率
        private float YRation_ParView; // ボタンのy座標位置の比率

        private float WithRatio_Play; // ボタンの横幅の比率
        private float HeightRatio_Play; // ボタンの縦幅の比率
        private float XRation_Play; // ボタンのx座標位置の比率
        private float YRation_Play; // ボタンのy座標位置の比率

        private float WithRatio_Stop; // ボタンの横幅の比率
        private float HeightRatio_Stop; // ボタンの縦幅の比率
        private float XRation_Stop; // ボタンのx座標位置の比率
        private float YRation_Stop; // ボタンのy座標位置の比率

        private float WithRatio_CurrentPosition; // ボタンの横幅の比率
        private float HeightRatio_CurrentPosition; // ボタンの縦幅の比率
        private float XRation_CurrentPosition; // ボタンのx座標位置の比率
        private float YRation_CurrentPosition; // ボタンのy座標位置の比率

        private float WithRatio_Thumbnail1; // ボタンの横幅の比率
        private float HeightRatio_Thumbnail1; // ボタンの縦幅の比率
        private float XRation_Thumbnail1; // ボタンのx座標位置の比率
        private float YRation_Thumbnail1; // ボタンのy座標位置の比率

        private float WithRatio_Thumbnail2; // ボタンの横幅の比率
        private float HeightRatio_Thumbnail2; // ボタンの縦幅の比率
        private float XRation_Thumbnail2; // ボタンのx座標位置の比率
        private float YRation_Thumbnail2; // ボタンのy座標位置の比率

        private float WithRatio_Thumbnail3; // ボタンの横幅の比率
        private float HeightRatio_Thumbnail3; // ボタンの縦幅の比率
        private float XRation_Thumbnail3; // ボタンのx座標位置の比率
        private float YRation_Thumbnail3; // ボタンのy座標位置の比率

        private float WithRatio_fade; // ボタンの横幅の比率
        private float HeightRatio_fade; // ボタンの縦幅の比率
        private float XRation_fade; // ボタンのx座標位置の比率
        private float YRation_fade; // ボタンのy座標位置の比率

        private float WithRatio_Create; // ボタンの横幅の比率
        private float HeightRatio_Create; // ボタンの縦幅の比率
        private float XRation_Create; // ボタンのx座標位置の比率
        private float YRation_Create; // ボタンのy座標位置の比率

        private float WithRatio_top0; // ボタンの横幅の比率
        private float HeightRatio_top0; // ボタンの縦幅の比率
        private float XRation_top0; // ボタンのx座標位置の比率
        private float YRation_top0; // ボタンのy座標位置の比率
        private float WithRatio_top1; // ボタンの横幅の比率
        private float HeightRatio_top1; // ボタンの縦幅の比率
        private float XRation_top1; // ボタンのx座標位置の比率
        private float YRation_top1; // ボタンのy座標位置の比率
        private float WithRatio_top2; // ボタンの横幅の比率
        private float HeightRatio_top2; // ボタンの縦幅の比率
        private float XRation_top2; // ボタンのx座標位置の比率
        private float YRation_top2; // ボタンのy座標位置の比率
        private float WithRatio_top3; // ボタンの横幅の比率
        private float HeightRatio_top3; // ボタンの縦幅の比率
        private float XRation_top3; // ボタンのx座標位置の比率
        private float YRation_top3; // ボタンのy座標位置の比率
        private float WithRatio_top4; // ボタンの横幅の比率
        private float HeightRatio_top4; // ボタンの縦幅の比率
        private float XRation_top4; // ボタンのx座標位置の比率
        private float YRation_top4; // ボタンのy座標位置の比率
        private float WithRatio_top5; // ボタンの横幅の比率
        private float HeightRatio_top5; // ボタンの縦幅の比率
        private float XRation_top5; // ボタンのx座標位置の比率
        private float YRation_top5; // ボタンのy座標位置の比率
        private float WithRatio_top6; // ボタンの横幅の比率
        private float HeightRatio_top6; // ボタンの縦幅の比率
        private float XRation_top6; // ボタンのx座標位置の比率
        private float YRation_top6; // ボタンのy座標位置の比率
        private float WithRatio_top7; // ボタンの横幅の比率
        private float HeightRatio_top7; // ボタンの縦幅の比率
        private float XRation_top7; // ボタンのx座標位置の比率
        private float YRation_top7; // ボタンのy座標位置の比率
        private float WithRatio_top8; // ボタンの横幅の比率
        private float HeightRatio_top8; // ボタンの縦幅の比率
        private float XRation_top8; // ボタンのx座標位置の比率
        private float YRation_top8; // ボタンのy座標位置の比率
        private float WithRatio_top9; // ボタンの横幅の比率
        private float HeightRatio_top9; // ボタンの縦幅の比率
        private float XRation_top9; // ボタンのx座標位置の比率
        private float YRation_top9; // ボタンのy座標位置の比率

        private float WithRatio_org0; // ボタンの横幅の比率
        private float HeightRatio_org0; // ボタンの縦幅の比率
        private float XRation_org0; // ボタンのx座標位置の比率
        private float YRation_org0; // ボタンのy座標位置の比率
        private float WithRatio_org1; // ボタンの横幅の比率
        private float HeightRatio_org1; // ボタンの縦幅の比率
        private float XRation_org1; // ボタンのx座標位置の比率
        private float YRation_org1; // ボタンのy座標位置の比率
        private float WithRatio_org2; // ボタンの横幅の比率
        private float HeightRatio_org2; // ボタンの縦幅の比率
        private float XRation_org2; // ボタンのx座標位置の比率
        private float YRation_org2; // ボタンのy座標位置の比率
        private float WithRatio_org3; // ボタンの横幅の比率
        private float HeightRatio_org3; // ボタンの縦幅の比率
        private float XRation_org3; // ボタンのx座標位置の比率
        private float YRation_org3; // ボタンのy座標位置の比率
        private float WithRatio_org4; // ボタンの横幅の比率
        private float HeightRatio_org4; // ボタンの縦幅の比率
        private float XRation_org4; // ボタンのx座標位置の比率
        private float YRation_org4; // ボタンのy座標位置の比率
        private float WithRatio_org5; // ボタンの横幅の比率
        private float HeightRatio_org5; // ボタンの縦幅の比率
        private float XRation_org5; // ボタンのx座標位置の比率
        private float YRation_org5; // ボタンのy座標位置の比率
        private float WithRatio_org6; // ボタンの横幅の比率
        private float HeightRatio_org6; // ボタンの縦幅の比率
        private float XRation_org6; // ボタンのx座標位置の比率
        private float YRation_org6; // ボタンのy座標位置の比率
        private float WithRatio_org7; // ボタンの横幅の比率
        private float HeightRatio_org7; // ボタンの縦幅の比率
        private float XRation_org7; // ボタンのx座標位置の比率
        private float YRation_org7; // ボタンのy座標位置の比率
        private float WithRatio_org8; // ボタンの横幅の比率
        private float HeightRatio_org8; // ボタンの縦幅の比率
        private float XRation_org8; // ボタンのx座標位置の比率
        private float YRation_org8; // ボタンのy座標位置の比率
        private float WithRatio_org9; // ボタンの横幅の比率
        private float HeightRatio_org9; // ボタンの縦幅の比率
        private float XRation_org9; // ボタンのx座標位置の比率
        private float YRation_org9; // ボタンのy座標位置の比率

        private float WithRatio_par0; // ボタンの横幅の比率
        private float HeightRatio_par0; // ボタンの縦幅の比率
        private float XRation_par0; // ボタンのx座標位置の比率
        private float YRation_par0; // ボタンのy座標位置の比率
        private float WithRatio_par1; // ボタンの横幅の比率
        private float HeightRatio_par1; // ボタンの縦幅の比率
        private float XRation_par1; // ボタンのx座標位置の比率
        private float YRation_par1; // ボタンのy座標位置の比率
        private float WithRatio_par2; // ボタンの横幅の比率
        private float HeightRatio_par2; // ボタンの縦幅の比率
        private float XRation_par2; // ボタンのx座標位置の比率
        private float YRation_par2; // ボタンのy座標位置の比率
        private float WithRatio_par3; // ボタンの横幅の比率
        private float HeightRatio_par3; // ボタンの縦幅の比率
        private float XRation_par3; // ボタンのx座標位置の比率
        private float YRation_par3; // ボタンのy座標位置の比率
        private float WithRatio_par4; // ボタンの横幅の比率
        private float HeightRatio_par4; // ボタンの縦幅の比率
        private float XRation_par4; // ボタンのx座標位置の比率
        private float YRation_par4; // ボタンのy座標位置の比率
        private float WithRatio_par5; // ボタンの横幅の比率
        private float HeightRatio_par5; // ボタンの縦幅の比率
        private float XRation_par5; // ボタンのx座標位置の比率
        private float YRation_par5; // ボタンのy座標位置の比率
        private float WithRatio_par6; // ボタンの横幅の比率
        private float HeightRatio_par6; // ボタンの縦幅の比率
        private float XRation_par6; // ボタンのx座標位置の比率
        private float YRation_par6; // ボタンのy座標位置の比率
        private float WithRatio_par7; // ボタンの横幅の比率
        private float HeightRatio_par7; // ボタンの縦幅の比率
        private float XRation_par7; // ボタンのx座標位置の比率
        private float YRation_par7; // ボタンのy座標位置の比率
        private float WithRatio_par8; // ボタンの横幅の比率
        private float HeightRatio_par8; // ボタンの縦幅の比率
        private float XRation_par8; // ボタンのx座標位置の比率
        private float YRation_par8; // ボタンのy座標位置の比率
        private float WithRatio_par9; // ボタンの横幅の比率
        private float HeightRatio_par9; // ボタンの縦幅の比率
        private float XRation_par9; // ボタンのx座標位置の比率
        private float YRation_par9; // ボタンのy座標位置の比率


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

            Play.ImageLocation = @"C:\play_off.png";
            Stop.ImageLocation = @"C:\stop.png";
            PlaySpeed.ImageLocation = @"C:\playspeed.png";
            PlaySpeedValue.ImageLocation = @"C:\1.png";
            Select.ImageLocation = @"C:\select.png";
            Create.ImageLocation = @"C:\create.png";
            fade.ImageLocation = @"C:\fade.png";

            WithRatio_Select = (float)Select.Width / (float)ClientSize.Width;
            HeightRatio_Select = (float)Select.Height / (float)ClientSize.Height;
            XRation_Select = (float)Select.Location.X / (float)ClientSize.Width;
            YRation_Select = (float)Select.Location.Y / (float)ClientSize.Height;

            WithRatio_PlaySpeed = (float)PlaySpeed.Width / (float)ClientSize.Width;
            HeightRatio_PlaySpeed = (float)PlaySpeed.Height / (float)ClientSize.Height;
            XRation_PlaySpeed = (float)PlaySpeed.Location.X / (float)ClientSize.Width;
            YRation_PlaySpeed = (float)PlaySpeed.Location.Y / (float)ClientSize.Height;

            WithRatio_PlaySpeedValue = (float)PlaySpeedValue.Width / (float)ClientSize.Width;
            HeightRatio_PlaySpeedValue = (float)PlaySpeedValue.Height / (float)ClientSize.Height;
            XRation_PlaySpeedValue = (float)PlaySpeedValue.Location.X / (float)ClientSize.Width;
            YRation_PlaySpeedValue = (float)PlaySpeedValue.Location.Y / (float)ClientSize.Height;

            WithRatio_trackBar1 = (float)trackBar1.Width / (float)ClientSize.Width;
            HeightRatio_trackBar1 = (float)trackBar1.Height / (float)ClientSize.Height;
            XRation_trackBar1 = (float)trackBar1.Location.X / (float)ClientSize.Width;
            YRation_trackBar1 = (float)trackBar1.Location.Y / (float)ClientSize.Height;

            WithRatio_TopView = (float)TopView.Width / (float)ClientSize.Width;
            HeightRatio_TopView = (float)TopView.Height / (float)ClientSize.Height;
            XRation_TopView = (float)TopView.Location.X / (float)ClientSize.Width;
            YRation_TopView = (float)TopView.Location.Y / (float)ClientSize.Height;

            WithRatio_OrgView = (float)OrgView.Width / (float)ClientSize.Width;
            HeightRatio_OrgView = (float)OrgView.Height / (float)ClientSize.Height;
            XRation_OrgView = (float)OrgView.Location.X / (float)ClientSize.Width;
            YRation_OrgView = (float)OrgView.Location.Y / (float)ClientSize.Height;

            WithRatio_ParView = (float)ParView.Width / (float)ClientSize.Width;
            HeightRatio_ParView = (float)ParView.Height / (float)ClientSize.Height;
            XRation_ParView = (float)ParView.Location.X / (float)ClientSize.Width;
            YRation_ParView = (float)ParView.Location.Y / (float)ClientSize.Height;

            WithRatio_Play = (float)Play.Width / (float)ClientSize.Width;
            HeightRatio_Play = (float)Play.Height / (float)ClientSize.Height;
            XRation_Play = (float)Play.Location.X / (float)ClientSize.Width;
            YRation_Play = (float)Play.Location.Y / (float)ClientSize.Height;

            WithRatio_Stop = (float)Stop.Width / (float)ClientSize.Width;
            HeightRatio_Stop = (float)Stop.Height / (float)ClientSize.Height;
            XRation_Stop = (float)Stop.Location.X / (float)ClientSize.Width;
            YRation_Stop = (float)Stop.Location.Y / (float)ClientSize.Height;

            WithRatio_CurrentPosition = (float)CurrentPosition.Width / (float)ClientSize.Width;
            HeightRatio_CurrentPosition = (float)CurrentPosition.Height / (float)ClientSize.Height;
            XRation_CurrentPosition = (float)CurrentPosition.Location.X / (float)ClientSize.Width;
            YRation_CurrentPosition = (float)CurrentPosition.Location.Y / (float)ClientSize.Height;

            WithRatio_Thumbnail1 = (float)Thumbnail1.Width / (float)ClientSize.Width;
            HeightRatio_Thumbnail1 = (float)Thumbnail1.Height / (float)ClientSize.Height;
            XRation_Thumbnail1 = (float)Thumbnail1.Location.X / (float)ClientSize.Width;
            YRation_Thumbnail1 = (float)Thumbnail1.Location.Y / (float)ClientSize.Height;

            WithRatio_Thumbnail2 = (float)Thumbnail2.Width / (float)ClientSize.Width;
            HeightRatio_Thumbnail2 = (float)Thumbnail2.Height / (float)ClientSize.Height;
            XRation_Thumbnail2 = (float)Thumbnail2.Location.X / (float)ClientSize.Width;
            YRation_Thumbnail2 = (float)Thumbnail2.Location.Y / (float)ClientSize.Height;

            WithRatio_Thumbnail3 = (float)Thumbnail3.Width / (float)ClientSize.Width;
            HeightRatio_Thumbnail3 = (float)Thumbnail3.Height / (float)ClientSize.Height;
            XRation_Thumbnail3 = (float)Thumbnail3.Location.X / (float)ClientSize.Width;
            YRation_Thumbnail3 = (float)Thumbnail3.Location.Y / (float)ClientSize.Height;

            WithRatio_fade = (float)fade.Width / (float)ClientSize.Width;
            HeightRatio_fade = (float)fade.Height / (float)ClientSize.Height;
            XRation_fade = (float)fade.Location.X / (float)ClientSize.Width;
            YRation_fade = (float)fade.Location.Y / (float)ClientSize.Height;

            WithRatio_Create = (float)Create.Width / (float)ClientSize.Width;
            HeightRatio_Create = (float)Create.Height / (float)ClientSize.Height;
            XRation_Create = (float)Create.Location.X / (float)ClientSize.Width;
            YRation_Create = (float)Create.Location.Y / (float)ClientSize.Height;

            WithRatio_top0 = (float)top0.Width / (float)ClientSize.Width;
            HeightRatio_top0 = (float)top0.Height / (float)ClientSize.Height;
                       
            XRation_top0 = (float)top0.Location.X / (float)ClientSize.Width;
            YRation_top0 = (float)top0.Location.Y / (float)ClientSize.Height;
            XRation_top1 = (float)top1.Location.X / (float)ClientSize.Width;
            YRation_top1 = (float)top1.Location.Y / (float)ClientSize.Height;
            XRation_top2 = (float)top2.Location.X / (float)ClientSize.Width;
            YRation_top2 = (float)top2.Location.Y / (float)ClientSize.Height;
            XRation_top3 = (float)top3.Location.X / (float)ClientSize.Width;
            YRation_top3 = (float)top3.Location.Y / (float)ClientSize.Height;
            XRation_top4 = (float)top4.Location.X / (float)ClientSize.Width;
            YRation_top4 = (float)top4.Location.Y / (float)ClientSize.Height;
            XRation_top5 = (float)top5.Location.X / (float)ClientSize.Width;
            YRation_top5 = (float)top5.Location.Y / (float)ClientSize.Height;
            XRation_top6 = (float)top6.Location.X / (float)ClientSize.Width;
            YRation_top6 = (float)top6.Location.Y / (float)ClientSize.Height;
            XRation_top7 = (float)top7.Location.X / (float)ClientSize.Width;
            YRation_top7 = (float)top7.Location.Y / (float)ClientSize.Height;
            XRation_top8 = (float)top8.Location.X / (float)ClientSize.Width;
            YRation_top8 = (float)top8.Location.Y / (float)ClientSize.Height;
            XRation_top9 = (float)top9.Location.X / (float)ClientSize.Width;
            YRation_top9 = (float)top9.Location.Y / (float)ClientSize.Height;
            

            XRation_org0 = (float)org0.Location.X / (float)ClientSize.Width;
            YRation_org0 = (float)org0.Location.Y / (float)ClientSize.Height;
            XRation_org1 = (float)org1.Location.X / (float)ClientSize.Width;
            YRation_org1 = (float)org1.Location.Y / (float)ClientSize.Height;
            XRation_org2 = (float)org2.Location.X / (float)ClientSize.Width;
            YRation_org2 = (float)org2.Location.Y / (float)ClientSize.Height;
            XRation_org3 = (float)org3.Location.X / (float)ClientSize.Width;
            YRation_org3 = (float)org3.Location.Y / (float)ClientSize.Height;
            XRation_org4 = (float)org4.Location.X / (float)ClientSize.Width;
            YRation_org4 = (float)org4.Location.Y / (float)ClientSize.Height;
            XRation_org5 = (float)org5.Location.X / (float)ClientSize.Width;
            YRation_org5 = (float)org5.Location.Y / (float)ClientSize.Height;
            XRation_org6 = (float)org6.Location.X / (float)ClientSize.Width;
            YRation_org6 = (float)org6.Location.Y / (float)ClientSize.Height;
            XRation_org7 = (float)org7.Location.X / (float)ClientSize.Width;
            YRation_org7 = (float)org7.Location.Y / (float)ClientSize.Height;
            XRation_org8 = (float)org8.Location.X / (float)ClientSize.Width;
            YRation_org8 = (float)org8.Location.Y / (float)ClientSize.Height;
            XRation_org9 = (float)org9.Location.X / (float)ClientSize.Width;
            YRation_org9 = (float)org9.Location.Y / (float)ClientSize.Height;
            
            XRation_par0 = (float)par0.Location.X / (float)ClientSize.Width;
            YRation_par0 = (float)par0.Location.Y / (float)ClientSize.Height;
            XRation_par1 = (float)par1.Location.X / (float)ClientSize.Width;
            YRation_par1 = (float)par1.Location.Y / (float)ClientSize.Height;
            XRation_par2 = (float)par2.Location.X / (float)ClientSize.Width;
            YRation_par2 = (float)par2.Location.Y / (float)ClientSize.Height;
            XRation_par3 = (float)par3.Location.X / (float)ClientSize.Width;
            YRation_par3 = (float)par3.Location.Y / (float)ClientSize.Height;
            XRation_par4 = (float)par4.Location.X / (float)ClientSize.Width;
            YRation_par4 = (float)par4.Location.Y / (float)ClientSize.Height;
            XRation_par5 = (float)par5.Location.X / (float)ClientSize.Width;
            YRation_par5 = (float)par5.Location.Y / (float)ClientSize.Height;
            XRation_par6 = (float)par6.Location.X / (float)ClientSize.Width;
            YRation_par6 = (float)par6.Location.Y / (float)ClientSize.Height;
            XRation_par7 = (float)par7.Location.X / (float)ClientSize.Width;
            YRation_par7 = (float)par7.Location.Y / (float)ClientSize.Height;
            XRation_par8 = (float)par8.Location.X / (float)ClientSize.Width;
            YRation_par8 = (float)par8.Location.Y / (float)ClientSize.Height;
            XRation_par9 = (float)par9.Location.X / (float)ClientSize.Width;
            YRation_par9 = (float)par9.Location.Y / (float)ClientSize.Height;
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Point ControllerPosition = new Point();

            Select.Width = (int)(WithRatio_Select * (float)ClientSize.Width);
            Select.Height = (int)(HeightRatio_Select * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Select * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Select * (float)ClientSize.Height);
            Select.Location = ControllerPosition;

            PlaySpeed.Width = (int)(WithRatio_PlaySpeed * (float)ClientSize.Width);
            PlaySpeed.Height = (int)(HeightRatio_PlaySpeed * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_PlaySpeed * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_PlaySpeed * (float)ClientSize.Height);
            PlaySpeed.Location = ControllerPosition;

            PlaySpeedValue.Width = (int)(WithRatio_PlaySpeedValue * (float)ClientSize.Width);
            PlaySpeedValue.Height = (int)(HeightRatio_PlaySpeedValue * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_PlaySpeedValue * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_PlaySpeedValue * (float)ClientSize.Height);
            PlaySpeedValue.Location = ControllerPosition;

            trackBar1.Width = (int)(WithRatio_trackBar1 * (float)ClientSize.Width);
            trackBar1.Height = (int)(HeightRatio_trackBar1 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_trackBar1 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_trackBar1 * (float)ClientSize.Height);
            trackBar1.Location = ControllerPosition;

            TopView.Width = (int)(WithRatio_TopView * (float)ClientSize.Width);
            TopView.Height = (int)(HeightRatio_TopView * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_TopView * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_TopView * (float)ClientSize.Height);
            TopView.Location = ControllerPosition;

            OrgView.Width = (int)(WithRatio_OrgView * (float)ClientSize.Width);
            OrgView.Height = (int)(HeightRatio_OrgView * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_OrgView * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_OrgView * (float)ClientSize.Height);
            OrgView.Location = ControllerPosition;

            ParView.Width = (int)(WithRatio_ParView * (float)ClientSize.Width);
            ParView.Height = (int)(HeightRatio_ParView * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_ParView * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_ParView * (float)ClientSize.Height);
            ParView.Location = ControllerPosition;

            Play.Width = (int)(WithRatio_Play * (float)ClientSize.Width);
            Play.Height = (int)(HeightRatio_Play * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Play * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Play * (float)ClientSize.Height);
            Play.Location = ControllerPosition;

            Stop.Width = (int)(WithRatio_Stop * (float)ClientSize.Width);
            Stop.Height = (int)(HeightRatio_Stop * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Stop * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Stop * (float)ClientSize.Height);
            Stop.Location = ControllerPosition;

            CurrentPosition.Width = (int)(WithRatio_CurrentPosition * (float)ClientSize.Width);
            CurrentPosition.Height = (int)(HeightRatio_CurrentPosition * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_CurrentPosition * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_CurrentPosition * (float)ClientSize.Height);
            CurrentPosition.Location = ControllerPosition;

            Thumbnail1.Width = (int)(WithRatio_Thumbnail1 * (float)ClientSize.Width);
            Thumbnail1.Height = (int)(HeightRatio_Thumbnail1 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Thumbnail1 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Thumbnail1 * (float)ClientSize.Height);
            Thumbnail1.Location = ControllerPosition;

            Thumbnail2.Width = (int)(WithRatio_Thumbnail2 * (float)ClientSize.Width);
            Thumbnail2.Height = (int)(HeightRatio_Thumbnail2 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Thumbnail2 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Thumbnail2 * (float)ClientSize.Height);
            Thumbnail2.Location = ControllerPosition;

            Thumbnail3.Width = (int)(WithRatio_Thumbnail3 * (float)ClientSize.Width);
            Thumbnail3.Height = (int)(HeightRatio_Thumbnail3 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Thumbnail3 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Thumbnail3 * (float)ClientSize.Height);
            Thumbnail3.Location = ControllerPosition;

            fade.Width = (int)(WithRatio_fade * (float)ClientSize.Width);
            fade.Height = (int)(HeightRatio_fade * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_fade * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_fade * (float)ClientSize.Height);
            fade.Location = ControllerPosition;

            Create.Width = (int)(WithRatio_Create * (float)ClientSize.Width);
            Create.Height = (int)(HeightRatio_Create * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_Create * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_Create * (float)ClientSize.Height);
            Create.Location = ControllerPosition;

            top0.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top0.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top0 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top0 * (float)ClientSize.Height);
            top0.Location = ControllerPosition;
            
            top1.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top1.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top1 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top1 * (float)ClientSize.Height);
            top1.Location = ControllerPosition;
            top2.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top2.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top2 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top2 * (float)ClientSize.Height);
            top2.Location = ControllerPosition;
            top3.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top3.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top3 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top3 * (float)ClientSize.Height);
            top3.Location = ControllerPosition;
            top4.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top4.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top4 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top4 * (float)ClientSize.Height);
            top4.Location = ControllerPosition;
            top5.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top5.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top5 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top5 * (float)ClientSize.Height);
            top5.Location = ControllerPosition;
            top6.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top6.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top6 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top6 * (float)ClientSize.Height);
            top6.Location = ControllerPosition;
            top7.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top7.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top7 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top7 * (float)ClientSize.Height);
            top7.Location = ControllerPosition;
            top8.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top8.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top8 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top8 * (float)ClientSize.Height);
            top8.Location = ControllerPosition;
            top9.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            top9.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_top9 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_top9 * (float)ClientSize.Height);
            top9.Location = ControllerPosition;

            org0.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org0.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org0 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org0 * (float)ClientSize.Height);
            org0.Location = ControllerPosition;
            org1.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org1.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org1 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org1 * (float)ClientSize.Height);
            org1.Location = ControllerPosition;
            org2.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org2.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org2 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org2 * (float)ClientSize.Height);
            org2.Location = ControllerPosition;
            org3.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org3.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org3 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org3 * (float)ClientSize.Height);
            org3.Location = ControllerPosition;
            org4.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org4.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org4 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org4 * (float)ClientSize.Height);
            org4.Location = ControllerPosition;
            org5.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org5.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org5 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org5 * (float)ClientSize.Height);
            org5.Location = ControllerPosition;
            org6.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org6.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org6 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org6 * (float)ClientSize.Height);
            org6.Location = ControllerPosition;
            org7.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org7.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org7 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org7 * (float)ClientSize.Height);
            org7.Location = ControllerPosition;
            org8.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org8.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org8 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org8 * (float)ClientSize.Height);
            org8.Location = ControllerPosition;
            org9.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            org9.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_org9 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_org9 * (float)ClientSize.Height);
            org9.Location = ControllerPosition;

            par0.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par0.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par0 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par0 * (float)ClientSize.Height);
            par0.Location = ControllerPosition;
            par1.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par1.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par1 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par1 * (float)ClientSize.Height);
            par1.Location = ControllerPosition;
            par2.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par2.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par2 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par2 * (float)ClientSize.Height);
            par2.Location = ControllerPosition;
            par3.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par3.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par3 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par3 * (float)ClientSize.Height);
            par3.Location = ControllerPosition;
            par4.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par4.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par4 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par4 * (float)ClientSize.Height);
            par4.Location = ControllerPosition;
            par5.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par5.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par5 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par5 * (float)ClientSize.Height);
            par5.Location = ControllerPosition;
            par6.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par6.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par6 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par6 * (float)ClientSize.Height);
            par6.Location = ControllerPosition;
            par7.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par7.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par7 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par7 * (float)ClientSize.Height);
            par7.Location = ControllerPosition;
            par8.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par8.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par8 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par8 * (float)ClientSize.Height);
            par8.Location = ControllerPosition;
            par9.Width = (int)(WithRatio_top0 * (float)ClientSize.Width);
            par9.Height = (int)(HeightRatio_top0 * (float)ClientSize.Height);
            ControllerPosition.X = (int)(XRation_par9 * (float)ClientSize.Width);
            ControllerPosition.Y = (int)(YRation_par9 * (float)ClientSize.Height);
            par9.Location = ControllerPosition;
            
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
            
            for (int i = 1; i < count_all; i++)
            {

                if (i >= 2)
                {
                    command = command + "-i C:\\ffmpeg\\bin\\movie\\output" + i + ".mp4 ";
                }
            }
            
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @"" + command + "-filter_complex " + "\"concat=n=" + count_all + ":v=1:a=1\" C:\\ffmpeg\\bin\\movie\\output.mp4");
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
            Thumbnail1.Items.Add("C:\\thum\\thum.png", count_top);

            original.Dispose();
            thumbnail.Dispose();
            count_top++;

            System.IO.File.Delete(url);
            
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            string command = @"-i C:\\ffmpeg\\bin\\top.mp4 -t 4 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            count = count + 1;
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


            imageList2.ImageSize = new Size(width, height);
            Thumbnail2.LargeImageList = imageList2;


            Image original = Bitmap.FromFile("C:\\thum\\thum.png");
            Image thumbnail = createThumbnail(original, OrgView.Width, OrgView.Height);

            imageList2.Images.Add(thumbnail);
            Thumbnail2.Items.Add("C:\\thum\\thum.png", count_org);

            original.Dispose();
            thumbnail.Dispose();
            count_org++;

            System.IO.File.Delete(url);
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            string command = @"-i C:\\ffmpeg\\bin\\top.mp4 -t 4 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            count = count + 1;
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


            imageList3.ImageSize = new Size(width, height);
            Thumbnail3.LargeImageList = imageList3;


            Image original = Bitmap.FromFile("C:\\thum\\thum.png");
            Image thumbnail = createThumbnail(original, ParView.Width, ParView.Height);

            imageList3.Images.Add(thumbnail);
            Thumbnail3.Items.Add("C:\\thum\\thum.png", count_par);

            original.Dispose();
            thumbnail.Dispose();
            count_par++;

            System.IO.File.Delete(url);
            int start = CurrentPosition.Value - 2;
            int end = CurrentPosition.Value + 2;

            if (start <= 0)
            {
                start = 0;
            }
                
            string START = start.ToString();
            string END = end.ToString();
            
            string command = @"-i C:\\ffmpeg\\bin\\par.mp4 -t 4 -ss " + START + " C:\\ffmpeg\\bin\\movie\\input" + count + ".mp4";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", command);
            count = count + 1;
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
            for (int i = 1; i <= count_all; i++){
                System.Diagnostics.Process.Start("C:\\ffmpeg\\bin\\ffmpeg", @" -i C:\\ffmpeg\\bin\\movie\\input" + i + ".mp4 -vf fade=in:0:15,fade=out:101:15 C:\\ffmpeg\\bin\\movie\\output" + i + ".mp4");
            }
        }
    }
}
