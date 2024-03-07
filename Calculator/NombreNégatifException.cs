namespace Calculator;
public class NombreNégatifException : Exception
{
	public int Position { get; }
	public int NombreFautif { get; }

	public NombreNégatifException(int nombreFautif, int position)
	{
		NombreFautif = nombreFautif;
		Position = position;
	}
}

