
// This file has been generated by the GUI designer. Do not modify.

internal partial class MainWindow
{
	private global::Gtk.ScrolledWindow scrolledwindowRoot;
	
	private global::Gtk.EventBox eventboxRoot;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.EventBox eventboxToolbar;
	
	private global::Gtk.HBox hboxToolbarButtons;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Frame frameImageList;
	
	private global::Gtk.Alignment AlignmentImageList;
	
	private global::Gtk.ScrolledWindow scrolledWinImageList;
	
	private global::Gtk.EventBox eventboxImageList;
	
	private global::Gtk.VBox vboxImageList;
	
	private global::Gtk.Label GtkLabel29;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Frame frameImageFormat;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.VBox VBoxImageFormat;
	
	private global::Gtk.Frame frame3;
	
	private global::Gtk.Alignment GtkAlignment4;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.RadioButton rdJpeg;
	
	private global::Gtk.Label lbQuality;
	
	private global::Gtk.HScale hscaleQuality;
	
	private global::Gtk.RadioButton rdJpegGray;
	
	private global::Gtk.Label GtkLabel6;
	
	private global::Gtk.Frame frame4;
	
	private global::Gtk.Alignment GtkAlignment5;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.RadioButton rdPng1bit;
	
	private global::Gtk.RadioButton rdPng8Bit;
	
	private global::Gtk.RadioButton rdPng24Bit;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.RadioButton rdPNG32bit;
	
	private global::Gtk.Label lbTransparencyColor;
	
	private global::Gtk.ColorButton btnColor;
	
	private global::Gtk.RadioButton rdPng32BitAlphaAsValue;
	
	private global::Gtk.Label GtkLabel11;
	
	private global::Gtk.Frame frame5;
	
	private global::Gtk.Alignment GtkAlignment6;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.RadioButton rdBmp1bit;
	
	private global::Gtk.RadioButton rdBmp8bit;
	
	private global::Gtk.RadioButton rdBmp24bit;
	
	private global::Gtk.Label GtkLabel15;
	
	private global::Gtk.Frame frame6;
	
	private global::Gtk.Alignment GtkAlignment7;
	
	private global::Gtk.VBox vbox7;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.RadioButton rdTiff;
	
	private global::Gtk.RadioButton rdGif;
	
	private global::Gtk.RadioButton rdWmf;
	
	private global::Gtk.RadioButton rdEmf;
	
	private global::Gtk.RadioButton rdIcon;
	
	private global::Gtk.Label GtkLabel21;
	
	private global::Gtk.Label lbFrameImageFormat;
	
	private global::Gtk.Frame frameImageResize;
	
	private global::Gtk.Alignment GtkAlignment8;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.RadioButton rdOriginalSize;
	
	private global::Gtk.VBox vbox9;
	
	private global::Gtk.RadioButton rdBiggerLength;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Fixed fixed4;
	
	private global::Gtk.Entry entryBiggerLength;
	
	private global::Gtk.Label lbPixel_BiggerLength;
	
	private global::Gtk.VBox vbox8;
	
	private global::Gtk.RadioButton rdFixSize;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.CheckButton checkBtnStretch;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.Fixed fixed3;
	
	private global::Gtk.Entry entryFixSizeWidth;
	
	private global::Gtk.Label lbX;
	
	private global::Gtk.Entry entryFixSizeHeight;
	
	private global::Gtk.Label lbPixel_FixSize;
	
	private global::Gtk.Label lbFrameImageResize;
	
	private global::Gtk.Frame frameOutputDirectory;
	
	private global::Gtk.Alignment GtkAlignment12;
	
	private global::Gtk.VBox vboxOutputDirectory;
	
	private global::TroonieSqlite.Sqlite_HyperTextLabel htlbOutputDirectory;
	
	private global::Gtk.CheckButton checkBtnUseOriginalDirectory;
	
	private global::Gtk.CheckButton checkBtnOverwriteOriginalImage;
	
	private global::Gtk.Label lbFrameOutputDirectory;
	
	private global::Gtk.ProgressBar progressbar1;
	
