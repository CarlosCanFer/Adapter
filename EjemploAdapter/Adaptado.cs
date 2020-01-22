using EjemploAdapter.Interface;

namespace EjemploAdapter
{
    class Adaptado
    {
        public string ObtenerTotal()
        {
            int _iprimerturno = 587, _isegundoturno = 1023;
            int total = _iprimerturno + _isegundoturno;

            return "Identificador: 10 Nombre: La lomita Total venta:" + total;

        }
    }
}
