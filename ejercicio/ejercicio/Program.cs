using Informacion;
using System;

namespace Compilacion
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("..................................................");
            Console.WriteLine(" HOLA BIENVENIDO A MI HISTORIA");
            Console.WriteLine("Ingresa tu Nombre y preciona enter");
            string NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingresa tu Apellido y preciona enter");
            string ApellidoUsuario = Console.ReadLine();
            
            Persona identificar = new Persona();
            identificar.Nombre1 = NombreUsuario;
            identificar.Apellido1  = ApellidoUsuario;

            Console.WriteLine($"Hola {identificar.Nombre1} {identificar.Apellido1}");
            Console.WriteLine("..................................................");
            Console.WriteLine(" TE CONTARE UN POCO DE MI VIAJE POKEMON ");
            Console.WriteLine("");

            var Persona = new Entrenador
            {
                Nombre = "Hash",
                Apellido = "Ketchum",
                Identificacion = "1750879544",
                Genero = "Masculino",
                CantidadPokemonObtendidos = "230",
                CompañeroPokemon = "Charizard",
                TipoRopa = "deportiva",
                Estatura = "media-baja",
                SimboloPokemonAsignado = "Expo liga Pokemon",
                TipoPiel = "clara"
            };
            Console.WriteLine(Persona.Saludar());
            Console.WriteLine(Persona.Identificador());
            Console.WriteLine(Persona.DefinicionGenero());
            Console.WriteLine(Persona.CantidadPokemones());
            Console.WriteLine(Persona.Compañero());
            Console.WriteLine(Persona.TRopa());
            Console.WriteLine(Persona.EstaturaEntrenador());
            Console.WriteLine(Persona.SPasignado());

            var Especie = new Pokemon
            {
                NombrePokemon = "pikachu",
                ColorPokemon = "amarillo",
                Elementopokemon = "Rayo",
                NivelPokemon = "alto",
                EvolucionPokemon = "primer nivel",
                PuntosCombate = "2500",
                TipoPokemon = "salvaje",
                PoderPrincipal = "impactruno"

            };
            Console.WriteLine(Especie.Npokemon());
            Console.WriteLine(Especie.ColorP());
            Console.WriteLine(Especie.Elementop());
            Console.WriteLine(Especie.Nivelp());
            Console.WriteLine(Especie.Evolucionp());
            Console.WriteLine(Especie.PCombate());
            Console.WriteLine(Especie.TipoP());
            Console.WriteLine(Especie.PdrPrincipal());


            var Estructura = new Gimnasio
            {
                NombreGimnasio = "Novarte",
                DiametroGimnasio = "16000 metros cuadrados",
                EntranCantidadPersonas = "1200000 personas",
                NivelGimnasio = "nivel 6 en combate",
                RecompensasGimnasio = "medalla De honor pokemon"
            };
            Console.WriteLine(Estructura.NGimnasio());
            Console.WriteLine(Estructura.DGimnasio());
            Console.WriteLine(Estructura.EntranPersonas());
            Console.WriteLine(Estructura.NivelGim());
            Console.WriteLine(Estructura.RecompensaGim());

            var aldea = new Aldea
            {

                NombreAldea = "Paleta",
                NumeroHabitantes = "1234500",
                PokemonesExistentes = "tipo agua",
                LiderAldea = "Kir Donka",
                NombreHospital = "Hospital paleta",
                NombreEstadio = "Estadio Donka",
                PokemonesHabitando = "2500",

            };
            Console.WriteLine(aldea.NomobreAld());
            Console.WriteLine(aldea.Habitantex());
            Console.WriteLine(aldea.NumeroHab());
            Console.WriteLine(aldea.NombreHosp());
            Console.WriteLine(aldea.NombreEst());
            Console.WriteLine(aldea.HabitantesPok());

            var maleantes = new Enemigo
            {
                NombreEnemigo = "Jessy Y James",
                NombreEquipoEnemigo = " Roket",
                Vestimenta = " traje blanco y rojo",
                Generos = "hombre y mujer",
                Mascota = "gato llamado miau",
                PokemonesObtenidos = "400",
                Estatura = "1.80",
                BatallasGanadas = "6",
            };
            Console.WriteLine(maleantes.NombreEn());
            Console.WriteLine(maleantes.EquipoLamado());
            Console.WriteLine(maleantes.Genero());
            Console.WriteLine(maleantes.Vestim());
            Console.WriteLine(maleantes.Masco());

            Console.WriteLine(".................................................. ");
            Console.WriteLine(" Y asi culmina un poco de mi relato, espero que lo hayas disfrutado, nos veremos en una proxima ocacion Adios.... ");
        }
    }
}
