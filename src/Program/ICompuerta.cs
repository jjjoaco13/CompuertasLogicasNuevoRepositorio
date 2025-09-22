namespace Program;

public interface ICompuerta
{
    public string Nombre { get; set; }
    public Dictionary<string, int> Entradas { get; set; }
    
    //METODOS
    public void AgregarEntrada(string nombre, int valor);

    public int Calcular();

}