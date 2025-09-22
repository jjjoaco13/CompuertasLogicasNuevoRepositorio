namespace Program;

public class GarageGate
{
    public bool Abierto { get; set; }

    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    
    public GarageGate()
    {
        this.Abierto = false;
    }

    public int EstaAbierto(int unA, int unB, int unC)
    {
        And primerAnd = new And();
        primerAnd.AgregarEntrada("A", unA);
        primerAnd.AgregarEntrada("B", unB);
        primerAnd.AgregarEntrada("C", unC);
        int resultado1 = primerAnd.Calcular(); // Primer and (A,B y C = 1)

        And segundoAnd = new And();
        segundoAnd.AgregarEntrada("A", unA);
        segundoAnd.AgregarEntrada("B", unB);
        int resultado2 = segundoAnd.Calcular(); // Paso previo a negar A y B

        Not primerNot = new Not();
        primerNot.AgregarEntrada("SegundoAnd", resultado2);
        int resultado3 = primerNot.Calcular();  // A y B negados

        And tercerAnd = new And();
        tercerAnd.AgregarEntrada("primerNot", resultado3);
        tercerAnd.AgregarEntrada("C", unC);
        int resultado4 = tercerAnd.Calcular();  // And que incliuye A' B' C

        Or resultadoFinal = new Or();
        resultadoFinal.AgregarEntrada("tercerAnd", resultado4);
        resultadoFinal.AgregarEntrada("primerAnd", resultado1); // Or final
        int resultado5 = resultadoFinal.Calcular();
        return resultado5;

    }
}