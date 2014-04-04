/*
* user.cs
*
* 功 能： N/A
* 类 名： user
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
	/// user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user
	{
		public user()
		{}
		#region Model
		private int _id;
		private string _user_name;
		private string _real_name;
		private string _password;
		private int _fk_user_type;
		private int? _fk_user_group;
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
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string real_name
		{
			set{ _real_name=value;}
			get{return _real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int fk_user_type
		{
			set{ _fk_user_type=value;}
			get{return _fk_user_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? fk_user_group
		{
			set{ _fk_user_group=value;}
			get{return _fk_user_group;}
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

