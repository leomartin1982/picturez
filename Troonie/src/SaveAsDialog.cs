﻿using System;
using Gtk;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
// using System.IO;
using IOPath = System.IO.Path;
using ImageConverter = Troonie_Lib.ImageConverter;
using Troonie_Lib;
using NetColor = System.Drawing.Color;

namespace Troonie
{	
	[System.ComponentModel.ToolboxItem (true)]
	public partial class SaveAsDialog : Gtk.Dialog
	{
   		private BitmapWithTag bitmap;
//		private TroonieImageFormat format;
//		private byte jpegQuality;
//		private Gdk.Color transparencyColor;
		private ConfigConvert config;
		private Troonie.ColorConverter colorConverter = Troonie.ColorConverter.Instance;

		public string SavedFileName { get { return htLabelDirectory.Text + IOPath.DirectorySeparatorChar + entryFilename.Text +
				lbFormat.Text; } }

		public SaveAsDialog (BitmapWithTag b, ConvertMode cm)
		{			
			this.Build ();

			bitmap = b;
			config = new ConfigConvert ();
			config.StretchImage = cm;

			btnColor.Color = colorConverter.White;
			htLabelDirectory.InitDefaultValues ();
			htLabelDirectory.OnHyperTextLabelTextChanged += OnHyperTextLabelTextChanged;

			this.ModifyBg(StateType.Normal, colorConverter.GRID);
			GtkLabel3.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel8.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel12.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel17.ModifyFg(StateType.Normal, colorConverter.FONT);
			lbFile.ModifyFg(StateType.Normal, colorConverter.FONT);

			SetLanguageToGui ();

			// set path and filename
			int lastDirectorySeparator = bitmap.FileName.LastIndexOf(IOPath.DirectorySeparatorChar);
			if (lastDirectorySeparator == -1) {
				lastDirectorySeparator = bitmap.FileName.LastIndexOf(IOPath.AltDirectorySeparatorChar);
			}
			int lastDot = bitmap.FileName.LastIndexOf('.');
			int fileNameLength = lastDot - (lastDirectorySeparator + 1);
			entryFilename.Text = bitmap.FileName.Substring (lastDirectorySeparator + 1, fileNameLength);
			// will also change config.Path, caused of delegate 'OnHyperTextLabelTextChanged'
			htLabelDirectory.Text = bitmap.FileName.Substring(0, lastDirectorySeparator);
			// config.Path = htLabelDirectory.Text;



			switch (b.OrigFormat) 
			{
			case TroonieImageFormat.PNG1:
				rdPng1bit.Active = true;
				OnRdPng1bitToggled (rdPng1bit, null);
				break;
			case TroonieImageFormat.PNG8:
				rdPng8Bit.Active = true;
				OnRdPng8BitToggled (rdPng8Bit, null);
				break;
			case TroonieImageFormat.PNG24:
				rdPng24Bit.Active = true;
				OnRdPng24BitToggled (rdPng24Bit, null);
				break;
			case TroonieImageFormat.PNG32Transparency:
				rdPNG32bit.Active = true;
				OnRdPNG32bitToggled (rdPNG32bit, null);
				break;
			case TroonieImageFormat.PNG32AlphaAsValue:
				rdPng32BitAlphaAsValue.Active = true;
				OnRdPNG32bitToggled (rdPng32BitAlphaAsValue, null);
				break;
			case TroonieImageFormat.JPEG8:
				rdJpegGray.Active = true;
				OnRdJpegGrayToggled (rdJpegGray, null);				
				break;
			case TroonieImageFormat.JPEG24:
				rdJpeg.Active = true;
				OnRdJpegToggled (rdJpeg, null);				
				break;
			case TroonieImageFormat.BMP1:
				rdBmp1bit.Active = true;
				OnRdBmp1bitToggled (rdBmp1bit, null);
				break;
			case TroonieImageFormat.BMP8:
				rdBmp8bit.Active = true;
				OnRdBmp8bitToggled (rdBmp8bit, null);
				break;
			case TroonieImageFormat.BMP24:
				rdBmp24bit.Active = true;
				OnRdBmp24bitToggled (rdBmp24bit, null);		
				break;
			case TroonieImageFormat.TIFF:
				rdTiff.Active = true;
				OnRdTiffToggled (rdTiff, null);				
				break;
			case TroonieImageFormat.GIF:
				rdGif.Active = true;
				OnRdGifToggled (rdGif, null);				
				break;
			case TroonieImageFormat.WMF:
				rdWmf.Active = true;
				OnRdWmfToggled (rdWmf, null);				
				break;
			case TroonieImageFormat.EMF:
				rdEmf.Active = true;
				OnRdEmfToggled (rdEmf, null);				
				break;
			default:
				throw new NotSupportedException (Language.I.L[49]);
			}

			if (Constants.I.WINDOWS) {
				rdPng1bit.Sensitive = true;
				rdBmp1bit.Sensitive = true;
			} else {
				// Original is ShadowType.EtchedIn, but linux cannot draw it correctly.
				// Otherwise ShadowType.In looks terrible at Win10.
				frame3.ShadowType = ShadowType.In;
				frame4.ShadowType = ShadowType.In;
				frame5.ShadowType = ShadowType.In;
				frame6.ShadowType = ShadowType.In;
				frame7.ShadowType = ShadowType.In;

				rdJpegGray.Sensitive = true;
			}		
		}

		private void OnHyperTextLabelTextChanged()
		{
			// Current.Path = htlbOutputDirectory.Text;
			config.Path = htLabelDirectory.Text;
		}	

