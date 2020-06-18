using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Lider_Unilever.core.methods {
    static class fxToSession {
        static string Huacho {
            get {
                try {
                    using (var Cn = new SqlConnection (models.ConnectionString.dbHuacho)) {
                        Cn.Open ();
                        return $"conexion exitosa";
                    }
                } catch {
                    return $"conexion erronea";
                }
            }
        }
        static string Local {
            get {
                try {
                    using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                        Cn.Open ();
                        return $"conexion exitosa";
                    }
                } catch {
                    return $"conexion erronea";
                }
            }
        }
    }
}