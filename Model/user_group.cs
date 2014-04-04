/*
* user_group.cs
*
* 功 能： N/A
* 类 名： user_group
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
	/// user_group:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_group
	{
		public user_group()
		{}
		#region Model
		private int _id;
		private string _group_name;
		private string _remark;
		private int _is_value;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string group_name
		{
			set{ _group_name=value;}
			get{return _group_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
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

