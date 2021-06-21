namespace Informacion
{
    public class Gimnasio
    {
        public string NombreGimnasio { get; set; }
        public string DiametroGimnasio { get; set; }
        public string EntranCantidadPersonas { get; set; }
        public string NivelGimnasio { get; set; }
        public string RecompensasGimnasio { get; set; }


        public string NGimnasio()
        {
            return $"He visitado varios ginmasio como el {NombreGimnasio} ";
      
        }
        public string DGimnasio()
        {
            return $"Y su diametros es de {DiametroGimnasio}, asi que si caben demasiada gente ";
          
        }
        public string EntranPersonas()
        {
            return $"Talves la cantidad sea de  {EntranCantidadPersonas}, asi que si es demasiado espacioso ";
  
        }
        public string NivelGim()
        {
            return $"Lo negativo de este ginmasio es que su nivel es de {NivelGimnasio} , asi que debo ser mas proactivo ";
     
        }
        public string RecompensaGim()
        {
            return $"Cada que ingresar a este ginmasio y ganas un  combate te entregan la {RecompensasGimnasio}, y es muy especial ";
         
        }


    }
}