		private void SetLanguageToGui()
		{
			this.Title = Language.I.L [3];

			lbFile.LabelProp = "<b>" + Language.I.L[46] + "</b>";
			lbDirectoryText.Text = Language.I.L[47];
			label3.Text = Language.I.L[48];

			rdJpeg.Label = "JPEG (24 Bit " + Language.I.L[22] + ")";
			rdJpegGray.Label = "JPEG (8 Bit " + Language.I.L[21] + ")";
			lbQuality.Text = Language.I.L[23];

			rdPng1bit.Label = "PNG (1 Bit " + Language.I.L[24] + ")";
			rdPng8Bit.Label = "PNG (8 Bit " + Language.I.L[21] + ")";
			rdPng24Bit.Label = "PNG (24 Bit " + Language.I.L[22] + ")";
			rdPNG32bit.Label = "PNG (32 Bit " + Language.I.L[25] + ")";
			rdPng32BitAlphaAsValue.Label = "PNG (32 Bit " + Language.I.L[79] + ")";
			lbTransparencyColor.Text = Language.I.L[26];

			rdBmp1bit.Label = "BMP (1 Bit " + Language.I.L[24] + ")";
			rdBmp8bit.Label = "BMP (8 Bit " + Language.I.L[21] + ")";
			rdBmp24bit.Label = "BMP (24 Bit " + Language.I.L[22] + ")";
			GtkLabel17.LabelProp = "<b>" + Language.I.L[27] + "</b>";
			buttonOk.Label = Language.I.L[16];
			buttonCancel.Label = Language.I.L[17];
		}

		public bool Process()
		{
			entryFilename.Text = Regex.Replace(entryFilename.Text, @"[\\/:?*^""<>|]", "_");

			if (FileHelper.I.Exists (SavedFileName)) 
			{
				MessageDialog md = new MessageDialog (this, 
					                   DialogFlags.DestroyWithParent, MessageType.Question, 
					ButtonsType.OkCancel, Language.I.L[50]);
				if (md.Run () == (int)ResponseType.Cancel) {
					md.Destroy ();
					return false;
				}
				md.Destroy ();
				config.FileOverwriting = true;
			}		

			bitmap.Save (config, entryFilename.Text + lbFormat.Text);
			return true;
		}

		public void AllowOnlyColorLoselessSaving()
		{
			rdPng1bit.Sensitive = false;
			rdPng8Bit.Sensitive = false;
			rdPNG32bit.Sensitive = false;
			rdBmp1bit.Sensitive = false;
			rdBmp8bit.Sensitive = false;
			frame3.Sensitive = false; // jpg
//			frame6.Sensitive = false; // other
			rdGif.Sensitive = false;
			rdIcon.Sensitive = false;

			rdPng24Bit.Active = true;
		}

		#region RadioButton toggle events

		private void SetToggledProperties(object sender, TroonieImageFormat f, string s)
		{
			if (((RadioButton)sender).Active) {
				config.Format = f;
				lbFormat.Text = s;
			}				
		}

		protected void OnRdJpegToggled (object sender, EventArgs e)
		{
			hscaleQuality.Sensitive = rdJpeg.Active;
			lbQuality.Sensitive = rdJpeg.Active;

			SetToggledProperties (sender, TroonieImageFormat.JPEG24, ".jpg");
		}

		protected void OnRdJpegGrayToggled (object sender, EventArgs e)
		{
			hscaleQuality.Sensitive = rdJpegGray.Active;
			lbQuality.Sensitive = rdJpegGray.Active;

			SetToggledProperties (sender, TroonieImageFormat.JPEG8, ".jpg");
		}

		protected void OnRdPng1bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG1, ".png");
		}

		protected void OnRdPng8BitToggled (object sender, EventArgs e)
		{			
			SetToggledProperties (sender, TroonieImageFormat.PNG8, ".png");
		}						

		protected void OnRdPng24BitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG24, ".png");
		}

		protected void OnRdPNG32bitToggled (object sender, EventArgs e)
		{
			lbTransparencyColor.Sensitive = rdPNG32bit.Active;
			btnColor.Sensitive = rdPNG32bit.Active;

			SetToggledProperties (sender, TroonieImageFormat.PNG32Transparency, ".png");
		}

		protected void OnRdPng32BitAlphaAsValueToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG32AlphaAsValue, ".png");
		}

		protected void OnRdBmp1bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP1, ".bmp");
		}

		protected void OnRdBmp8bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP8, ".bmp");
		}

		protected void OnRdBmp24bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP24, ".bmp");
		}	

		protected void OnRdTiffToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.TIFF, ".tif");
		}

		protected void OnRdGifToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.GIF, ".gif");
		}

		protected void OnRdWmfToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.WMF, ".wmf");
		}

		protected void OnRdEmfToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.EMF, ".emf");
		}

		protected void OnRdIconToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.ICO, ".ico");
		}

		#endregion RadioButton Toggle events

		protected void OnHscaleQualityValueChanged (object sender, EventArgs e)
		{
			config.JpgQuality = (byte)hscaleQuality.Value;
		}

		protected void OnBtnColorColorSet (object sender, EventArgs e)
		{			
			// transparencyColor = btnColor.Color;

			byte r, g, b;
			ColorConverter.Instance.ToDotNetColor (btnColor.Color, out r, out g, out b);

			config.TransparencyColorRed = r;
			config.TransparencyColorGreen = g;
			config.TransparencyColorBlue = b;
		}		

		[GLib.ConnectBefore ()] 
		protected void OnKeyPressEvent (object o, KeyPressEventArgs args)
		{
//			 System.Console.WriteLine("Keypress: {0}", args.Event.Key);
			switch (args.Event.Key) {
			case Gdk.Key.Return:
				this.Respond (ResponseType.Ok);
				break;
				case Gdk.Key.Escape:
				this.Respond (ResponseType.Cancel);
				break;
			}
		}
	}
}
