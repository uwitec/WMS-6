﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace WMS_Database
{
	/// <summary>
	/// 数据访问类:WH_CellDal
	/// </summary>
	public partial class WH_CellDal
	{
        public WH_CellDal()
		{}
        #region  Method


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Cell_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WH_Cell");
            strSql.Append(" where Cell_ID='" + Cell_ID + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(WMS_Database.WH_CellModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Cell_ID != null)
            {
                strSql1.Append("Cell_ID,");
                strSql2.Append("'" + model.Cell_ID + "',");
            }
            if (model.Area_ID != null)
            {
                strSql1.Append("Area_ID,");
                strSql2.Append("'" + model.Area_ID + "',");
            }
            if (model.Cell_Code != null)
            {
                strSql1.Append("Cell_Code,");
                strSql2.Append("'" + model.Cell_Code + "',");
            }
            if (model.Cell_Name != null)
            {
                strSql1.Append("Cell_Name,");
                strSql2.Append("'" + model.Cell_Name + "',");
            }
            if (model.Cell_Lane != null)
            {
                strSql1.Append("Cell_Lane,");
                strSql2.Append("'" + model.Cell_Lane + "',");
            }
            if (model.Device_Code != null)
            {
                strSql1.Append("Device_Code,");
                strSql2.Append("'" + model.Device_Code + "',");
            }
            if (model.Shelf_Type != null)
            {
                strSql1.Append("Shelf_Type,");
                strSql2.Append("'" + model.Shelf_Type + "',");
            }
            if (model.Cell_InOut != null)
            {
                strSql1.Append("Cell_InOut,");
                strSql2.Append("'" + model.Cell_InOut + "',");
            }
            if (model.Cell_Type != null)
            {
                strSql1.Append("Cell_Type,");
                strSql2.Append("'" + model.Cell_Type + "',");
            }
            if (model.Cell_Storage_Type != null)
            {
                strSql1.Append("Cell_Storage_Type,");
                strSql2.Append("'" + model.Cell_Storage_Type + "',");
            }
            if (model.Cell_Fork_Type != null)
            {
                strSql1.Append("Cell_Fork_Type,");
                strSql2.Append("'" + model.Cell_Fork_Type + "',");
            }
            if (model.Cell_Layer != null)
            {
                strSql1.Append("Cell_Layer,");
                strSql2.Append("" + model.Cell_Layer + ",");
            }
            if (model.Cell_Column != null)
            {
                strSql1.Append("Cell_Column,");
                strSql2.Append("" + model.Cell_Column + ",");
            }
            if (model.Cell_Row != null)
            {
                strSql1.Append("Cell_Row,");
                strSql2.Append("" + model.Cell_Row + ",");
            }
            if (model.Cell_Reserve1 != null)
            {
                strSql1.Append("Cell_Reserve1,");
                strSql2.Append("'" + model.Cell_Reserve1 + "',");
            }
            if (model.Cell_Reserve2 != null)
            {
                strSql1.Append("Cell_Reserve2,");
                strSql2.Append("'" + model.Cell_Reserve2 + "',");
            }
            if (model.Cell_Reserve3 != null)
            {
                strSql1.Append("Cell_Reserve3,");
                strSql2.Append("'" + model.Cell_Reserve3 + "',");
            }
            if (model.Cell_Reserve4 != null)
            {
                strSql1.Append("Cell_Reserve4,");
                strSql2.Append("'" + model.Cell_Reserve4 + "',");
            }
            if (model.Cell_Reserve5 != null)
            {
                strSql1.Append("Cell_Reserve5,");
                strSql2.Append("'" + model.Cell_Reserve5 + "',");
            }
            strSql.Append("insert into WH_Cell(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public bool Update(WMS_Database.WH_CellModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WH_Cell set ");
            if (model.Area_ID != null)
            {
                strSql.Append("Area_ID='" + model.Area_ID + "',");
            }
            else
            {
                strSql.Append("Area_ID= null ,");
            }
            if (model.Cell_Code != null)
            {
                strSql.Append("Cell_Code='" + model.Cell_Code + "',");
            }
            else
            {
                strSql.Append("Cell_Code= null ,");
            }
            if (model.Cell_Name != null)
            {
                strSql.Append("Cell_Name='" + model.Cell_Name + "',");
            }
            else
            {
                strSql.Append("Cell_Name= null ,");
            }
            if (model.Cell_Lane != null)
            {
                strSql.Append("Cell_Lane='" + model.Cell_Lane + "',");
            }
            else
            {
                strSql.Append("Cell_Lane= null ,");
            }
            if (model.Device_Code != null)
            {
                strSql.Append("Device_Code='" + model.Device_Code + "',");
            }
            else
            {
                strSql.Append("Device_Code= null ,");
            }
            if (model.Shelf_Type != null)
            {
                strSql.Append("Shelf_Type='" + model.Shelf_Type + "',");
            }
            else
            {
                strSql.Append("Shelf_Type= null ,");
            }
            if (model.Cell_InOut != null)
            {
                strSql.Append("Cell_InOut='" + model.Cell_InOut + "',");
            }
            else
            {
                strSql.Append("Cell_InOut= null ,");
            }
            if (model.Cell_Type != null)
            {
                strSql.Append("Cell_Type='" + model.Cell_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Type= null ,");
            }
            if (model.Cell_Storage_Type != null)
            {
                strSql.Append("Cell_Storage_Type='" + model.Cell_Storage_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Storage_Type= null ,");
            }
            if (model.Cell_Fork_Type != null)
            {
                strSql.Append("Cell_Fork_Type='" + model.Cell_Fork_Type + "',");
            }
            else
            {
                strSql.Append("Cell_Fork_Type= null ,");
            }
            if (model.Cell_Layer != null)
            {
                strSql.Append("Cell_Layer=" + model.Cell_Layer + ",");
            }
            else
            {
                strSql.Append("Cell_Layer= null ,");
            }
            if (model.Cell_Column != null)
            {
                strSql.Append("Cell_Column=" + model.Cell_Column + ",");
            }
            else
            {
                strSql.Append("Cell_Column= null ,");
            }
            if (model.Cell_Row != null)
            {
                strSql.Append("Cell_Row=" + model.Cell_Row + ",");
            }
            else
            {
                strSql.Append("Cell_Row= null ,");
            }
            if (model.Cell_Reserve1 != null)
            {
                strSql.Append("Cell_Reserve1='" + model.Cell_Reserve1 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve1= null ,");
            }
            if (model.Cell_Reserve2 != null)
            {
                strSql.Append("Cell_Reserve2='" + model.Cell_Reserve2 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve2= null ,");
            }
            if (model.Cell_Reserve3 != null)
            {
                strSql.Append("Cell_Reserve3='" + model.Cell_Reserve3 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve3= null ,");
            }
            if (model.Cell_Reserve4 != null)
            {
                strSql.Append("Cell_Reserve4='" + model.Cell_Reserve4 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve4= null ,");
            }
            if (model.Cell_Reserve5 != null)
            {
                strSql.Append("Cell_Reserve5='" + model.Cell_Reserve5 + "',");
            }
            else
            {
                strSql.Append("Cell_Reserve5= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Cell_ID='" + model.Cell_ID + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
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
        public bool Delete(string Cell_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell ");
            strSql.Append(" where Cell_ID='" + Cell_ID + "' ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Cell_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WH_Cell ");
            strSql.Append(" where Cell_ID in (" + Cell_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public WMS_Database.WH_CellModel GetModel(string Cell_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Reserve2,Cell_Reserve3,Cell_Reserve4,Cell_Reserve5 ");
            strSql.Append(" from WH_Cell ");
            strSql.Append(" where Cell_ID='" + Cell_ID + "' ");
            WMS_Database.WH_CellModel model = new WMS_Database.WH_CellModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
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
        public WMS_Database.WH_CellModel DataRowToModel(DataRow row)
        {
            WMS_Database.WH_CellModel model = new WMS_Database.WH_CellModel();
            if (row != null)
            {
                if (row["Cell_ID"] != null)
                {
                    model.Cell_ID = row["Cell_ID"].ToString();
                }
                if (row["Area_ID"] != null)
                {
                    model.Area_ID = row["Area_ID"].ToString();
                }
                if (row["Cell_Code"] != null)
                {
                    model.Cell_Code = row["Cell_Code"].ToString();
                }
                if (row["Cell_Name"] != null)
                {
                    model.Cell_Name = row["Cell_Name"].ToString();
                }
                if (row["Cell_Lane"] != null)
                {
                    model.Cell_Lane = row["Cell_Lane"].ToString();
                }
                if (row["Device_Code"] != null)
                {
                    model.Device_Code = row["Device_Code"].ToString();
                }
                if (row["Shelf_Type"] != null)
                {
                    model.Shelf_Type = row["Shelf_Type"].ToString();
                }
                if (row["Cell_InOut"] != null)
                {
                    model.Cell_InOut = row["Cell_InOut"].ToString();
                }
                if (row["Cell_Type"] != null)
                {
                    model.Cell_Type = row["Cell_Type"].ToString();
                }
                if (row["Cell_Storage_Type"] != null)
                {
                    model.Cell_Storage_Type = row["Cell_Storage_Type"].ToString();
                }
                if (row["Cell_Fork_Type"] != null)
                {
                    model.Cell_Fork_Type = row["Cell_Fork_Type"].ToString();
                }
                if (row["Cell_Layer"] != null && row["Cell_Layer"].ToString() != "")
                {
                    model.Cell_Layer = int.Parse(row["Cell_Layer"].ToString());
                }
                if (row["Cell_Column"] != null && row["Cell_Column"].ToString() != "")
                {
                    model.Cell_Column = int.Parse(row["Cell_Column"].ToString());
                }
                if (row["Cell_Row"] != null && row["Cell_Row"].ToString() != "")
                {
                    model.Cell_Row = int.Parse(row["Cell_Row"].ToString());
                }
                if (row["Cell_Reserve1"] != null)
                {
                    model.Cell_Reserve1 = row["Cell_Reserve1"].ToString();
                }
                if (row["Cell_Reserve2"] != null)
                {
                    model.Cell_Reserve2 = row["Cell_Reserve2"].ToString();
                }
                if (row["Cell_Reserve3"] != null)
                {
                    model.Cell_Reserve3 = row["Cell_Reserve3"].ToString();
                }
                if (row["Cell_Reserve4"] != null)
                {
                    model.Cell_Reserve4 = row["Cell_Reserve4"].ToString();
                }
                if (row["Cell_Reserve5"] != null)
                {
                    model.Cell_Reserve5 = row["Cell_Reserve5"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Reserve2,Cell_Reserve3,Cell_Reserve4,Cell_Reserve5 ");
            strSql.Append(" FROM WH_Cell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Cell_ID,Area_ID,Cell_Code,Cell_Name,Cell_Lane,Device_Code,Shelf_Type,Cell_InOut,Cell_Type,Cell_Storage_Type,Cell_Fork_Type,Cell_Layer,Cell_Column,Cell_Row,Cell_Reserve1,Cell_Reserve2,Cell_Reserve3,Cell_Reserve4,Cell_Reserve5 ");
            strSql.Append(" FROM WH_Cell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM WH_Cell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Cell_ID desc");
            }
            strSql.Append(")AS Row, T.*  from WH_Cell T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

