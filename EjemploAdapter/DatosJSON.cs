using EjemploAdapter.Interface;


namespace EjemploAdapter
{
    public class DatosJSON : IDatosSucursal
    {
        public string DevuelveDatos()
        {
            string data = @"{'Data': [{'Id':'1','cSucursal':'lomita','TotalVentas':'$ 1,234.00'}, {'Id':'2','cSucursal':'lomota','TotalVentas':'$ 5,345.00'}]}";
            return data;
        }     
    }
}
