namespace Program

{
    public class Not : ICompuerta
    {
        public string Nombre { get; set; } = "NOT"; // nombre fijo
        public Dictionary<string, int> Entradas { get; set; }

        public Not()
        {
            Entradas = new Dictionary<string, int>();
        }

        public void AgregarEntrada(string unNombre, int valor)
        {
            // guardamos la entrada por nombre
            Entradas[unNombre] = valor;
        }

        public int Calcular()
        {
            // NOT solo necesita la primera entrada
            if (Entradas.Count == 0)
            {
                Console.WriteLine("La compuerta NOT necesita una entrada");
            }

            // tomamos el primer valor del diccionario
            int valor = Entradas.Values.First();

            // NOT: si es 0 devuelve 1, si es 1 devuelve 0
            if (valor == 0)
            {
                return valor = 1;
            }
            else
            {
                return valor = 0;
            }
            
        }
    }
}
//