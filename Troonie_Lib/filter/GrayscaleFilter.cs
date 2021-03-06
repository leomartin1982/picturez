using System;
using System.Drawing.Imaging;
using System.Drawing;

namespace Troonie_Lib
{
	/// <summary>
	/// The filter grayscales colored and images including simple contrast manipulation.
	/// </summary>
	public class GrayscaleFilter : AbstractFilter
	{
		/// <summary>
		/// Set of predefined common grayscaling algorithms, 
		/// which have aldready initialized grayscaling coefficients.
		/// </summary>
		public enum CommonAlgorithms
		{
			/// <summary>Grayscale image using BT709 algorithm.</summary>
			BT709,
			/// <summary>Grayscale image using RMY algorithm. </summary>
			RMY,
			/// <summary>Grayscale image using Y algorithm.</summary>
			Y,
			/// <summary>Grayscale image using linear algorithm. 
			/// All rgb components same quantifier.</summary>
			LINEAR
		}

		private CommonAlgorithms algorithm;
		/// <summary>
		/// Defines the grayscale algorithm type. 
		/// See also <seealso cref="CommonAlgorithms"/>.
		/// </summary>
		public CommonAlgorithms Algorithm
		{
			get { return algorithm; }
			set
			{
				algorithm = value;
				switch (algorithm)
				{
					case CommonAlgorithms.BT709:
					Red = 0.2125f;
					Green = 0.7154f;
					Blue = 0.0721f;
					break;
					case CommonAlgorithms.RMY:
					Red = 0.5f;
					Green = 0.419f;
					Blue = 0.081f;
					break;
					case CommonAlgorithms.Y:
					Red = 0.299f;
					Green = 0.587f;
					Blue = 0.114f;
					break;
				case CommonAlgorithms.LINEAR:
					Red = 0.333334f;
					Green = 0.333334f;
					Blue = 0.333334f;
					break;
				}
			}
		}

		/// <summary>Portion of blue channel's value to use during 
		/// conversion from RGB to grayscale. </summary>
		public float Blue { get; set; }

		/// <summary>Portion of green channel's value to use during 
		/// conversion from RGB to grayscale. </summary>
		public float Green { get; set; }

		/// <summary>Portion of red channel's value to use during 
		/// conversion from RGB to grayscale. </summary>
		public float Red { get; set; }

		/// <summary>Exponent for manipulating contrast. 
		/// Increasing or decreasing channel value by exponentiation.</summary>
		public float Exp{ get; set; }

		/// <summary>Threshold to determine whether increasing or decreasing grayscale value.</summary>
		public byte Threshold { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="GrayscaleFilter"/> class.
		/// </summary>
		public GrayscaleFilter()
		{
			SupportedSrcPixelFormat = PixelFormatFlags.Color;
			SupportedDstPixelFormat = PixelFormatFlags.Format8BppIndexed; 
			Algorithm = CommonAlgorithms.BT709;
			Exp = 1;
			Threshold = 127;
		}

		#region protected methods

		protected override void SetProperties (double[] filterProperties)
		{
			Algorithm = (CommonAlgorithms)filterProperties[0];
			Exp = (float)filterProperties [3];
			Threshold = (byte)filterProperties [4];
		}

		/// <summary>
		/// Processes the filter on the passed <paramref name="srcData"/>
		/// resulting into <paramref name="dstData"/>.
		/// </summary>
		/// <param name="srcData">The source bitmap data.</param>
		/// <param name="dstData">The destination bitmap data.</param>
		protected override internal unsafe void Process(BitmapData srcData, BitmapData dstData)
		{
			int ps = Image.GetPixelFormatSize(srcData.PixelFormat) / 8;
			int w = srcData.Width;
			int h = srcData.Height;
			int srcStride = srcData.Stride;
			int dstStride = dstData.Stride;
			int srcOffset = srcStride - w * ps;
			int dstOffset = dstStride - w;

			byte* src = (byte*)srcData.Scan0.ToPointer();
			byte* dst = (byte*)dstData.Scan0.ToPointer();

			// for each line
			for (int y = 0; y < h; y++)
			{
				// for each pixel
				for (int x = 0; x < w; x++, src += ps, dst += 1)
				{
					double tmp = (src [RGBA.R] * Red + src [RGBA.G] * Green + src [RGBA.B] * Blue);
					float tmp_exp = tmp >= Threshold ? Exp : 2 - Exp;

					tmp = Math.Pow(tmp, tmp_exp) + 0.5f;
					* dst = (byte)Math.Min (tmp, 255);
				}
				src += srcOffset;
				dst += dstOffset;
			}
		}

		#endregion protected methods             
	}
}