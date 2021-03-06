﻿using System;
using TagLib;
using System.Collections.Generic;

namespace Troonie_Lib
{
	public class VideoTagHelper
	{
		private static VideoTagHelper instance;
		public static VideoTagHelper I
		{
			get
			{
				if (instance == null) {
					instance = new VideoTagHelper ();
				}
				return instance;
			}
		}			
			
//		public static void SetDateAndRatingInVideoTag(string fileName, uint rating)
//		{
//			TagsFlag flag = TagsFlag.Track;
//			uint dateAsUint;
//			string dateAsString;
//			GetDateFromFilenameAsUint (fileName, out dateAsUint, out dateAsString);
//			TagsData td = new TagsData { Track = rating };
//
//			if (dateAsUint != 0) {
//				flag = TagsFlag.Track | TagsFlag.Year | TagsFlag.Composers;
//				td.Year = dateAsUint;
//				td.Composers = new List<string>{ "Creation date (Troonie): " + dateAsString, "Rating (Troonie): " + rating };
//			} 
//
//			SetTag(fileName, flag, td);
//		}

		public static TagsData GetTagsData(string fileName)
		{
			TagsData td = new TagsData ();
			Tag cit = GetTag (fileName);
			if (cit != null) {
				td.Comment = cit.Comment;
				td.Copyright = cit.Copyright;
				td.Title = cit.Title;
			}

			return td;
		}

		public static bool SetTag(string fileName, TagsFlag flag, TagsData newData)
		{
			bool success = true;
			TagLib.File tagFile = LoadTagFile (fileName);
			Tag tag = tagFile.Tag;

			try{
				ChangeValueOfTag (tag, flag, newData);
				tagFile.Save();
				tagFile.Dispose ();
			}
			catch (Exception /* UnsupportedFormatException */ ) {
				success = false;
			}

			return success;
		}

		#region private static functions

		private static Tag GetTag(string fileName)
		{
			TagLib.File tagFile = LoadTagFile(fileName);			

			if (tagFile == null)
				return null;
			
			Tag tag = tagFile.Tag;
			tagFile.Dispose ();
			return tag;
		}

		private static void ChangeValueOfTag(Tag tag, TagsFlag flag, TagsData newData)
		{
			uint flagValue = int.MaxValue;
			flagValue += 1;

			while(flagValue != 0)
			{
				switch (flag & (TagsFlag)flagValue) {
				case TagsFlag.Comment:		tag.Comment = newData.Comment;				break;
				case TagsFlag.Copyright:	tag.Copyright = newData.Copyright;			break;
				case TagsFlag.Title:		tag.Title = newData.Title;					break;
				}

				flagValue >>= 1;
			}
		}			

		private static TagLib.File LoadTagFile(string fileName)
		{
			TagLib.File tagFile;
			try{
				tagFile = TagLib.File.Create(fileName);
				if (tagFile == null){
					return null;
				}
			}
			catch (Exception /* UnsupportedFormatException */) {
				return null;
			}									

			return tagFile;
		}			

		#endregion private static functions
	}
}

