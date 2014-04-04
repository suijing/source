/*
* userlog.cs
*
* 功 能： N/A
* 类 名： userlog
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
	/// userlog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userlog
	{
		public userlog()
		{}
		#region Model
		private int _id;
		private int _fk_user;
		private string _behavior;
		private string _content;
		private DateTime _time;
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
		public int fk_user
		{
			set{ _fk_user=value;}
			get{return _fk_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string behavior
		{
			set{ _behavior=value;}
			get{return _behavior;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

