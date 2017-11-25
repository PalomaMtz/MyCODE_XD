using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProjects
{
    public class ClaseProyecto
    {
        string _FolioProyecto,
             _StatusProyecto,
             _Empresa,
             _NombreRespTecnico,
             _TelefonoRespTecnico,
             _ExtensionTelRespTecnico,
             _CorreoRespTecnico,
             _OtroTelefonoRespTecnico,
             _NombreRespAdministrativo,
             _TelefonoRespAdministrativo,
             _ExtensionTelRespAdministrativo,
             _CorreoRespAdministrativo,
             _OtroTelefonoRespAdministrativo,
             _TituloProyecto,
             _DescripcionPropuesta,
             _ObjetivoProyecto,
             _ResultadosEsperados,
             _ImpactoEstrategiaTecnologica;

        public string FolioProyecto
        {
            get { return this._FolioProyecto; }
            set { this._FolioProyecto = value; }
        }
        public string StatusProyecto
        {
            get { return this._StatusProyecto; }
            set { this._StatusProyecto = value; }
        }
        public string Empresa
        {
            get { return this._Empresa; }
            set { this._Empresa = value; }
        }
        public string RespTecnico
        {
            get { return this._NombreRespTecnico; }
            set { this._NombreRespTecnico = value; }
        }        
        public string TelefonoRespTecnico
        {
            get { return this._TelefonoRespTecnico; }
            set { this._TelefonoRespTecnico = value; }
        }        
        public string ExtensionTelRespTecnico
        {
            get { return this._ExtensionTelRespTecnico; }
            set { this._ExtensionTelRespTecnico = value; }
        }        
        public string CorreoRespTecnico
        {
            get { return this._CorreoRespTecnico; }
            set { this._CorreoRespTecnico = value; }
        }
        public string OtroTelefonoRespTecnico
        {
            get { return this._OtroTelefonoRespTecnico; }
            set { this._OtroTelefonoRespTecnico = value; }
        }       
        public string RespAdministrativo
        {
            get { return this._NombreRespAdministrativo; }
            set { this._NombreRespAdministrativo = value; }
        }        
        public string TelefonoRespAdministrativo
        {
            get { return this._TelefonoRespAdministrativo; }
            set { this._TelefonoRespAdministrativo = value; }
        }        
        public string ExtensionTelRespAdministrativo
        {
            get { return this._ExtensionTelRespAdministrativo; }
            set { this._ExtensionTelRespAdministrativo = value; }
        }        
        public string CorreoRespAdministrativo
        {
            get { return this._CorreoRespAdministrativo; }
            set { this._CorreoRespAdministrativo = value; }
        }
        public string OtroTelefonoRespAdministrativo
        {
            get { return this._OtroTelefonoRespAdministrativo; }
            set { this._OtroTelefonoRespAdministrativo = value; }
        } 
        public string TituloProyecto
        {
            get { return this._TituloProyecto; }
            set { this._TituloProyecto = value; }
        }        
        public string DescripcionPropuesta
        {
            get { return this._DescripcionPropuesta; }
            set { this._DescripcionPropuesta= value; }
        }
        public string ObjetivoProyecto
        {
            get { return this._ObjetivoProyecto; }
            set { this._ObjetivoProyecto = value; }
        }
        public string ResultadosEsperados
        {
            get { return this._ResultadosEsperados; }
            set { this._ResultadosEsperados = value; }
        }
        public string ImpactoEstrategiaTecnologica
        {
            get { return this._ImpactoEstrategiaTecnologica; }
            set { this._ImpactoEstrategiaTecnologica = value; }
        }               
        
    }
}