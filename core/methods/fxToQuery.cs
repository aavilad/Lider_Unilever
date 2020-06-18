using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using Dapper;
using Lider_Unilever.core.models.type;
///
///<Path: file path string variable>
///<database: database de connection>
///<Schema: table schema or function>
///
namespace Lider_Unilever.core.methods {
    class trujillo {
        // not implement;
    }

    internal class huacho {

        #region database
        static readonly string database = models.ConnectionString.dbHuacho;
        #endregion

        #region vendor
        public static void uVendedor (string path) {
            string sqlQuery =
                $@"BULK INSERT DismarHuacho.Vendedor FROM '@RutaArchivo'" +
                $@"WITH(FIELDTERMINATOR = '|', ROWTERMINATOR = '\n', FIRE_TRIGGERS); ";
            using (var Cn = new SqlConnection (database)) {
                Cn.Query<models.type.huacho.dismar.uVendedor> (sqlQuery.Replace ("@RutaArchivo", path));
            }
        }
        #endregion

        #region client
        public static IEnumerable<models.type.huacho.dismar.CLIENTE> Cliente (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.CLIENTE> ($"select * from {Schema}.dbo.cliente").ToList ();
            }
        }
        #endregion

        #region ticket
        public static IEnumerable<models.type.huacho.dismar.DOCUMENTO> Documento (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"select * from {Schema}.dbo.Documento where fecha between @Desde and @Hasta";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.DOCUMENTO> (sqlQuery, new { Desde = StartDate, Hasta = EndDate }).ToList ();
            }
        }
        #endregion

        #region ticket-details
        public static List<models.type.huacho.dismar.DETADOC> DetaDoc (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery =
                $"SELECT DETADOC.* " +
                $"FROM {Schema}.dbo.DOCUMENTO " +
                $"     INNER JOIN {Schema}.dbo.DETADOC ON DOCUMENTO.Documento = DETADOC.Documento " +
                $"                           AND DOCUMENTO.TipoDoc = DETADOC.TipoDoc " +
                $"WHERE(DOCUMENTO.Fecha BETWEEN @Desde AND @Hasta);";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.DETADOC> (sqlQuery, new { Desde = StartDate, Hasta = EndDate }).ToList ();
            }
        }
        #endregion

        #region ticket-type
        public static IEnumerable<models.type.huacho.dismar.DOCTIPO> DocTipo (string Schema) {
            string sqlQuery = $"SELECT DOCTIPO.* FROM {Schema}.dbo.DOCTIPO;";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.DOCTIPO> (sqlQuery).ToList ();
            }
        }
        #endregion

        #region missing
        public static IEnumerable<models.type.huacho.dismar.faltante> Faltante (string Schema) {
            string sqlQuery = $"SELECT faltante.* FROM {Schema}.dbo.faltante;";
            using (var Cn = new SqlConnection (database)) { return Cn.Query<models.type.huacho.dismar.faltante> (sqlQuery).ToList (); }
        }
        #endregion

        #region brand
        public static IEnumerable<models.type.huacho.dismar.MARCA> Marca (string Schema) {
            string sqlQuery = $"SELECT MARCA.* FROM {Schema}.dbo.MARCA;";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.MARCA> (sqlQuery).ToList ();
            }
        }
        #endregion

        #region movement
        public static IEnumerable<models.type.huacho.dismar.Movimiento> Movimientos (DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT CodProd, Cantidad = SUM(cantidad * signo) FROM {Schema}.unilever.movimiento(@Hasta) GROUP BY CodProd;";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.Movimiento> (sqlQuery, new { Hasta = EndDate }).ToList ();
            }
        }
        #endregion

        #region product
        public static IEnumerable<models.type.huacho.dismar.PRODUCTO> Producto (string Schema) {
            string sqlQuery = $"SELECT TOP 100 PERCENT PRODUCTO.* FROM {Schema}.dbo.PRODUCTO;";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.PRODUCTO> (sqlQuery).ToList ();
            }
        }
        #endregion

        #region provider
        public static IEnumerable<models.type.huacho.dismar.PROVEEDOR> Proveedor (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.PROVEEDOR> ($"SELECT Proveedor.* FROM {Schema}.dbo.Proveedor;").ToList ();
            }
        }
        #endregion

        #region province
        public static IEnumerable<models.type.huacho.dismar.provincia> Provincia (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.provincia> ($"SELECT Provincia.* FROM {Schema}.dbo.Provincia;").ToList ();
            }
        }
        #endregion

        #region reference
        public static IEnumerable<models.type.huacho.dismar.referencia> Referencia (string Schema) {
            string sqlQuery = $"SELECT Referencia.* FROM {Schema}.dbo.Referencia;";
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.referencia> (sqlQuery).ToList ();
            }
        }
        #endregion

        #region region
        public static IEnumerable<models.type.huacho.dismar.Region> Region (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.Region> ($"SELECT Region.* FROM {Schema}.dbo.Region;").ToList ();
            }
        }
        #endregion

        #region vendor-personal
        public static IEnumerable<models.type.huacho.dismar.PERSONAL> Personal (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.PERSONAL> ($"SELECT Personal.* FROM {Schema}.dbo.Personal;").ToList ();
            }
        }
        #endregion

        #region business-type
        public static IEnumerable<models.type.huacho.dismar.TIPONEG> TipoNegocio (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.TIPONEG> ($"SELECT TIPONEG.* FROM {Schema}.dbo.TIPONEG;").ToList ();
            }
        }
        #endregion

        #region zone
        public static IEnumerable<models.type.huacho.dismar.ZONA> Zona (string Schema) {
            using (var Cn = new SqlConnection (database)) {
                return Cn.Query<models.type.huacho.dismar.ZONA> ($"SELECT ZONA.* FROM {Schema}.dbo.ZONA;").ToList ();
            }
        }
        #endregion

        #region vendor-zone
        public static IEnumerable<models.type.huacho.dismar.ZONA_PERSONAL> ZonaPersonal (string Schema) {
            using (var Cn = new SqlConnection (database))
            return Cn.Query<models.type.huacho.dismar.ZONA_PERSONAL> ($"SELECT ZONA_PERSONAL.* FROM {Schema}.dbo.ZONA_PERSONAL;").ToList ();
        }
        #endregion

    }

    class bulkcopy {

        #region initializacion
        static Stopwatch Counter = new Stopwatch ();
        #endregion

        #region vendor
        public static void Vendor (string Path) => huacho.uVendedor (Path);
        #endregion

        #region client
        public static string Client(string Schema)
        {
            Counter.Reset();
            Counter.Start();
            using (var bky = new SqlBulkCopy(Properties.getConnectionLocaldb))
            {
                bky.DestinationTableName = "DismarHuacho.Cliente";
                bky.WriteToServer(Fucntions.ToDataTable(SqlQueryDesign.Cliente()));
            }
            Counter.Stop();
            return $"{Counter.Elapsed.ToString(@"hh\:mm\:ss\:fff")}";
        }
        #endregion
        

    }

    class vs_interfaces {
        #region client
        public static IEnumerable<IClients> Client (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery =
                $"SELECT PKID, " +
                $"CodigoDistribuidor," +
                $"CodigoCliente, " +
                $"NombreCliente, " +
                $"RUC, " +
                $"DNI, " +
                $"Direccion," +
                $"Telefono, " +
                $"[E-mail] Email," +
                $"Canal, " +
                $"TipoNegocio," +
                $"Zona, " +
                $"Modulo, " +
                $"Distrito, " +
                $"Georeferencia," +
                $"CodigoVendedor, " +
                $"DiaVisita, " +
                $"[STATUS], " +
                $"CodCorporativo," +
                $"Mercado, " +
                $"Clasificacion" +
                $" FROM schema.pFT_Clientes(@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<models.type.IClients> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

        #region product
        public static IEnumerable<IProducts> Product (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT * FROM  schema.pFT_Productos(@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<models.type.IProducts> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

        #region vendor
        public static IEnumerable<IVendor> iVendor (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT * FROM schema.pFT_Vendedores(@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<IVendor> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

        #region inventory
        public static IEnumerable<IInventory> Inventory (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT * FROM schema.pFT_Stock(@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<IInventory> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

        #region ticket
        public static IEnumerable<IDocumentHeader> Document (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT * FROM schema.[pFT_Ventas.Cabecera](@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<IDocumentHeader> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

        #region ticket-details
        public static IEnumerable<IDocumentBody> Detail (DateTime StartDate, DateTime EndDate, string Schema) {
            string sqlQuery = $"SELECT * FROM schema.[pFT_Ventas.Detalle](@Desde,@Hasta);";
            using (var Cn = new SqlConnection (models.ConnectionString.dbLocal)) {
                return Cn.Query<IDocumentBody> (sqlQuery.Replace ("schema", Schema), new {
                    Desde = StartDate.ToString ("yyyyMMdd"), Hasta = EndDate.ToString ("yyyyMMdd")
                }).ToList ();
            }
        }
        #endregion

    }

}