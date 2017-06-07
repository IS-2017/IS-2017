using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WebServiceCRM
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string ObtenerBodega(int ID);
        [OperationContract]
        DataSet ObtenerProductos();
        [OperationContract]
        DataSet ObtenerEncabezadoFactura();
        [OperationContract]
        DataSet ObtenerDetalleFactura();
        [OperationContract]
        DataSet ObtenerPrecio();
        [OperationContract]
        DataSet PruebaCristian();

        [OperationContract]
        DataSet ObtenerProducto(string empleado, string fecha1, string fecha2);
        [OperationContract]
        DataSet ObtenerMarca(string empleado, string fecha1, string fecha2);
        [OperationContract]
        DataSet ObtenerVendedor(string empleado, string fecha1, string fecha2);
    }





}
