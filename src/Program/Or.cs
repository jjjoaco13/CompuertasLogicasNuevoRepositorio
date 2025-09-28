namespace Program;

public class Or: ICompuerta
{
    public string Nombre { get; set; }
    public Dictionary<string, int> Entradas { get; set; }
    
    public Or()
    {
        Entradas = new Dictionary<string, int>();
    }

    public void AgregarEntrada(string unNombre, int Valor)
    {
        Entradas[unNombre] = Valor;
    }

    public int Calcular()
    {
        foreach (int valor in Entradas.Values)
        {
            if (valor == 1)
            {
                return 1;
            }
        }

        return 0;
    }
}
