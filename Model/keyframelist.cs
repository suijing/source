/*
* keyframelist.cs
*
* 功 能： N/A
* 类 名： keyframelist
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/29 21:57:29   N/A    初版
*
* Copyright (c) 2014 ITianChuang Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：上海添创信息科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace com.itianchuang.Model
{
	/// <summary>
	/// keyframelist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class keyframelist
	{
		public keyframelist()
		{}
		#region Model
		private int _id;
		private int _fk_video_file;
		private string _parent_path;
		private int _is_value=1;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fk_video_file
		{
			set{ _fk_video_file=value;}
			get{return _fk_video_file;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parent_path
		{
			set{ _parent_path=value;}
			get{return _parent_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_value
		{
			set{ _is_value=value;}
			get{return _is_value;}
		}
		#endregion Model

	}
}

