/*
* video_file.cs
*
* 功 能： N/A
* 类 名： video_file
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/29 21:57:30   N/A    初版
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
	/// video_file:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class video_file
	{
		public video_file()
		{}
		#region Model
		private int _id;
		private string _file_name;
		private string _file_type;
		private string _file_path;
		private decimal _file_size;
		private DateTime _start_time;
		private DateTime _end_time;
		private int _fk_device;
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
		public string file_name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_type
		{
			set{ _file_type=value;}
			get{return _file_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_path
		{
			set{ _file_path=value;}
			get{return _file_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal file_size
		{
			set{ _file_size=value;}
			get{return _file_size;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime start_time
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fk_device
		{
			set{ _fk_device=value;}
			get{return _fk_device;}
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

