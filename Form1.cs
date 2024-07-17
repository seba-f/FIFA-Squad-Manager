using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_Squad_Manager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Image logo = Image.FromFile("../Img/FC_Petrolul_Ploiesti.png");

			teamLogo.Image=ResizeImage(logo, (logo.Width*(int)(teamLogo.Height-0.05*teamLogo.Height))/logo.Height, (int)(teamLogo.Height-0.05*teamLogo.Height));
			teamLogo.SizeMode=PictureBoxSizeMode.CenterImage;
			if (clubLabel.BackColor.R+clubLabel.BackColor.G+clubLabel.BackColor.B>382.5)
				clubLabel.ForeColor=Color.Black;
			else
				clubLabel.ForeColor=Color.White;
		}

		public static Bitmap ResizeImage(Image image,int width,int height)
		{
			var destRect=new Rectangle(0,0,width,height);
			var destImage=new Bitmap(width,height);
			destImage.SetResolution(image.HorizontalResolution,image.VerticalResolution);
			using(var graphics=Graphics.FromImage(destImage))
			{
				graphics.CompositingMode=CompositingMode.SourceCopy;
				graphics.CompositingQuality=CompositingQuality.HighQuality;
				graphics.InterpolationMode=InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode=SmoothingMode.HighQuality;
				graphics.PixelOffsetMode=PixelOffsetMode.HighQuality;
				using(var wrapMode=new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
				}
			}
			return destImage;
		}

	}
}
