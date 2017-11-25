using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProjects.TDAClases
{
    public class ClaseIntegrante
    {
        string _IDIntegrante,
            _IDProyecto,
            _Nombre,
            _RFC,
            _Telefono,
            _Extension,
            _OtroTel,
            _Correo,
            _FechaInicio,
            _FechaFinal;
        int _Sueldo;
        byte[] _CVUPDF;

        public string IdIntegrante
        {
            get { return this._IDIntegrante; }
            set { this._IDIntegrante = value; }
        }
        public string IdProyecto
        {
            get { return this._IDProyecto; }
            set { this._IDProyecto = value; }
        }
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }
        public string RFC
        {
            get { return this._RFC; }
            set { this._RFC = value; }
        }
        public string Telefono
        {
            get { return this._Telefono; }
            set { this._Telefono = value; }
        }
        public string Extension
        {
            get { return this._Extension; }
            set { this._Extension = value; }
        }
        public string OtroTelefono
        {
            get { return this._OtroTel; }
            set { this._OtroTel = value; }
        }
        public string Correo
        {
            get { return this._Correo; }
            set { this._Correo = value; }
        }
        public string FechaInicio
        {
            get { return this._FechaInicio; }
            set { this._FechaInicio = value; }
        }
        public string FechaFinal
        {
            get { return this._FechaFinal; }
            set { this._FechaFinal = value; }
        }
        public int Sueldo
        {
            get { return this._Sueldo; }
            set { this._Sueldo = value; }
        }
        public byte[] CVU_pdf
        {
            get { return this._CVUPDF; }
            set { this._CVUPDF = value; }
        }

    }
}