using DapperSample.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace DapperSample.Models.Repository 
{
    public class SupplierRepository
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["DapperSampleConnection"].ToString();

        public void Save(Supplier model) 
        {
            using (var sqlConnection = new SqlConnection(ConnectionString)) 
            {
                sqlConnection.Execute("INSERT INTO SUPPLIER(CompanyName,ContactName, City, Country) VALUES (@CompanyName, @ContactName, @City, @Country)", model);
            }
        }

        public void Update(Supplier model) 
        {
            using (var sqlConnection = new SqlConnection(ConnectionString)) 
            {
                sqlConnection.Execute(@"UPDATE SUPPLIER
                                        SET CompanyName = @CompanyName, 
                                            ContactName = @ContactName,
                                            City = @City,
                                            Country = @Country
                                        WHERE ID = @Id", model);
            }
        }

        public void Delete(Supplier model) 
        {
            using (var sqlConnection = new SqlConnection(ConnectionString)) 
            {
                sqlConnection.Execute("DELETE FROM SUPPLIER WHERE ID = @Id", model);
            }
        }

    }
}