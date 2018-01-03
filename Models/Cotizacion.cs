/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Cotizaciones.Models {

    /// <summary>
    /// Clase que representa a una cotizacion en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Cotizacion
    {
        public int CotizacionId { get; set; }

        public string Nombre { get; set; }

        public string Fecha { get; set; }

        public string Servicios { get; set; }

        public uint ValorCotizado { get; set; }

        public string Descripcion { get; set; }

        public int Rut { get; set; }
        public Persona Persona { get; set; }

    }
}