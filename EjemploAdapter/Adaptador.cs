using System.Collections.Generic;
using EjemploAdapter.DTO;
using EjemploAdapter.Interface;

namespace EjemploAdapter
{
    class Adaptador : IDatosSucursal
    {
        protected readonly Adaptado _adaptado;

        public Adaptador(Adaptado adaptado)
        {
            this._adaptado = adaptado;
        }
        public string DevuelveDatos()
        {
            return $"Esto es '{this._adaptado.ObtenerTotal()}'";
        }

        public List<DatosSucursal> ObtenerTotal()
        {
            throw new System.NotImplementedException();
        }
    }
}
