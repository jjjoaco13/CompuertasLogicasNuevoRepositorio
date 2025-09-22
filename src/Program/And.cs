namespace Program;

public class And: ICompuerta
{
    public string Nombre{ get; set; }
    public Dictionary<string, int> Entradas { get; set; }

    public void AgregarEntrada(string unNombre, int Valor)
    {
        Entradas.Add(unNombre, Valor);
    }

    public int Calcular()
    {
        foreach (int valor in Entradas.Values)
        {
            if (valor == 0)
            {
                return 0;
            }
        }

        return 1;
    }
}