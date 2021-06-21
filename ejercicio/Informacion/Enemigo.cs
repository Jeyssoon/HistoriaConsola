namespace Informacion
{
    public class Enemigo
    {
        public string NombreEnemigo { get; set; }
        public string NombreEquipoEnemigo { get; set; }
        public string Vestimenta { get; set; }
        public string Generos { get; set; }
        public string Mascota { get; set; }
        public string PokemonesObtenidos { get; set; }
        public string Estatura { get; set; }
        public string BatallasGanadas { get; set; }

        public string NombreEn()
        {
            return $"Existen dos personas que estan en contra del bien llamados {NombreEnemigo} ";
        }
        public string EquipoLamado()
        {
            return $"Al parecer su nombre es el {NombreEquipoEnemigo}, y estan dispuestos a robar pokemones";

        }
        public string Genero()
        {
            return $"en el equipo existen  un {Generos}, que desean por las malas tener pokemones";

        }
        public string Vestim()
        {
            return $"Su vestimenta es muy colorido de color {Vestimenta}, con eso les gusta llamar la atencion";

        }
        public string Masco()
        {
            return $"Tiene una mascota llamada {Mascota}, que no es muy listo al parece";

        }

    }
}
