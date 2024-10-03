using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj.Models;
using System.Reflection;
using Dapper;

namespace TestProj
{
    public class CommonClass
    {

        public SqlConnection SQL_Connection()
        {
            string connectionString = "Server=localhost;Database=testproj;Trusted_Connection=True;";
            SqlConnection SqlC = new SqlConnection(connectionString);
            return SqlC;
        }
        
        public List<AuthorModel> InsertAuthor(List<AuthorModel> obj)
        {
            using (var connection = SQL_Connection())
            {
                var dataTable = CommonStaticClass.ToDataTable(obj);

                var parameters = new
                {
                    table = dataTable.AsTableValuedParameter("TempAuthors")
                };

                return connection.Query<AuthorModel>("AutherInsUp", parameters, commandType: CommandType.StoredProcedure).ToList();

            }
        }
    
    
        public List<AuthorModel> GetAuther()
        {
            using (var connection = SQL_Connection())
            {
                
                return connection.Query<AuthorModel>("AutherGet", commandType: CommandType.StoredProcedure).ToList();

            }
        }


        public List<BooksModel> InsertBooks(List<BooksModel> obj)
        {
            using (var connection = SQL_Connection())
            {
                var dataTable = CommonStaticClass.ToDataTable(obj);
                dataTable.Columns.Remove("Name");
                var parameters = new
                {
                    table = dataTable.AsTableValuedParameter("BookType")
                };

                return connection.Query<BooksModel>("BookInsUp", parameters, commandType: CommandType.StoredProcedure).ToList();

            }
        }


        public List<BooksModel> GetBooks()
        {
            using (var connection = SQL_Connection())
            {

                return connection.Query<BooksModel>("BookGet", commandType: CommandType.StoredProcedure).ToList();

            }
        }
    }
}
