﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace contrato_trabajo.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerBodega", ReplyAction="http://tempuri.org/IService1/ObtenerBodegaResponse")]
        string ObtenerBodega(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerBodega", ReplyAction="http://tempuri.org/IService1/ObtenerBodegaResponse")]
        System.Threading.Tasks.Task<string> ObtenerBodegaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerProductos", ReplyAction="http://tempuri.org/IService1/ObtenerProductosResponse")]
        System.Data.DataSet ObtenerProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerProductos", ReplyAction="http://tempuri.org/IService1/ObtenerProductosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEncabezadoFactura", ReplyAction="http://tempuri.org/IService1/ObtenerEncabezadoFacturaResponse")]
        System.Data.DataSet ObtenerEncabezadoFactura();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEncabezadoFactura", ReplyAction="http://tempuri.org/IService1/ObtenerEncabezadoFacturaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerEncabezadoFacturaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerDetalleFactura", ReplyAction="http://tempuri.org/IService1/ObtenerDetalleFacturaResponse")]
        System.Data.DataSet ObtenerDetalleFactura();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerDetalleFactura", ReplyAction="http://tempuri.org/IService1/ObtenerDetalleFacturaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetalleFacturaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerPrecio", ReplyAction="http://tempuri.org/IService1/ObtenerPrecioResponse")]
        System.Data.DataSet ObtenerPrecio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerPrecio", ReplyAction="http://tempuri.org/IService1/ObtenerPrecioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerPrecioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PruebaCristian", ReplyAction="http://tempuri.org/IService1/PruebaCristianResponse")]
        System.Data.DataSet PruebaCristian();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PruebaCristian", ReplyAction="http://tempuri.org/IService1/PruebaCristianResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PruebaCristianAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerProducto", ReplyAction="http://tempuri.org/IService1/ObtenerProductoResponse")]
        System.Data.DataSet ObtenerProducto(string empleado, string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerProducto", ReplyAction="http://tempuri.org/IService1/ObtenerProductoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProductoAsync(string empleado, string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerMarca", ReplyAction="http://tempuri.org/IService1/ObtenerMarcaResponse")]
        System.Data.DataSet ObtenerMarca(string empleado, string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerMarca", ReplyAction="http://tempuri.org/IService1/ObtenerMarcaResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerMarcaAsync(string empleado, string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerVendedor", ReplyAction="http://tempuri.org/IService1/ObtenerVendedorResponse")]
        System.Data.DataSet ObtenerVendedor(string empleado, string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerVendedor", ReplyAction="http://tempuri.org/IService1/ObtenerVendedorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ObtenerVendedorAsync(string empleado, string fecha1, string fecha2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : contrato_trabajo.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<contrato_trabajo.ServiceReference1.IService1>, contrato_trabajo.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtenerBodega(int ID) {
            return base.Channel.ObtenerBodega(ID);
        }
        
        public System.Threading.Tasks.Task<string> ObtenerBodegaAsync(int ID) {
            return base.Channel.ObtenerBodegaAsync(ID);
        }
        
        public System.Data.DataSet ObtenerProductos() {
            return base.Channel.ObtenerProductos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProductosAsync() {
            return base.Channel.ObtenerProductosAsync();
        }
        
        public System.Data.DataSet ObtenerEncabezadoFactura() {
            return base.Channel.ObtenerEncabezadoFactura();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerEncabezadoFacturaAsync() {
            return base.Channel.ObtenerEncabezadoFacturaAsync();
        }
        
        public System.Data.DataSet ObtenerDetalleFactura() {
            return base.Channel.ObtenerDetalleFactura();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerDetalleFacturaAsync() {
            return base.Channel.ObtenerDetalleFacturaAsync();
        }
        
        public System.Data.DataSet ObtenerPrecio() {
            return base.Channel.ObtenerPrecio();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerPrecioAsync() {
            return base.Channel.ObtenerPrecioAsync();
        }
        
        public System.Data.DataSet PruebaCristian() {
            return base.Channel.PruebaCristian();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PruebaCristianAsync() {
            return base.Channel.PruebaCristianAsync();
        }
        
        public System.Data.DataSet ObtenerProducto(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerProducto(empleado, fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerProductoAsync(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerProductoAsync(empleado, fecha1, fecha2);
        }
        
        public System.Data.DataSet ObtenerMarca(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerMarca(empleado, fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerMarcaAsync(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerMarcaAsync(empleado, fecha1, fecha2);
        }
        
        public System.Data.DataSet ObtenerVendedor(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerVendedor(empleado, fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ObtenerVendedorAsync(string empleado, string fecha1, string fecha2) {
            return base.Channel.ObtenerVendedorAsync(empleado, fecha1, fecha2);
        }
    }
}