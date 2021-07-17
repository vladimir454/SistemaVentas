
namespace Sistema.Entidades
{ //creando una clase por cada tabla en nuestra base de datos en sql server
    //realizamos la persistencia
    public class Categoria
    {
        public int IdCategoria { get; set; }//set para almacenar  y get para obtener los datos
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public  bool Estado { get; set; }

    }//se recomienda ver los campos que se tiene en la tabla
}