	private global::TroonieSqlite.Sqlite_TroonieButton btnConvert;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.scrolledwindowRoot = new global::Gtk.ScrolledWindow ();
		this.scrolledwindowRoot.CanFocus = true;
		this.scrolledwindowRoot.Name = "scrolledwindowRoot";
		this.scrolledwindowRoot.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindowRoot.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.eventboxRoot = new global::Gtk.EventBox ();
		this.eventboxRoot.Name = "eventboxRoot";
		// Container child eventboxRoot.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.eventboxToolbar = new global::Gtk.EventBox ();
		this.eventboxToolbar.Name = "eventboxToolbar";
		// Container child eventboxToolbar.Gtk.Container+ContainerChild
		this.hboxToolbarButtons = new global::Gtk.HBox ();
		this.hboxToolbarButtons.Name = "hboxToolbarButtons";
		this.hboxToolbarButtons.Spacing = 6;
		this.eventboxToolbar.Add (this.hboxToolbarButtons);
		this.vbox1.Add (this.eventboxToolbar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.eventboxToolbar]));
		w3.Position = 0;
		w3.Expand = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Homogeneous = true;
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.frameImageList = new global::Gtk.Frame ();
		this.frameImageList.WidthRequest = 200;
		this.frameImageList.Name = "frameImageList";
		// Container child frameImageList.Gtk.Container+ContainerChild
		this.AlignmentImageList = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.AlignmentImageList.Name = "AlignmentImageList";
		this.AlignmentImageList.LeftPadding = ((uint)(12));
		// Container child AlignmentImageList.Gtk.Container+ContainerChild
		this.scrolledWinImageList = new global::Gtk.ScrolledWindow ();
		this.scrolledWinImageList.CanFocus = true;
		this.scrolledWinImageList.Name = "scrolledWinImageList";
		this.scrolledWinImageList.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledWinImageList.Gtk.Container+ContainerChild
		global::Gtk.Viewport w4 = new global::Gtk.Viewport ();
		w4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport1.Gtk.Container+ContainerChild
		this.eventboxImageList = new global::Gtk.EventBox ();
		this.eventboxImageList.Name = "eventboxImageList";
		// Container child eventboxImageList.Gtk.Container+ContainerChild
		this.vboxImageList = new global::Gtk.VBox ();
		this.vboxImageList.Name = "vboxImageList";
		this.vboxImageList.Spacing = 6;
		this.eventboxImageList.Add (this.vboxImageList);
		w4.Add (this.eventboxImageList);
		this.scrolledWinImageList.Add (w4);
		this.AlignmentImageList.Add (this.scrolledWinImageList);
		this.frameImageList.Add (this.AlignmentImageList);
		this.GtkLabel29 = new global::Gtk.Label ();
		this.GtkLabel29.Name = "GtkLabel29";
		this.GtkLabel29.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image List</b>");
		this.GtkLabel29.UseMarkup = true;
		this.frameImageList.LabelWidget = this.GtkLabel29;
		this.hbox1.Add (this.frameImageList);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.frameImageList]));
		w10.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.frameImageFormat = new global::Gtk.Frame ();
		this.frameImageFormat.Name = "frameImageFormat";
		// Container child frameImageFormat.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.VBoxImageFormat = new global::Gtk.VBox ();
		this.VBoxImageFormat.Name = "VBoxImageFormat";
		this.VBoxImageFormat.BorderWidth = ((uint)(2));
		// Container child VBoxImageFormat.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment4.Name = "GtkAlignment4";
		this.GtkAlignment4.LeftPadding = ((uint)(12));
		// Container child GtkAlignment4.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.rdJpeg = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("JPEG"));
		this.rdJpeg.CanFocus = true;
		this.rdJpeg.Name = "rdJpeg";
		this.rdJpeg.DrawIndicator = true;
		this.rdJpeg.UseUnderline = true;
		this.rdJpeg.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox2.Add (this.rdJpeg);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.rdJpeg]));
		w11.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lbQuality = new global::Gtk.Label ();
		this.lbQuality.Name = "lbQuality";
		this.lbQuality.LabelProp = global::Mono.Unix.Catalog.GetString ("Quality");
		this.hbox2.Add (this.lbQuality);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lbQuality]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.hscaleQuality = new global::Gtk.HScale (null);
		this.hscaleQuality.CanFocus = true;
		this.hscaleQuality.Name = "hscaleQuality";
		this.hscaleQuality.Adjustment.Lower = 1;
		this.hscaleQuality.Adjustment.Upper = 100;
		this.hscaleQuality.Adjustment.PageIncrement = 10;
		this.hscaleQuality.Adjustment.StepIncrement = 1;
		this.hscaleQuality.Adjustment.Value = 90;
		this.hscaleQuality.DrawValue = true;
		this.hscaleQuality.Digits = 0;
		this.hscaleQuality.ValuePos = ((global::Gtk.PositionType)(2));
		this.hbox2.Add (this.hscaleQuality);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hscaleQuality]));
		w13.Position = 2;
		this.vbox3.Add (this.hbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.rdJpegGray = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("JPEG (grayscale)"));
		this.rdJpegGray.Sensitive = false;
		this.rdJpegGray.CanFocus = true;
		this.rdJpegGray.Name = "rdJpegGray";
		this.rdJpegGray.DrawIndicator = true;
		this.rdJpegGray.UseUnderline = true;
		this.rdJpegGray.Group = this.rdJpeg.Group;
		this.vbox3.Add (this.rdJpegGray);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.rdJpegGray]));
		w15.Position = 1;
		w15.Expand = false;
		w15.Fill = false;
		this.GtkAlignment4.Add (this.vbox3);
		this.frame3.Add (this.GtkAlignment4);
		this.GtkLabel6 = new global::Gtk.Label ();
		this.GtkLabel6.Name = "GtkLabel6";
		this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>JPEG</b>");
		this.GtkLabel6.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel6;
		this.VBoxImageFormat.Add (this.frame3);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.VBoxImageFormat [this.frame3]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child VBoxImageFormat.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment5.Name = "GtkAlignment5";
		this.GtkAlignment5.LeftPadding = ((uint)(12));
		// Container child GtkAlignment5.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.rdPng1bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("1 Bit PNG blackwhite"));
		this.rdPng1bit.Sensitive = false;
		this.rdPng1bit.CanFocus = true;
		this.rdPng1bit.Name = "rdPng1bit";
		this.rdPng1bit.DrawIndicator = true;
		this.rdPng1bit.UseUnderline = true;
		this.rdPng1bit.Group = this.rdJpeg.Group;
		this.vbox4.Add (this.rdPng1bit);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.rdPng1bit]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.rdPng8Bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("8 Bit PNG grayscale"));
		this.rdPng8Bit.CanFocus = true;
		this.rdPng8Bit.Name = "rdPng8Bit";
		this.rdPng8Bit.DrawIndicator = true;
		this.rdPng8Bit.UseUnderline = true;
		this.rdPng8Bit.Group = this.rdJpeg.Group;
		this.vbox4.Add (this.rdPng8Bit);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.rdPng8Bit]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.rdPng24Bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("24 Bit PNG"));
		this.rdPng24Bit.CanFocus = true;
		this.rdPng24Bit.Name = "rdPng24Bit";
		this.rdPng24Bit.DrawIndicator = true;
		this.rdPng24Bit.UseUnderline = true;
		this.rdPng24Bit.Group = this.rdJpeg.Group;
		this.vbox4.Add (this.rdPng24Bit);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.rdPng24Bit]));
		w21.Position = 2;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.rdPNG32bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("32 Bit PNG with transparency"));
		this.rdPNG32bit.CanFocus = true;
		this.rdPNG32bit.Name = "rdPNG32bit";
		this.rdPNG32bit.DrawIndicator = true;
		this.rdPNG32bit.UseUnderline = true;
		this.rdPNG32bit.Group = this.rdJpeg.Group;
		this.hbox5.Add (this.rdPNG32bit);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.rdPNG32bit]));
		w22.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lbTransparencyColor = new global::Gtk.Label ();
		this.lbTransparencyColor.Sensitive = false;
		this.lbTransparencyColor.Name = "lbTransparencyColor";
		this.lbTransparencyColor.LabelProp = global::Mono.Unix.Catalog.GetString ("Transparancy color");
		this.hbox5.Add (this.lbTransparencyColor);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lbTransparencyColor]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.btnColor = new global::Gtk.ColorButton ();
		this.btnColor.Sensitive = false;
		this.btnColor.CanFocus = true;
		this.btnColor.Events = ((global::Gdk.EventMask)(784));
		this.btnColor.Name = "btnColor";
		this.hbox5.Add (this.btnColor);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.btnColor]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		this.vbox4.Add (this.hbox5);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox5]));
		w25.Position = 3;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.rdPng32BitAlphaAsValue = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("32 Bit PNG (store alpha value)"));
		this.rdPng32BitAlphaAsValue.CanFocus = true;
		this.rdPng32BitAlphaAsValue.Name = "rdPng32BitAlphaAsValue";
		this.rdPng32BitAlphaAsValue.DrawIndicator = true;
		this.rdPng32BitAlphaAsValue.UseUnderline = true;
		this.rdPng32BitAlphaAsValue.Group = this.rdJpeg.Group;
		this.vbox4.Add (this.rdPng32BitAlphaAsValue);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.rdPng32BitAlphaAsValue]));
		w26.Position = 4;
		w26.Expand = false;
		w26.Fill = false;
		this.GtkAlignment5.Add (this.vbox4);
		this.frame4.Add (this.GtkAlignment5);
		this.GtkLabel11 = new global::Gtk.Label ();
		this.GtkLabel11.Name = "GtkLabel11";
		this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>PNG</b>");
		this.GtkLabel11.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel11;
		this.VBoxImageFormat.Add (this.frame4);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.VBoxImageFormat [this.frame4]));
		w29.Position = 1;
		w29.Expand = false;
		w29.Fill = false;
		// Container child VBoxImageFormat.Gtk.Box+BoxChild
		this.frame5 = new global::Gtk.Frame ();
		this.frame5.Name = "frame5";
		this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame5.Gtk.Container+ContainerChild
		this.GtkAlignment6 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment6.Name = "GtkAlignment6";
		this.GtkAlignment6.LeftPadding = ((uint)(12));
		// Container child GtkAlignment6.Gtk.Container+ContainerChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.rdBmp1bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("1 Bit BMP"));
		this.rdBmp1bit.Sensitive = false;
		this.rdBmp1bit.CanFocus = true;
		this.rdBmp1bit.Name = "rdBmp1bit";
		this.rdBmp1bit.DrawIndicator = true;
		this.rdBmp1bit.UseUnderline = true;
		this.rdBmp1bit.Group = this.rdJpeg.Group;
		this.vbox5.Add (this.rdBmp1bit);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.rdBmp1bit]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.rdBmp8bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("8 Bit BMP grayscale"));
		this.rdBmp8bit.CanFocus = true;
		this.rdBmp8bit.Name = "rdBmp8bit";
		this.rdBmp8bit.DrawIndicator = true;
		this.rdBmp8bit.UseUnderline = true;
		this.rdBmp8bit.Group = this.rdJpeg.Group;
		this.vbox5.Add (this.rdBmp8bit);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.rdBmp8bit]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.rdBmp24bit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("24 Bit BMP"));
		this.rdBmp24bit.CanFocus = true;
		this.rdBmp24bit.Name = "rdBmp24bit";
		this.rdBmp24bit.DrawIndicator = true;
		this.rdBmp24bit.UseUnderline = true;
		this.rdBmp24bit.Group = this.rdJpeg.Group;
		this.vbox5.Add (this.rdBmp24bit);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.rdBmp24bit]));
		w32.Position = 2;
		w32.Expand = false;
		w32.Fill = false;
		this.GtkAlignment6.Add (this.vbox5);
		this.frame5.Add (this.GtkAlignment6);
		this.GtkLabel15 = new global::Gtk.Label ();
		this.GtkLabel15.Name = "GtkLabel15";
		this.GtkLabel15.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>BMP</b>");
		this.GtkLabel15.UseMarkup = true;
		this.frame5.LabelWidget = this.GtkLabel15;
		this.VBoxImageFormat.Add (this.frame5);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.VBoxImageFormat [this.frame5]));
		w35.Position = 2;
		w35.Expand = false;
		w35.Fill = false;
		// Container child VBoxImageFormat.Gtk.Box+BoxChild
		this.frame6 = new global::Gtk.Frame ();
		this.frame6.Name = "frame6";
		this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame6.Gtk.Container+ContainerChild
		this.GtkAlignment7 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment7.Name = "GtkAlignment7";
		this.GtkAlignment7.LeftPadding = ((uint)(12));
		// Container child GtkAlignment7.Gtk.Container+ContainerChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rdTiff = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("TIFF"));
		this.rdTiff.CanFocus = true;
		this.rdTiff.Name = "rdTiff";
		this.rdTiff.DrawIndicator = true;
		this.rdTiff.UseUnderline = true;
		this.rdTiff.Group = this.rdJpeg.Group;
		this.hbox4.Add (this.rdTiff);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rdTiff]));
		w36.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rdGif = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("GIF"));
		this.rdGif.CanFocus = true;
		this.rdGif.Name = "rdGif";
		this.rdGif.DrawIndicator = true;
		this.rdGif.UseUnderline = true;
		this.rdGif.Group = this.rdJpeg.Group;
		this.hbox4.Add (this.rdGif);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rdGif]));
		w37.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rdWmf = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("WMF"));
		this.rdWmf.CanFocus = true;
		this.rdWmf.Name = "rdWmf";
		this.rdWmf.DrawIndicator = true;
		this.rdWmf.UseUnderline = true;
		this.rdWmf.Group = this.rdJpeg.Group;
		this.hbox4.Add (this.rdWmf);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rdWmf]));
		w38.Position = 2;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rdEmf = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("EMF"));
		this.rdEmf.CanFocus = true;
		this.rdEmf.Name = "rdEmf";
		this.rdEmf.DrawIndicator = true;
		this.rdEmf.UseUnderline = true;
		this.rdEmf.Group = this.rdJpeg.Group;
		this.hbox4.Add (this.rdEmf);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rdEmf]));
		w39.Position = 3;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rdIcon = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("ICON"));
		this.rdIcon.CanFocus = true;
		this.rdIcon.Name = "rdIcon";
		this.rdIcon.DrawIndicator = true;
		this.rdIcon.UseUnderline = true;
		this.rdIcon.Group = this.rdJpeg.Group;
		this.hbox4.Add (this.rdIcon);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.rdIcon]));
		w40.Position = 4;
		this.vbox7.Add (this.hbox4);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox4]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		this.GtkAlignment7.Add (this.vbox7);
		this.frame6.Add (this.GtkAlignment7);
		this.GtkLabel21 = new global::Gtk.Label ();
		this.GtkLabel21.Name = "GtkLabel21";
		this.GtkLabel21.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Other</b>");
		this.GtkLabel21.UseMarkup = true;
		this.frame6.LabelWidget = this.GtkLabel21;
		this.VBoxImageFormat.Add (this.frame6);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.VBoxImageFormat [this.frame6]));
		w44.Position = 3;
		this.GtkAlignment.Add (this.VBoxImageFormat);
		this.frameImageFormat.Add (this.GtkAlignment);
		this.lbFrameImageFormat = new global::Gtk.Label ();
		this.lbFrameImageFormat.Name = "lbFrameImageFormat";
		this.lbFrameImageFormat.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image Format</b>");
		this.lbFrameImageFormat.UseMarkup = true;
		this.frameImageFormat.LabelWidget = this.lbFrameImageFormat;
		this.vbox2.Add (this.frameImageFormat);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frameImageFormat]));
		w47.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.frameImageResize = new global::Gtk.Frame ();
		this.frameImageResize.Name = "frameImageResize";
		// Container child frameImageResize.Gtk.Container+ContainerChild
		this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment8.Name = "GtkAlignment8";
		this.GtkAlignment8.LeftPadding = ((uint)(12));
		// Container child GtkAlignment8.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.rdOriginalSize = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Retain original size"));
		this.rdOriginalSize.CanFocus = true;
		this.rdOriginalSize.Name = "rdOriginalSize";
		this.rdOriginalSize.DrawIndicator = true;
		this.rdOriginalSize.UseUnderline = true;
		this.rdOriginalSize.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.vbox6.Add (this.rdOriginalSize);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.rdOriginalSize]));
		w48.Position = 0;
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.rdBiggerLength = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Use length of bigger side"));
		this.rdBiggerLength.CanFocus = true;
		this.rdBiggerLength.Name = "rdBiggerLength";
		this.rdBiggerLength.DrawIndicator = true;
		this.rdBiggerLength.UseUnderline = true;
		this.rdBiggerLength.Group = this.rdOriginalSize.Group;
		this.vbox9.Add (this.rdBiggerLength);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.rdBiggerLength]));
		w49.Position = 0;
		w49.Expand = false;
		w49.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.fixed4 = new global::Gtk.Fixed ();
		this.fixed4.WidthRequest = 10;
		this.fixed4.Name = "fixed4";
		this.fixed4.HasWindow = false;
		this.hbox7.Add (this.fixed4);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.fixed4]));
		w50.Position = 0;
		w50.Expand = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entryBiggerLength = new global::Gtk.Entry ();
		this.entryBiggerLength.Sensitive = false;
		this.entryBiggerLength.CanFocus = true;
		this.entryBiggerLength.Name = "entryBiggerLength";
		this.entryBiggerLength.IsEditable = true;
		this.entryBiggerLength.WidthChars = 8;
		this.entryBiggerLength.MaxLength = 8;
		this.entryBiggerLength.InvisibleChar = '●';
		this.hbox7.Add (this.entryBiggerLength);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entryBiggerLength]));
		w51.Position = 1;
		w51.Expand = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lbPixel_BiggerLength = new global::Gtk.Label ();
		this.lbPixel_BiggerLength.Sensitive = false;
		this.lbPixel_BiggerLength.Name = "lbPixel_BiggerLength";
		this.lbPixel_BiggerLength.LabelProp = global::Mono.Unix.Catalog.GetString ("Pixel");
		this.hbox7.Add (this.lbPixel_BiggerLength);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lbPixel_BiggerLength]));
		w52.Position = 2;
		w52.Expand = false;
		w52.Fill = false;
		this.vbox9.Add (this.hbox7);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox7]));
		w53.Position = 1;
		w53.Expand = false;
		w53.Fill = false;
		this.vbox6.Add (this.vbox9);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox9]));
		w54.Position = 1;
		w54.Expand = false;
		w54.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.rdFixSize = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Fix image size   (width x height)"));
		this.rdFixSize.CanFocus = true;
		this.rdFixSize.Name = "rdFixSize";
		this.rdFixSize.DrawIndicator = true;
		this.rdFixSize.UseUnderline = true;
		this.rdFixSize.Group = this.rdOriginalSize.Group;
		this.vbox8.Add (this.rdFixSize);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.rdFixSize]));
		w55.Position = 0;
		w55.Expand = false;
		w55.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.WidthRequest = 10;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.hbox3.Add (this.fixed1);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixed1]));
		w56.Position = 0;
		w56.Expand = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.checkBtnStretch = new global::Gtk.CheckButton ();
		this.checkBtnStretch.Sensitive = false;
		this.checkBtnStretch.CanFocus = true;
		this.checkBtnStretch.Name = "checkBtnStretch";
		this.checkBtnStretch.Label = global::Mono.Unix.Catalog.GetString ("Stretch image");
		this.checkBtnStretch.DrawIndicator = true;
		this.checkBtnStretch.UseUnderline = true;
		this.hbox3.Add (this.checkBtnStretch);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.checkBtnStretch]));
		w57.Position = 1;
		this.vbox8.Add (this.hbox3);
		global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox3]));
		w58.Position = 1;
		w58.Expand = false;
		w58.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.fixed3 = new global::Gtk.Fixed ();
		this.fixed3.WidthRequest = 10;
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.hbox6.Add (this.fixed3);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.fixed3]));
		w59.Position = 0;
		w59.Expand = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entryFixSizeWidth = new global::Gtk.Entry ();
		this.entryFixSizeWidth.Sensitive = false;
		this.entryFixSizeWidth.CanFocus = true;
		this.entryFixSizeWidth.Name = "entryFixSizeWidth";
		this.entryFixSizeWidth.IsEditable = true;
		this.entryFixSizeWidth.WidthChars = 8;
		this.entryFixSizeWidth.MaxLength = 8;
		this.entryFixSizeWidth.InvisibleChar = '●';
		this.hbox6.Add (this.entryFixSizeWidth);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entryFixSizeWidth]));
		w60.Position = 1;
		w60.Expand = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lbX = new global::Gtk.Label ();
		this.lbX.Sensitive = false;
		this.lbX.Name = "lbX";
		this.lbX.LabelProp = global::Mono.Unix.Catalog.GetString ("x");
		this.hbox6.Add (this.lbX);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lbX]));
		w61.Position = 2;
		w61.Expand = false;
		w61.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entryFixSizeHeight = new global::Gtk.Entry ();
		this.entryFixSizeHeight.Sensitive = false;
		this.entryFixSizeHeight.CanFocus = true;
		this.entryFixSizeHeight.Name = "entryFixSizeHeight";
		this.entryFixSizeHeight.IsEditable = true;
		this.entryFixSizeHeight.WidthChars = 8;
		this.entryFixSizeHeight.MaxLength = 8;
		this.entryFixSizeHeight.InvisibleChar = '●';
		this.hbox6.Add (this.entryFixSizeHeight);
		global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entryFixSizeHeight]));
		w62.Position = 3;
		w62.Expand = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lbPixel_FixSize = new global::Gtk.Label ();
		this.lbPixel_FixSize.Sensitive = false;
		this.lbPixel_FixSize.Name = "lbPixel_FixSize";
		this.lbPixel_FixSize.LabelProp = global::Mono.Unix.Catalog.GetString ("Pixel");
		this.hbox6.Add (this.lbPixel_FixSize);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lbPixel_FixSize]));
		w63.Position = 4;
		w63.Expand = false;
		w63.Fill = false;
		this.vbox8.Add (this.hbox6);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox6]));
		w64.Position = 2;
		w64.Expand = false;
		w64.Fill = false;
		this.vbox6.Add (this.vbox8);
		global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox8]));
		w65.Position = 2;
		w65.Expand = false;
		w65.Fill = false;
		this.GtkAlignment8.Add (this.vbox6);
		this.frameImageResize.Add (this.GtkAlignment8);
		this.lbFrameImageResize = new global::Gtk.Label ();
		this.lbFrameImageResize.Name = "lbFrameImageResize";
		this.lbFrameImageResize.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image Resize</b>");
		this.lbFrameImageResize.UseMarkup = true;
		this.frameImageResize.LabelWidget = this.lbFrameImageResize;
		this.vbox2.Add (this.frameImageResize);
		global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frameImageResize]));
		w68.Position = 1;
		w68.Expand = false;
		w68.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.frameOutputDirectory = new global::Gtk.Frame ();
		this.frameOutputDirectory.Name = "frameOutputDirectory";
		// Container child frameOutputDirectory.Gtk.Container+ContainerChild
		this.GtkAlignment12 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment12.Name = "GtkAlignment12";
		this.GtkAlignment12.LeftPadding = ((uint)(12));
		// Container child GtkAlignment12.Gtk.Container+ContainerChild
		this.vboxOutputDirectory = new global::Gtk.VBox ();
		this.vboxOutputDirectory.Name = "vboxOutputDirectory";
		this.vboxOutputDirectory.Spacing = 6;
		// Container child vboxOutputDirectory.Gtk.Box+BoxChild
		this.htlbOutputDirectory = null;
		this.vboxOutputDirectory.Add (this.htlbOutputDirectory);
		global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.vboxOutputDirectory [this.htlbOutputDirectory]));
		w69.Position = 0;
		w69.Expand = false;
		w69.Fill = false;
		// Container child vboxOutputDirectory.Gtk.Box+BoxChild
		this.checkBtnUseOriginalDirectory = new global::Gtk.CheckButton ();
		this.checkBtnUseOriginalDirectory.CanFocus = true;
		this.checkBtnUseOriginalDirectory.Name = "checkBtnUseOriginalDirectory";
		this.checkBtnUseOriginalDirectory.Label = global::Mono.Unix.Catalog.GetString ("Use original directory");
		this.checkBtnUseOriginalDirectory.DrawIndicator = true;
		this.checkBtnUseOriginalDirectory.UseUnderline = true;
		this.vboxOutputDirectory.Add (this.checkBtnUseOriginalDirectory);
		global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.vboxOutputDirectory [this.checkBtnUseOriginalDirectory]));
		w70.Position = 1;
		w70.Expand = false;
		w70.Fill = false;
		// Container child vboxOutputDirectory.Gtk.Box+BoxChild
		this.checkBtnOverwriteOriginalImage = new global::Gtk.CheckButton ();
		this.checkBtnOverwriteOriginalImage.CanFocus = true;
		this.checkBtnOverwriteOriginalImage.Name = "checkBtnOverwriteOriginalImage";
		this.checkBtnOverwriteOriginalImage.Label = global::Mono.Unix.Catalog.GetString ("Overwrite/Delete original image");
		this.checkBtnOverwriteOriginalImage.DrawIndicator = true;
		this.checkBtnOverwriteOriginalImage.UseUnderline = true;
		this.vboxOutputDirectory.Add (this.checkBtnOverwriteOriginalImage);
		global::Gtk.Box.BoxChild w71 = ((global::Gtk.Box.BoxChild)(this.vboxOutputDirectory [this.checkBtnOverwriteOriginalImage]));
		w71.Position = 2;
		w71.Expand = false;
		w71.Fill = false;
		this.GtkAlignment12.Add (this.vboxOutputDirectory);
		this.frameOutputDirectory.Add (this.GtkAlignment12);
		this.lbFrameOutputDirectory = new global::Gtk.Label ();
		this.lbFrameOutputDirectory.Name = "lbFrameOutputDirectory";
		this.lbFrameOutputDirectory.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Output Directory</b>");
		this.lbFrameOutputDirectory.UseMarkup = true;
		this.frameOutputDirectory.LabelWidget = this.lbFrameOutputDirectory;
		this.vbox2.Add (this.frameOutputDirectory);
		global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frameOutputDirectory]));
		w74.Position = 2;
		w74.Expand = false;
		w74.Fill = false;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w75 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w75.Position = 1;
		w75.Padding = ((uint)(3));
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w76 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w76.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.progressbar1 = new global::Gtk.ProgressBar ();
		this.progressbar1.Name = "progressbar1";
		this.progressbar1.Text = global::Mono.Unix.Catalog.GetString (" ");
		this.vbox1.Add (this.progressbar1);
		global::Gtk.Box.BoxChild w77 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.progressbar1]));
		w77.Position = 2;
		w77.Expand = false;
		w77.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.btnConvert = null;
		this.vbox1.Add (this.btnConvert);
		global::Gtk.Box.BoxChild w78 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnConvert]));
		w78.Position = 3;
		w78.Expand = false;
		w78.Fill = false;
		this.eventboxRoot.Add (this.vbox1);
		w1.Add (this.eventboxRoot);
		this.scrolledwindowRoot.Add (w1);
		this.Add (this.scrolledwindowRoot);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 864;
		this.DefaultHeight = 869;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.DragDrop += new global::Gtk.DragDropHandler (this.OnDragDrop);
		this.DragDataReceived += new global::Gtk.DragDataReceivedHandler (this.OnDragDataReceived);
	}
}
