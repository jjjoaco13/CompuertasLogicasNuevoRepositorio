namespace Program
{
    public class Program
    {
        public static void MainProgram(string[] args)
        {
            // Creo un garage con A=1, B=0, C=1
            GarageGate garage = new GarageGate(1, 0, 1);

            // Calculo si está abierto
            int resultado = garage.EstaAbierto();

            // Muestro en consola
            Console.WriteLine("¿Garage abierto?: " + resultado);
        }
    }
}