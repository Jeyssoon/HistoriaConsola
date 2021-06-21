namespace Informacion
{
    public class Aldea
    {
        public string NombreAldea { get; set; }
        public string NumeroHabitantes { get; set; }
        public string PokemonesExistentes { get; set; }
        public string LiderAldea { get; set; }
        public string NombreHospital { get; set; }
        public string NombreEstadio { get; set; }
        public string PokemonesHabitando { get; set; }

        public string NomobreAld()
        {
            return $"En esta aldea llamada {NombreAldea} tiene mucho interes todos  ";
        }
        public string Habitantex()
        {
            return $"Existe alrededor de  {this.NumeroHabitantes},y todos y cada uno se registra";

        }
        public string NumeroHab()
        {
            return $"Su numero de habitantes es de {this.NumeroHabitantes}, y es muy extenso";

        }
        public string NombreHosp()
        {
            return $"Toda aldea tienen sus emergencias y aqui en el hospital {this.NombreHospital} sera bien atendido tu pokemon ";

        }
        public string NombreEst()
        {
            return $"su estadio de batalla es {this.NombreEstadio}, donde se disputan muchos contrincantes";

        }
        public string HabitantesPok()
        {
            return $"Existe un numero limitado de pokemones alrededor de {this.PokemonesHabitando},todos son felices en ese lugar ";

        }



    }
}
