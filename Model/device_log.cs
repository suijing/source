/*
* device_log.cs
*
* 功 能： N/A
* 类 名： device_log
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
	/// device_log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class device_log
	{
		public device_log()
		{}
		#region Model
		private int _id;
		private int _fk_device;
		private string _state;
		private DateTime _change_time;
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
		public int fk_device
		{
			set{ _fk_device=value;}
			get{return _fk_device;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime change_time
		{
			set{ _change_time=value;}
			get{return _change_time;}
		}
		#endregion Model

	}
}

