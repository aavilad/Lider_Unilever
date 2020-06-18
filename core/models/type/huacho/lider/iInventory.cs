using System;

namespace Lider.Huacho.Model.dbModel
{
    public class iInventory
    {
        public string CodigoEmpresa { get; set; }
        public string CodAlmacen { get; set; }
        public string NombreAlmacen { get; set; }
        public string CodProveedor { get; set; }
        public string NombProveedor { get; set; }
        public string CodigoProducto { get; set; }
        public int StockEnUnidadDeConsumo { get; set; }
        public string UnidadDeMedidaDeConsumo { get; set; }
        public decimal StockEnUnidadDeCompra { get; set; }
        public string UnidadDeMedidaDeCompra { get; set; }
        public decimal ValorStock { get; set; }
        public string FechaStock { get; set; }
        public decimal IngresosEnUnidadDeConsumo { get; set; }
        public decimal ValorIngresos { get; set; }
        public decimal VentasEnUnidadDeConsumo { get; set; }
        public decimal ValorVentas { get; set; }
        public decimal OtrosEnUnidadDeConsumo { get; set; }
        public decimal ValorOtros { get; set; }
        public int Periodo { get; set; }
    }
}
