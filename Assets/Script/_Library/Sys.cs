using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using UnityEngine;

namespace MinorShift._Library
{
	public static class Sys
	{
		static Sys()
		{
            ExePath = Application.dataPath;
			ExeDir = Path.GetDirectoryName(ExePath) + "\\";
			ExeName = Path.GetFileName(ExePath);
		}

		/// <summary>
		/// 実行ファイルのパス
		/// </summary>
		public static readonly string ExePath;

		/// <summary>
		/// 実行ファイルのディレクトリ。最後に\を付けたstring
		/// </summary>
		public static readonly string ExeDir;

		/// <summary>
		/// 実行ファイルの名前。ディレクトリなし
		/// </summary>
		public static readonly string ExeName;

		/// <summary>
		/// 2重起動防止。既に同名exeが実行されているならばtrueを返す
		/// </summary>
		/// <returns></returns>
		public static bool PrevInstance()
		{
			string thisProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
			if (System.Diagnostics.Process.GetProcessesByName(thisProcessName).Length > 1)
			{
				return true;
			}
			return false;

		}
	}
}

