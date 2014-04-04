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
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace com.itianchuang.DAL
{
	/// <summary>
	/// 数据访问类:video_file
	/// </summary>
	public partial class video_file
	{
		public video_file()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return MySqlHelper.GetMaxID("id", "video_file"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from video_file");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			return MySqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(com.itianchuang.Model.video_file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into video_file(");
			strSql.Append("id,file_name,file_type,file_path,file_size,start_time,end_time,fk_device,is_value)");
			strSql.Append(" values (");
			strSql.Append("@id,@file_name,@file_type,@file_path,@file_size,@start_time,@end_time,@fk_device,@is_value)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@file_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@file_type", MySqlDbType.VarChar,15),
					new MySqlParameter("@file_path", MySqlDbType.VarChar,255),
					new MySqlParameter("@file_size", MySqlDbType.Float),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@fk_device", MySqlDbType.Int32,11),
					new MySqlParameter("@is_value", MySqlDbType.tinyint,1)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.file_name;
			parameters[2].Value = model.file_type;
			parameters[3].Value = model.file_path;
			parameters[4].Value = model.file_size;
			parameters[5].Value = model.start_time;
			parameters[6].Value = model.end_time;
			parameters[7].Value = model.fk_device;
			parameters[8].Value = model.is_value;

			int rows=MySqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(com.itianchuang.Model.video_file model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update video_file set ");
			strSql.Append("file_name=@file_name,");
			strSql.Append("file_type=@file_type,");
			strSql.Append("file_path=@file_path,");
			strSql.Append("file_size=@file_size,");
			strSql.Append("start_time=@start_time,");
			strSql.Append("end_time=@end_time,");
			strSql.Append("fk_device=@fk_device,");
			strSql.Append("is_value=@is_value");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@file_name", MySqlDbType.VarChar,64),
					new MySqlParameter("@file_type", MySqlDbType.VarChar,15),
					new MySqlParameter("@file_path", MySqlDbType.VarChar,255),
					new MySqlParameter("@file_size", MySqlDbType.Float),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@fk_device", MySqlDbType.Int32,11),
					new MySqlParameter("@is_value", MySqlDbType.tinyint,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.file_name;
			parameters[1].Value = model.file_type;
			parameters[2].Value = model.file_path;
			parameters[3].Value = model.file_size;
			parameters[4].Value = model.start_time;
			parameters[5].Value = model.end_time;
			parameters[6].Value = model.fk_device;
			parameters[7].Value = model.is_value;
			parameters[8].Value = model.id;

			int rows=MySqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from video_file ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			int rows=MySqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from video_file ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=MySqlHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public com.itianchuang.Model.video_file GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,file_name,file_type,file_path,file_size,start_time,end_time,fk_device,is_value from video_file ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			com.itianchuang.Model.video_file model=new com.itianchuang.Model.video_file();
			DataSet ds=MySqlHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public com.itianchuang.Model.video_file DataRowToModel(DataRow row)
		{
			com.itianchuang.Model.video_file model=new com.itianchuang.Model.video_file();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["file_name"]!=null)
				{
					model.file_name=row["file_name"].ToString();
				}
				if(row["file_type"]!=null)
				{
					model.file_type=row["file_type"].ToString();
				}
				if(row["file_path"]!=null)
				{
					model.file_path=row["file_path"].ToString();
				}
				if(row["file_size"]!=null && row["file_size"].ToString()!="")
				{
					model.file_size=decimal.Parse(row["file_size"].ToString());
				}
				if(row["start_time"]!=null && row["start_time"].ToString()!="")
				{
					model.start_time=DateTime.Parse(row["start_time"].ToString());
				}
				if(row["end_time"]!=null && row["end_time"].ToString()!="")
				{
					model.end_time=DateTime.Parse(row["end_time"].ToString());
				}
				if(row["fk_device"]!=null && row["fk_device"].ToString()!="")
				{
					model.fk_device=int.Parse(row["fk_device"].ToString());
				}
				if(row["is_value"]!=null && row["is_value"].ToString()!="")
				{
					model.is_value=int.Parse(row["is_value"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,file_name,file_type,file_path,file_size,start_time,end_time,fk_device,is_value ");
			strSql.Append(" FROM video_file ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return MySqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM video_file ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from video_file T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return MySqlHelper.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "video_file";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return MySqlHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

