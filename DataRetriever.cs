using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Coursework
{
    public static class DataRetriever
    {
        public static List<string[]> GetGoodsInfo(OracleConnection connection)
        {
            connection.Open();
            using (OracleCommand goodsCountCmd = new OracleCommand())
            {
                goodsCountCmd.Connection = connection;
                goodsCountCmd.CommandType = CommandType.StoredProcedure;
                goodsCountCmd.CommandText = "company_database_api.get_items_count";
                goodsCountCmd.Parameters.Add("items_count", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue;
                goodsCountCmd.ExecuteNonQuery();
                int goodsCount = int.Parse(goodsCountCmd.Parameters["items_count"].Value.ToString());

                using (OracleCommand goodsListCmd = new OracleCommand())
                {
                    OracleParameter p_id = new OracleParameter();
                    OracleParameter p_name = new OracleParameter();
                    OracleParameter p_priority = new OracleParameter();
                    OracleParameter p_wh1 = new OracleParameter();
                    OracleParameter p_wh2 = new OracleParameter();

                    p_id.OracleDbType = OracleDbType.Decimal;
                    p_name.OracleDbType = OracleDbType.Varchar2;
                    p_priority.OracleDbType = OracleDbType.Decimal;
                    p_wh1.OracleDbType = OracleDbType.Decimal;
                    p_wh2.OracleDbType = OracleDbType.Decimal;

                    p_id.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_name.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_priority.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_wh1.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_wh2.CollectionType = OracleCollectionType.PLSQLAssociativeArray;

                    p_id.Direction = ParameterDirection.Output;
                    p_name.Direction = ParameterDirection.Output;
                    p_priority.Direction = ParameterDirection.Output;
                    p_wh1.Direction = ParameterDirection.Output;
                    p_wh2.Direction = ParameterDirection.Output;

                    p_id.Size = goodsCount;
                    p_name.Size = goodsCount;
                    p_priority.Size = goodsCount;
                    p_wh1.Size = goodsCount;
                    p_wh2.Size = goodsCount;

                    int[] strsize = new int[goodsCount];
                    for (int i = 0; i < goodsCount; i++)
                    {
                        strsize[i] = 50;
                    }
                    p_name.ArrayBindSize = strsize;

                    goodsListCmd.Connection = connection;
                    goodsListCmd.CommandType = CommandType.StoredProcedure;
                    goodsListCmd.CommandText = "company_database_api.get_items_info";
                    goodsListCmd.Parameters.Add(p_id);
                    goodsListCmd.Parameters.Add(p_name);
                    goodsListCmd.Parameters.Add(p_priority);
                    goodsListCmd.Parameters.Add(p_wh1);
                    goodsListCmd.Parameters.Add(p_wh2);

                    goodsListCmd.ExecuteNonQuery();

                    List<string[]> dataList = new List<string[]>();
                    for (int i = 0; i < goodsCount; i++)
                    {
                        dataList.Add(new string[6]);
                        dataList[dataList.Count - 1][0] = (p_id.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][1] = (p_name.Value as OracleString[])[i].ToString();
                        dataList[dataList.Count - 1][2] = (p_priority.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][3] = (p_wh1.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][4] = (p_wh2.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][5] = ((p_wh1.Value as OracleDecimal[])[i] + (p_wh2.Value as OracleDecimal[])[i]).ToString();
                    }
                    return dataList;
                }
            }
        }

        public static List<string[]> GetSalesInfo(OracleConnection connection)
        {
            connection.Open();
            using (OracleCommand salesCountCmd = new OracleCommand())
            {
                salesCountCmd.Connection = connection;
                salesCountCmd.CommandType = CommandType.StoredProcedure;
                salesCountCmd.CommandText = "company_database_api.get_sales_count";
                salesCountCmd.Parameters.Add("sales_count", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue;
                salesCountCmd.ExecuteNonQuery();
                int salesCount = int.Parse(salesCountCmd.Parameters["sales_count"].Value.ToString());

                using (OracleCommand salesListCmd = new OracleCommand())
                {
                    OracleParameter p_id = new OracleParameter();
                    OracleParameter p_date = new OracleParameter();
                    OracleParameter p_good_id = new OracleParameter();
                    OracleParameter p_good_name = new OracleParameter();
                    OracleParameter p_good_count = new OracleParameter();

                    p_id.OracleDbType = OracleDbType.Decimal;
                    p_date.OracleDbType = OracleDbType.Varchar2;
                    p_good_id.OracleDbType = OracleDbType.Decimal;
                    p_good_name.OracleDbType = OracleDbType.Varchar2;
                    p_good_count.OracleDbType = OracleDbType.Decimal;

                    p_id.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_date.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_good_id.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_good_name.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                    p_good_count.CollectionType = OracleCollectionType.PLSQLAssociativeArray;

                    p_id.Size = salesCount;
                    p_date.Size = salesCount;
                    p_good_id.Size = salesCount;
                    p_good_name.Size = salesCount;
                    p_good_count.Size = salesCount;

                    p_id.Direction = ParameterDirection.Output;
                    p_date.Direction = ParameterDirection.Output;
                    p_good_id.Direction = ParameterDirection.Output;
                    p_good_name.Direction = ParameterDirection.Output;
                    p_good_count.Direction = ParameterDirection.Output;

                    int[] strsize = new int[salesCount];
                    for (int i = 0; i < salesCount; i++)
                    {
                        strsize[i] = 50;
                    }
                    p_good_name.ArrayBindSize = strsize;
                    p_date.ArrayBindSize = strsize;

                    salesListCmd.Connection = connection;
                    salesListCmd.CommandType = CommandType.StoredProcedure;
                    salesListCmd.CommandText = "company_database_api.get_sales_info";
                    salesListCmd.Parameters.Add(p_id);
                    salesListCmd.Parameters.Add(p_date);
                    salesListCmd.Parameters.Add(p_good_id);
                    salesListCmd.Parameters.Add(p_good_name);
                    salesListCmd.Parameters.Add(p_good_count);

                    salesListCmd.ExecuteNonQuery();

                    List<string[]> dataList = new List<string[]>();
                    for (int i = 0; i < salesCount; i++)
                    {
                        dataList.Add(new string[5]);
                        dataList[dataList.Count - 1][0] = (p_id.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][1] = (p_date.Value as OracleString[])[i].ToString();
                        dataList[dataList.Count - 1][2] = (p_good_id.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][3] = (p_good_name.Value as OracleString[])[i].ToString();
                        dataList[dataList.Count - 1][4] = (p_good_count.Value as OracleDecimal[])[i].ToString();
                    }
                    return dataList;
                }
            }
        }

        public static List<string[]> GetGoodsList(OracleConnection connection)
        {
            connection.Open();
            using (OracleCommand goodsCountCmd = new OracleCommand())
            {
                goodsCountCmd.Connection = connection;
                goodsCountCmd.CommandType = CommandType.StoredProcedure;
                goodsCountCmd.CommandText = "company_database_api.get_items_count";
                goodsCountCmd.Parameters.Add("items_count", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue;
                goodsCountCmd.ExecuteNonQuery();
                int goodsCount = int.Parse(goodsCountCmd.Parameters["items_count"].Value.ToString());

                using (OracleCommand goodsListCmd = new OracleCommand())
                {
                    OracleParameter p_id = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Decimal,
                        Size = goodsCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray
                    };

                    int[] strsize = new int[goodsCount];
                    for (int i = 0; i < goodsCount; i++)
                    {
                        strsize[i] = 50;
                    }
                    OracleParameter p_name = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Varchar2,
                        Size = goodsCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                        ArrayBindSize = strsize
                    };

                    goodsListCmd.Parameters.Add(p_id);
                    goodsListCmd.Parameters.Add(p_name);
                    goodsListCmd.Connection = connection;
                    goodsListCmd.CommandType = CommandType.StoredProcedure;
                    goodsListCmd.CommandText = "company_database_api.get_goods_list";
                    goodsListCmd.ExecuteNonQuery();
                    connection.Close();
                    List<string[]> dataList = new List<string[]>();
                    for (int i = 0; i < goodsCount; i++)
                    {
                        dataList.Add(new string[2]);
                        dataList[dataList.Count - 1][0] = (p_id.Value as OracleDecimal[])[i].ToString();
                        dataList[dataList.Count - 1][1] = (p_name.Value as OracleString[])[i].ToString();
                    }
                    return dataList;
                }
            }
        }

        public static List<string[]> GetMostPopular(OracleConnection connection)
        {
            using (OracleCommand salesCountCmd = new OracleCommand())
            {
                salesCountCmd.Connection = connection;
                connection.Open();
                salesCountCmd.CommandType = CommandType.StoredProcedure;
                salesCountCmd.CommandText = "company_database_api.get_distinct_sales_count";
                salesCountCmd.Parameters.Add("sales_count", OracleDbType.Decimal).Direction = ParameterDirection.ReturnValue;
                salesCountCmd.ExecuteNonQuery();
                int salesCount = int.Parse(salesCountCmd.Parameters["sales_count"].Value.ToString());
                int linesCount = (salesCount >= 5) ? 5 : salesCount;
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.get_most_popular";

                    OracleParameter p_id = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Decimal,
                        Size = linesCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray
                    };

                    int[] strsize = new int[linesCount];
                    for (int i = 0; i < linesCount; i++)
                    {
                        strsize[i] = 50;
                    }
                    OracleParameter p_name = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Varchar2,
                        Size = linesCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                        ArrayBindSize = strsize
                    };

                    OracleParameter p_priority = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Decimal,
                        Size = linesCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray
                    };

                    OracleParameter p_total = new OracleParameter()
                    {
                        Direction = ParameterDirection.Output,
                        OracleDbType = OracleDbType.Decimal,
                        Size = linesCount,
                        CollectionType = OracleCollectionType.PLSQLAssociativeArray
                    };

                    cmd.Parameters.Add(p_id);
                    cmd.Parameters.Add(p_name);
                    cmd.Parameters.Add(p_priority);
                    cmd.Parameters.Add(p_total);

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    List<string[]> dataList = new List<string[]>();
                    for (int i = 0; i < linesCount; i++)
                    {
                        dataList.Add(new string[4]);
                        dataList[i][0] = (p_id.Value as OracleDecimal[])[i].ToString();
                        dataList[i][1] = (p_name.Value as OracleString[])[i].ToString();
                        dataList[i][2] = (p_priority.Value as OracleDecimal[])[i].ToString();
                        dataList[i][3] = (p_total.Value as OracleDecimal[])[i].ToString();
                    }
                    return dataList;
                }
            }
        }
    }
}
