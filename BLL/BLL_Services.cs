using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Services
    {
        private DAL_Repository repository = new DAL_Repository();

        //FUNSION PARA MOSTRAR PRODUCTOS
        public DataTable MostrarProductos()
        {

            DataTable tablaProductos = new DataTable();
            tablaProductos = repository.MostrarProductos();
            return tablaProductos;
        }

        //FUNSION PARA MOSTRAR CATEGORIAS
        public DataTable MostrarCategorias()
        {
            DataTable tablaCategoria = new DataTable();
            tablaCategoria = repository.MostrarCategorias();
            return tablaCategoria;
        }
        //FUNSION PARA MOSTRAR LABORATORIOS
        public DataTable MostrarLaboratorios()
        {
            DataTable tablaLaboratorios = new DataTable();
            tablaLaboratorios = repository.MostrarLaboratorios();
            return tablaLaboratorios;
        }
        //FUNSION PARA MOSTRAR PROVEEDORES
        public DataTable MostrarProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            tablaProveedores = repository.MostrarProveedores();
            return tablaProveedores;
        }



        //FUNSION PARA REGISTRAR PRODUCTOS
        public void InsertarProductos(string CodProducto, string NombProducto, int NitProveedor, int IdCategoria, int IdLaboratorio, string Descripcion)
        {
            repository.InsertarProducto(Convert.ToDecimal(CodProducto),NombProducto,Convert.ToDecimal(NitProveedor),Convert.ToInt32(IdCategoria),Convert.ToInt32(IdLaboratorio),Descripcion);
        }

        //FUNSION PARA REGISTRAR LOTES
        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            repository.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }


        public void EliminarPRod(string id)
        {
            repository.Eliminar(Convert.ToInt32(id));
        }
    }
}
