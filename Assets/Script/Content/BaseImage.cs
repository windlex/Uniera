﻿
using System;
using System.Collections.Generic;

using System.Text;

namespace MinorShift.Emuera.Content
{

	internal sealed class BaseImage : AContentFile
	{
		public BaseImage(string name, string path)
			: base(name, path)
		{ }
		public Bitmap Bitmap;
		Graphics g;
		public IntPtr GDIhDC{get;private set;}
		IntPtr hBitmap;
		IntPtr hDefaultImg;
		public void Load(bool useGDI)
		{
			if (Loaded)
				return;
			try
			{
				Bitmap = new Bitmap(Filepath);
				if (useGDI)
				{
					hBitmap = Bitmap.GetHbitmap();
					g = Graphics.FromImage(Bitmap);
					GDIhDC = g.GetHdc();
					hDefaultImg = GDI.SelectObject(GDIhDC, hBitmap);
				}
				Loaded = true;
				Enabled = true;
			}
			catch
			{
				return;
			}
			return;
		}

		public override void Dispose()
		{
			if (Bitmap == null)
				return;
			if (g != null)
			{
				GDI.SelectObject(GDIhDC, hDefaultImg);
				GDI.DeleteObject(hBitmap);
				g.ReleaseHdc(GDIhDC);
				g.Dispose();
				g = null;
			}
			Bitmap.Dispose();
			Bitmap = null;
		}
	}
}
