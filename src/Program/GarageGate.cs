namespace Program;

public class GarageGate
{
    public bool Abierto { get; set; }

    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    
    public GarageGate(int unA, int unB, int unC)
    {
        this.Abierto = false;
        this.A = unA;
        this.B = unB;
        this.C = unC;
    }

    public int EstaAbierto()
    {
        And primerAnd = new And();
        primerAnd.AgregarEntrada("A", this.A);
        primerAnd.AgregarEntrada("B", this.B);
        primerAnd.AgregarEntrada("C", this.C);
        int resultado1 = primerAnd.Calcular(); // Primer and (A,B y C = 1)

        Or primerOr = new Or();
        primerOr.AgregarEntrada("A", A);
        primerOr.AgregarEntrada("B", B);
        int resultado2 = primerOr.Calcular(); // Paso previo a negar A y B

        Not primerNot = new Not();
        primerNot.AgregarEntrada("SegundoAnd", resultado2);
        int resultado3 = primerNot.Calcular();  // A y B negados

        And tercerAnd = new And();
        tercerAnd.AgregarEntrada("primerNot", resultado3);
        tercerAnd.AgregarEntrada("C", C);
        int resultado4 = tercerAnd.Calcular();  // And que incliuye A' B' C

        Or resultadoFinal = new Or();
        resultadoFinal.AgregarEntrada("tercerAnd", resultado4);
        resultadoFinal.AgregarEntrada("primerAnd", resultado1); // Or final
        int resultado5 = resultadoFinal.Calcular();
        return resultado5;

    }
}