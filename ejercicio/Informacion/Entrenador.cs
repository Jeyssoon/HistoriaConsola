namespace Informacion
{
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Genero { get; set; }
        public string CantidadPokemonObtendidos { get; set; }
        public string CompañeroPokemon { get; set; }
        public string TipoRopa { get; set; }
        public string Estatura { get; set; }
        public string SimboloPokemonAsignado { get; set; }
        public string TipoPiel { get; set; }


        public string Saludar()
        {
            return $"Mi nombre es {Nombre} {Apellido}, y soy un entrenador pokemon";
        }
        public string Identificador()
        {
            return $"Mi numero de identificacion es {Identificacion}, y me gustiaria ser reconocido a nivel  mundial";

        }
        public string DefinicionGenero()
        {
            return $"Como lo notaras soy {Genero}, porque aparte hay mujeres entrenedoras ";
        }
        public string CantidadPokemones()
        {
            return $"En mi mochila  tengo la cantida de {CantidadPokemonObtendidos}, pokemones ";

        }
        public string Compañero()
        {
            return $"Mi fiel compañero de viajes es un pokemon {CompañeroPokemon} ";
         
        }
        public string TRopa()
        {
            return $"Me gusta utilizar ropa {TipoRopa}, ya que es comodo para mis viajes ";
         
        }
        public string EstaturaEntrenador()
        {
            return $"Yo tengo una estatura {Estatura}, asi que no soy muy alto ";
         
        }
        public string SPasignado()
        {
            return $"Mi principal simbolo pokemon es la {SimboloPokemonAsignado} ";
        }
    }
}
