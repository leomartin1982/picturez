using System;
using System.Drawing.Imaging;
using System.Drawing;

namespace Troonie_Lib
{
	public class BlendFilter : AbstractFilter, IMultiImagesFilter
	{		
		#region IMultiImagesFilter
		public string[] ImagesPaths { get; set; }
		public Bitmap[] Images { get; set; }

		public void DisposeImages()
		{
			if (Images != null) {
				for (int i = 0; i < Images.Length; i++) {
					if (Images [i] != null) {
						Images [i].Dispose ();
						Images [i] = null;
					}
				}
				Images = null;
			}
		}
		#endregion IMultiImagesFilter

		/// <summary>
		/// Mix value in percent. Default: 0.5 (=50%), means both images to same parts.
		/// </summary>
		public double MixPercent { get; set; }

//		/// <summary> Image to compare. </summary>
//		public Bitmap CompareBitmap { get; set; }

		public BlendFilter()
		{
			SupportedSrcPixelFormat = PixelFormatFlags.All;
			SupportedDstPixelFormat = PixelFormatFlags.SameLikeSource;

			MixPercent = 0.5;
		}
			
		#region protected methods

		protected override void SetProperties (double[] filterProperties)
		{			
			MixPercent = filterProperties[3] / 100.0;
		}
			
		protected internal override unsafe void Process(BitmapData srcData, BitmapData dstData)
		{
			int w = srcData.Width;
			int h = srcData.Height;
			int stride = srcData.Stride;
			PixelFormat pf = srcData.PixelFormat;
			int ps = Image.GetPixelFormatSize(pf) / 8;
			int psCompare = Image.GetPixelFormatSize(Images[1].PixelFormat) / 8;
			Rectangle rect = new Rectangle(0, 0, w, h);
			BitmapData compareData = Images[1].LockBits(
				rect, ImageLockMode.ReadOnly, Images[1].PixelFormat);		

			int offset = stride - w * ps;
			int compareOffset = compareData.Stride - w * psCompare;

			byte* src = (byte*)srcData.Scan0.ToPointer();
			byte* comp = (byte*)compareData.Scan0.ToPointer();
			byte* dst = (byte*)dstData.Scan0.ToPointer();

			// for each line
			for (int y = 0; y < h; y++)
			{
				// for each pixel
				for (int x = 0; x < w; x++, src += ps, dst += ps, comp += psCompare)
				{
					// 8 bit grayscale
					dst[RGBA.B] = (byte)(Math.Round(
						MixPercent * src[RGBA.B] + (1 - MixPercent) * comp[RGBA.B]));

					// rgb, 24 and 32 bit
					if (ps >= 3) {
						dst[RGBA.G] = (byte)(Math.Round(
							MixPercent * src[RGBA.G] + (1 - MixPercent) * comp[RGBA.G]));
						dst[RGBA.R] = (byte)(Math.Round(
							MixPercent * src[RGBA.R] + (1 - MixPercent) * comp[RGBA.R]));
					}

					// alpha, 32 bit
					if (ps == 4) {
						dst [RGBA.A] = 255;
						if (psCompare == 4 && !Use255ForAlpha) {
							// just taking alphas from source image
							dst[RGBA.A] = src[RGBA.A];
//							dst[RGBA.A] = (byte)(Math.Round(
//								MixPercent * src[RGBA.A] + (1 - MixPercent) * comp[RGBA.A]));
						}
					}

				}
				src += offset;
				dst += offset;
				comp += compareOffset;
			}				

			Images[1].UnlockBits(compareData);
		}

		#endregion protected methods             
	}

