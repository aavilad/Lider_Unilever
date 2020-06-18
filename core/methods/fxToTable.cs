using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Dapper;

namespace Lider_Unilever.core.methods {
    internal class fxToTable {
        public static DataTable Get<T> (List<T> items) {
            var dataTable = new DataTable (typeof (T).Name);
            var Props = typeof (T).GetProperties (BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
                dataTable.Columns.Add (prop.Name);
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                    values[i] = Props[i].GetValue (item, null);
                dataTable.Rows.Add (values);
            }
            return dataTable;
        }
        public static string Delete () {
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal))
            try {
                Cn.Execute ($"EXEC sp_MSforeachtable 'TRUNCATE TABLE ?';");
                return $"Limpieza exitosa.";
            } catch {
                return $"Limpieza Erronea.";
            }
        }
    }
}