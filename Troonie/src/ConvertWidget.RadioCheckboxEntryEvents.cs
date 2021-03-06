﻿using System;
using Gtk;
using Troonie_Lib;
using System.Linq;

namespace Troonie
{	
	public partial class ConvertWidget
	{
		#region RadioButton image format toggle events

		private void SetToggledProperties(object sender, TroonieImageFormat f)
		{
			var pair = Constants.Extensions.First(x => x.Key == f);

			if (((RadioButton)sender).Active) {
				Constants.I.CONFIG.Format = f;
				format = pair.Value.Item1;
			}				
		}

		protected void OnRdJpegToggled (object sender, EventArgs e)
		{
			hscaleQuality.Sensitive = rdJpeg.Active;
			lbQuality.Sensitive = rdJpeg.Active;

			SetToggledProperties (sender, TroonieImageFormat.JPEG24);
		}

		protected void OnRdJpegGrayToggled (object sender, EventArgs e)
		{
			hscaleQuality.Sensitive = rdJpegGray.Active;
			lbQuality.Sensitive = rdJpegGray.Active;

			SetToggledProperties (sender, TroonieImageFormat.JPEG8);
		}

		protected void OnRdPng1bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG1);
		}

		protected void OnRdPng8BitToggled (object sender, EventArgs e)
		{			
			SetToggledProperties (sender, TroonieImageFormat.PNG8);
		}						

		protected void OnRdPng24BitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG24);
		}

		protected void OnRdPNG32bitToggled (object sender, EventArgs e)
		{
			lbTransparencyColor.Sensitive = rdPNG32bit.Active;
			btnColor.Sensitive = rdPNG32bit.Active;

			SetToggledProperties (sender, TroonieImageFormat.PNG32Transparency);
		}

		protected void OnRdPng32BitAlphaAsValueToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.PNG32AlphaAsValue);
		}

		protected void OnRdBmp1bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP1);
		}

		protected void OnRdBmp8bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP8);
		}

		protected void OnRdBmp24bitToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.BMP24);
		}	

		protected void OnRdTiffToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.TIFF);
		}

		protected void OnRdGifToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.GIF);
		}

		protected void OnRdWmfToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.WMF);
		}

		protected void OnRdEmfToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.EMF);
		}

		protected void OnRdIconToggled (object sender, EventArgs e)
		{
			SetToggledProperties (sender, TroonieImageFormat.ICO);
		}			

		#endregion RadioButton image format toggle events

		#region RadioButton image resize and output directory toggle events
		protected void OnRdOriginalSizeToggled (object sender, EventArgs e)
		{
			if (rdOriginalSize.Active) {
				Constants.I.CONFIG.ResizeVersion = ResizeVersion.No;
			}
		}

		protected void OnRdBiggerLengthToggled (object sender, EventArgs e)
		{
			entryBiggerLength.Sensitive = rdBiggerLength.Active;
			lbPixel_BiggerLength.Sensitive = rdBiggerLength.Active;

			if (rdBiggerLength.Active) {
				Constants.I.CONFIG.ResizeVersion = ResizeVersion.BiggestLength;
			}
		}

		protected void OnRdFixSizeToggled (object sender, EventArgs e)
		{
			entryFixSizeWidth.Sensitive = rdFixSize.Active;
			entryFixSizeHeight.Sensitive = rdFixSize.Active;
			checkBtnStretch.Sensitive = rdFixSize.Active;
			lbPixel_FixSize.Sensitive = rdFixSize.Active;
			lbX.Sensitive = rdFixSize.Active;

			if (rdFixSize.Active) {
				Constants.I.CONFIG.ResizeVersion = ResizeVersion.FixedSize;
			}
		}

		#endregion RadioButton image resize and output directory toggle events

		#region Checkbox AND convert button toogle events
		protected void OnCheckButtonsToggled (object sender, EventArgs e)
		{
			if (isSettingGuiToCurrentConfiguration)
				return;
			Constants.I.CONFIG.StretchImage = checkBtnStretch.Active ? ConvertMode.StretchForge : ConvertMode.NoStretchForge;
			Constants.I.CONFIG.FileOverwriting = checkBtnOverwriteOriginalImage.Active;
			Constants.I.CONFIG.UseOriginalPath = checkBtnUseOriginalDirectory.Active;

			// adapt path, if necessary
			if (!Constants.I.CONFIG.UseOriginalPath) {
				Constants.I.CONFIG.Path = htlbOutputDirectory.Text;
			}

			htlbOutputDirectory.Sensitive = !Constants.I.CONFIG.UseOriginalPath;
		}			

		#endregion Checkbox AND convert button toogle events

		#region Entry changed events

		protected void OnEntryBiggerLengthTextInserted (object o, TextInsertedArgs args)
		{
			int number;
			if (int.TryParse (entryBiggerLength.Text, out number)) {
				Constants.I.CONFIG.BiggestLength = number;
			} else {
				entryBiggerLength.DeleteText (entryBiggerLength.CursorPosition, entryBiggerLength.CursorPosition + 1);
			}
		}

		protected void OnEntryFixSizeHeightTextInserted (object o, TextInsertedArgs args)
		{
			int number;
			if (int.TryParse (entryFixSizeHeight.Text, out number)) {
				Constants.I.CONFIG.Height = number;
			} else {
				entryFixSizeHeight.DeleteText (entryFixSizeHeight.CursorPosition, entryFixSizeHeight.CursorPosition + 1);
			}
		}

		protected void OnEntryFixSizeWidthTextInserted (object o, TextInsertedArgs args)
		{
			int number;
			if (int.TryParse (entryFixSizeWidth.Text, out number)) {
				Constants.I.CONFIG.Width = number;
			} else {
				entryFixSizeWidth.DeleteText (entryFixSizeWidth.CursorPosition, entryFixSizeWidth.CursorPosition + 1);
			}
		}
		#endregion Entry changed events
	}
}

