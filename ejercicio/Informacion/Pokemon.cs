namespace Informacion
{
    public class Pokemon
    {
        public string NombrePokemon { get; set; }
        public string ColorPokemon { get; set; }
        public string Elementopokemon { get; set; }
        public string NivelPokemon { get; set; }
        public string EvolucionPokemon { get; set; }
        public string PuntosCombate { get; set; }
        public string TipoPokemon { get; set; }
        public string PoderPrincipal { get; set; }


        public string Npokemon()
        {
            return $"Te describire sobre lo pokemones, cada uno tiene un nombre por ejemplo  {NombrePokemon} ";
        }
        public string ColorP()
        {
            return $"y son de varios colores como {ColorPokemon} y algunos mas ";
 
        }
        public string Elementop()
        {
            return $"tienes varos elementos cada pokemon y el elemento pokemon que tiene el es {Elementopokemon}, y son muy utiles al momento de un combate ";
           
        }
        public string Nivelp()
        {
            return $"cada pokemon tiene nivele como este que tiene {NivelPokemon}, pero entrenandolo puedes aumentarlo mas y mas ";
            
        }
        public string Evolucionp()
        {
            return  $"Este pokemon aun no tengo la evolucion real ya que esta en nivel {EvolucionPokemon}, espero que mi entrenamiento logre hacerme evolucionar ";
            
        }
        public string PCombate()
        {
            return $"Los puntos de combate son depende del entrenamiento como pikachu que tiene {PuntosCombate} puntos ";
            
        }
        public string TipoP()
        {
            return  $"aun estoy haciendole controlar  el tipo  {TipoPokemon},de pokemon  que soy  ";
         
        }
        public string PdrPrincipal()
        {
            return  $"todavia tengo puntos de combate entre los {PoderPrincipal}, pero con entrenamiento deseo obtener mas poder ";
      
        }
    }
}