	public class BlendFilter3Images : BlendFilter
	{
		protected internal override unsafe void Process(BitmapData srcData, BitmapData dstData)
		{
			MixPercent = 1.0 / Images.Length;

			int w = srcData.Width;
			int h = srcData.Height;
			int stride = srcData.Stride;
			PixelFormat pf = srcData.PixelFormat;
			Rectangle rect = new Rectangle(0, 0, w, h);
			int ps = Image.GetPixelFormatSize(pf) / 8;
			int offset = stride - w * ps;
			byte* src = (byte*)srcData.Scan0.ToPointer();
			byte* dst = (byte*)dstData.Scan0.ToPointer();

			int ps1 = Image.GetPixelFormatSize (Images [1].PixelFormat) / 8;
			BitmapData data1 = Images [1].LockBits (
				rect, ImageLockMode.ReadOnly, Images [1].PixelFormat);					
			int offset1 = data1.Stride - w * ps1;
			byte* comp1 = (byte*) data1.Scan0.ToPointer ();

			int ps2 = Image.GetPixelFormatSize (Images [2].PixelFormat) / 8;
			BitmapData data2 = Images [2].LockBits (
				rect, ImageLockMode.ReadOnly, Images [2].PixelFormat);					
			int offset2 = data2.Stride - w * ps2;
			byte* comp2 = (byte*) data2.Scan0.ToPointer ();

			// for each line
			for (int y = 0; y < h; y++)
			{
				// for each pixel
				for (int x = 0; x < w; x++, src += ps, dst += ps, 
					comp1 += ps1, comp2 += ps2)
				{
					// 8 bit grayscale
					dst[RGBA.B] = (byte)(Math.Round(
						MixPercent * src[RGBA.B] + 
						MixPercent * comp1[RGBA.B] + 
						MixPercent * comp2[RGBA.B]));

					// rgb, 24 and 32 bit
					if (ps >= 3) {
						dst[RGBA.G] = (byte)(Math.Round(
							MixPercent * src[RGBA.G] + 
							MixPercent * comp1[RGBA.G] + 
							MixPercent * comp2[RGBA.G]));
						dst[RGBA.R] = (byte)(Math.Round(
							MixPercent * src[RGBA.R] + 
							MixPercent * comp1[RGBA.R] + 
							MixPercent * comp2[RGBA.R]));
					}

					// alpha, 32 bit
					if (ps == 4) {
						dst [RGBA.A] = 255;
						if (ps1 == 4 && !Use255ForAlpha) {
							// just taking alphas from source image
							dst[RGBA.A] = src[RGBA.A];
						}
					}

				}
				src += offset;
				dst += offset;
				comp1 += offset1;
				comp2 += offset2;
			}				

			Images[1].UnlockBits(data1);
			Images[2].UnlockBits(data2);
		}
	}

	public class BlendFilter4Images : BlendFilter
	{
		protected internal override unsafe void Process(BitmapData srcData, BitmapData dstData)
		{
			MixPercent = 1.0 / Images.Length;

			int w = srcData.Width;
			int h = srcData.Height;
			int stride = srcData.Stride;
			PixelFormat pf = srcData.PixelFormat;
			Rectangle rect = new Rectangle(0, 0, w, h);
			int ps = Image.GetPixelFormatSize(pf) / 8;
			int offset = stride - w * ps;
			byte* src = (byte*)srcData.Scan0.ToPointer();
			byte* dst = (byte*)dstData.Scan0.ToPointer();

			int ps1 = Image.GetPixelFormatSize (Images [1].PixelFormat) / 8;
			BitmapData data1 = Images [1].LockBits (
				rect, ImageLockMode.ReadOnly, Images [1].PixelFormat);					
			int offset1 = data1.Stride - w * ps1;
			byte* comp1 = (byte*) data1.Scan0.ToPointer ();

			int ps2 = Image.GetPixelFormatSize (Images [2].PixelFormat) / 8;
			BitmapData data2 = Images [2].LockBits (
				rect, ImageLockMode.ReadOnly, Images [2].PixelFormat);					
			int offset2 = data2.Stride - w * ps2;
			byte* comp2 = (byte*) data2.Scan0.ToPointer ();

			int ps3 = Image.GetPixelFormatSize (Images [3].PixelFormat) / 8;
			BitmapData data3 = Images [3].LockBits (
				rect, ImageLockMode.ReadOnly, Images [3].PixelFormat);					
			int offset3 = data3.Stride - w * ps3;
			byte* comp3 = (byte*) data3.Scan0.ToPointer ();

			// for each line
			for (int y = 0; y < h; y++)
			{
				// for each pixel
				for (int x = 0; x < w; x++, src += ps, dst += ps, 
					comp1 += ps1, comp2 += ps2, comp3 += ps3)
				{
					// 8 bit grayscale
					dst[RGBA.B] = (byte)(Math.Round(
						MixPercent * src[RGBA.B] + 
						MixPercent * comp1[RGBA.B] + 
						MixPercent * comp2[RGBA.B] + 
						MixPercent * comp3[RGBA.B]));

					// rgb, 24 and 32 bit
					if (ps >= 3) {
						dst[RGBA.G] = (byte)(Math.Round(
							MixPercent * src[RGBA.G] + 
							MixPercent * comp1[RGBA.G] + 
							MixPercent * comp2[RGBA.G] + 
							MixPercent * comp3[RGBA.G]));
						
						dst[RGBA.R] = (byte)(Math.Round(
							MixPercent * src[RGBA.R] + 
							MixPercent * comp1[RGBA.R] + 
							MixPercent * comp2[RGBA.R] + 
							MixPercent * comp3[RGBA.R]));
					}

					// alpha, 32 bit
					if (ps == 4) {
						dst [RGBA.A] = 255;
						if (ps1 == 4 && !Use255ForAlpha) {
							// just taking alphas from source image
							dst[RGBA.A] = src[RGBA.A];
						}
					}

				}
				src += offset;
				dst += offset;
				comp1 += offset1;
				comp2 += offset2;
				comp3 += offset3;
			}				

			Images[1].UnlockBits(data1);
			Images[2].UnlockBits(data2);
			Images[3].UnlockBits(data3);
		}
	}
}