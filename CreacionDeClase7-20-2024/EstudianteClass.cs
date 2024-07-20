

namespace CreacionDeClase7_20_2024
{
    public class EstudianteClass : PersonaClass
    {
        

        #region Atributos
        
        public string? Carrera { get; set; }
        public string? Matricula { get; set; }
        public string? Intitucion { get; set; }


        #endregion
        #region Constructor
        public EstudianteClass(string Nombre, int Edad, string Ciudad, string Carrera, string Matricula, string? Intitucion) : base(Nombre, Edad, Ciudad)
        {
            this.Carrera = Carrera;
            this.Matricula = Matricula;

            this.Intitucion = Intitucion;

        }
        #endregion
        #region Metodos 
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera} ");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Institución: {Intitucion}");
        }

        public override int CalcularEdad()
        {
            return base.CalcularEdad();
        }

        #endregion




    }
}
