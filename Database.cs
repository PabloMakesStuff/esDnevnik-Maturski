using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

//ovo je pomocni fajl koji spaja bazu podataka sa celom aplikacijom
//pravi globalne funkcije koje koristim kasnije

namespace Maturski
{
    public static class Database
    {
        private static readonly string connStr =
            ConfigurationManager.ConnectionStrings["AccessDb"].ConnectionString;

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connStr);
        }

        // funkcija za vrsenje SELECT komandi, vraca DataTable
        public static DataTable execQuery(string query, params OleDbParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                {
                    // ↓ osigurava da se dodaje samo ne null sto mi smanjuje buduci pritisak
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var adapter = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // INSERT, UPDATE, DELETE, sto ne vraca nista
        public static int execNonQuery(string query, params OleDbParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
