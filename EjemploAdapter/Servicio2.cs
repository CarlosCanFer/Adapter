using EjemploAdapter.DTO;
using EjemploAdapter.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAdapter
{
    public class Servicio2 : IDatosSucursal
    {
        private IDatosSucursal objlistaEntidades;

        public Servicio2(IDatosSucursal _objlistaEntidades)
        {
            this.objlistaEntidades = _objlistaEntidades;
        }

        public string DevuelveDatos()
        {
            throw new NotImplementedException();
        }

        public List<DatosSucursal> ObtenerTotal()
        {
            List<DatosSucursal> _lstdatossucursal = new List<DatosSucursal>();

            string jsonDataSucursal = objlistaEntidades.DevuelveDatos();

            JObject lstTemp = JObject.Parse(jsonDataSucursal);

            IList<JToken> result = lstTemp["Data"].Children().ToList();

            foreach (JToken resultado in result)
            {
                DatosSucursal SucursalFinal = JsonConvert.DeserializeObject<DatosSucursal>(resultado.ToString());
                _lstdatossucursal.Add(SucursalFinal);
            }          

            return _lstdatossucursal;
        }
    }
}
