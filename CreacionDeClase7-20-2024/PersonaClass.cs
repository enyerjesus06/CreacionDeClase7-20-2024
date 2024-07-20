

namespace CreacionDeClase7_20_2024
{
    public class PersonaClass
    {
        #region Atributos
        private string Nombre;
        private int Edad;
        private string Ciudad;
        #endregion

        #region  Constructor
        public PersonaClass(string Nombre, int Edad, string Ciudad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Ciudad = Ciudad;
        }
        #endregion

        #region Metodos
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad + " años");
            Console.WriteLine("Ciudad: " + Ciudad);
        }

        public virtual int CalcularEdad()
        {
            return Edad;
        }
        #endregion
    }
}
