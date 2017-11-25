using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProjects
{
    public class ClaseCliente
    {
        private string _RazonSocial;
        private string _FechaRegistro;
        private string _NombreComercial;
        private string _RFC;
        private string _Direccion;
        private string _TelefonoEmpresa;
        private string _Extension;
        private string _NombreRepresentante;
        private string _TelefonoRepresentante;
        private string _ExtensionTelRepresentante;
        private string _CorreoRepresentante;
        private string _OtroTelRepresentante;
        private string _RENIECYT;
        private string _VigenciaRENIECYT;
        private string _DescripcionEmpresa;
        private string _EstrategiaTecnologica;
        private string _ProductosProcesosServicios;
        private string _AcervoTecnologico;

        //Propiedades
        
        public string RazonSocial
        {
            get { return this._RazonSocial; }
            set { this._RazonSocial = value; }
        }
        public string FechaRegistro
        {
            get { return this._FechaRegistro; }
            set { this._FechaRegistro = value; }
        }
        public string NombreComercial
        {
            get { return this._NombreComercial; }
            set { this._NombreComercial = value; }
        }
        public string RFC
        {
            get { return this._RFC; }
            set { this._RFC = value; }
        }
        public string Direccion
        {
            get { return this._Direccion; }
            set { this._Direccion = value; }
        }
        public string TelefonoEmpresa
        {
            get { return this._TelefonoEmpresa; }
            set { this._TelefonoEmpresa = value; }
        }
        public string ExtensionEmpresa
        {
            get { return this._Extension; }
            set { this._Extension = value; }
        }
        public string NombreRepLegal
        {
            get { return this._NombreRepresentante; }
            set { this._NombreRepresentante = value; }
        }
        public string CorreoRepLegal
        {
            get { return this._CorreoRepresentante; }
            set { this._CorreoRepresentante = value; }
        }
        public string TelefonoRepLegal
        {
            get { return this._TelefonoRepresentante; }
            set { this._TelefonoRepresentante = value; }
        }
        public string ExtensionTelRepLegal
        {
            get { return this._ExtensionTelRepresentante; }
            set { this._ExtensionTelRepresentante = value; }
        }
        public string OtroTelRepLegal
        {
            get { return this._OtroTelRepresentante; }
            set { this._OtroTelRepresentante = value; }
        }
        public string RENIECYT
        {
            get { return this._RENIECYT; }
            set { this._RENIECYT = value; }
        }
        public string VigenciaRENIECYT
        {
            get { return this._VigenciaRENIECYT; }
            set { this._VigenciaRENIECYT = value; }
        }
        public string DescripcionEmpresa
        {
            get { return this._DescripcionEmpresa; }
            set { this._DescripcionEmpresa = value; }
        }
        public string EstrategiaTecnologica
        {
            get { return this._EstrategiaTecnologica; }
            set { this._EstrategiaTecnologica = value; }
        }
        public string ProductosProcesosServicios
        {
            get { return this._ProductosProcesosServicios; }
            set { this._ProductosProcesosServicios = value; }
        }
        public string AcervoTecnologico
        {
            get { return this._AcervoTecnologico; }
            set { this._AcervoTecnologico = value; }
        }
        
    }
}