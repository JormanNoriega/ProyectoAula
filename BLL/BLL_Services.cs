using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Services
    {
        private DAL_Repository repository = new DAL_Repository();

        //FUNCION PARA MOSTRAR PRODUCTOS
        public DataTable MostrarProductos()
        {
            DataTable tablaProductos = new DataTable();
            tablaProductos = repository.MostrarProductos();
            return tablaProductos;
        }
        //FUNCION PARA MOSTRAR CATEGORIAS
        public DataTable MostrarCategorias()
        {
            DataTable tablaCategoria = new DataTable();
            tablaCategoria = repository.MostrarCategorias();
            return tablaCategoria;
        }
        //FUNCION PARA MOSTRAR LABORATORIOS
        public DataTable MostrarLaboratorios()
        {
            DataTable tablaLaboratorios = new DataTable();
            tablaLaboratorios = repository.MostrarLaboratorios();
            return tablaLaboratorios;
        }
        //FUNCION PARA MOSTRAR PROVEEDORES
        public DataTable MostrarProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            tablaProveedores = repository.MostrarProveedores();
            return tablaProveedores;
        }
        //FUNCION PARA MOSTRAR LOTES
        public DataTable MostrarLotes(string CodProducto)
        {
            DataTable tablaLotes = new DataTable();
            tablaLotes = repository.MostrarLotes(Convert.ToDecimal(CodProducto));
            return tablaLotes;
        }
        //FUNCION PARA MOSTRAR PRODUCTOS FILTRADOS

        //public DataTable MostrarProductoFiltrado(string CodProducto)
        //{

        //    DAL_Repository productosfiltrados = new DAL_Repository();
        //    DataTable tablaProductoFiltrado = new DataTable();
        //    if (CodProducto == "")
        //    {
        //        tablaProductoFiltrado = productosfiltrados.MostrarProductos();
        //        return tablaProductoFiltrado;
        //    }
        //    else
        //    {
        //        tablaProductoFiltrado = productosfiltrados.MostrarProductoFiltrado(Convert.ToDecimal(CodProducto));
        //        return tablaProductoFiltrado;
        //    }
        //}

        ////FUNCION PARA REGISTRAR PRODUCTOS
        //public void InsertarProductos(string CodProducto, string NombProducto, int NitProveedor, int IdCategoria, int IdLaboratorio, string Descripcion)
        //{
        //    repository.InsertarProducto(Convert.ToDecimal(CodProducto), NombProducto, Convert.ToDecimal(NitProveedor), Convert.ToInt32(IdCategoria), Convert.ToInt32(IdLaboratorio), Descripcion);
        //}

        ////FUNCION PARA REGISTRAR LOTES
        //public void InsertarLote(string CodLote, string CodProducto, DateTime Vencimiento, string Cantidad, string PrecioCompra, string PrecioVentan)
        //{
        //    repository.InsertarLote(CodLote, Convert.ToDecimal(CodProducto), Vencimiento, Convert.ToInt32(Cantidad), Convert.ToDecimal(PrecioCompra), Convert.ToDecimal(PrecioVentan));
        //}


        //public void EditarProd(string CodLote, string CodProducto, DateTime Vencimiento, int Cantidad, string PrecioCompra, string PrecioVentan)
        //{

        //}


        //public void EliminarPRod(string id)
        //{
        //    repository.Eliminar(Convert.ToInt32(id));
        //}
    }
}
