/*
* device.cs
*
* 功 能： N/A
* 类 名： device
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
	/// device:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class device
	{
		public device()
		{}
		#region Model
		private int _id;
		private string _device_name;
		private string _ip;
		private string _mac;
		private string _remark;
		private int _is_value=1;
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
		public string device_name
		{
			set{ _device_name=value;}
			get{return _device_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mac
		{
			set{ _mac=value;}
			get{return _mac;}
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

