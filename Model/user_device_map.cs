/*
* user_device_map.cs
*
* 功 能： N/A
* 类 名： user_device_map
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
	/// user_device_map:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_device_map
	{
		public user_device_map()
		{}
		#region Model
		private int _id;
		private int _fk_user;
		private int _fk_device;
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
		public int fk_device
		{
			set{ _fk_device=value;}
			get{return _fk_device;}
		}
		#endregion Model

	}
}

