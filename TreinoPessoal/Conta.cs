using System;

public class Conta
{
	//FIELDS
	private int agencia, numero;
	private string nomeCliente;
	private double saldo;

	//Constructors
	public Conta()
	{
		agencia = 0000;
		numero = 0;
		nomeCliente = "Sem nome";
		saldo = 000.000;
	}

	public Conta(int agencia, int numero, string nomeCliente, double saldo)
	{
		this.agencia = agencia;
		this.numero = numero;
		this.nomeCliente = nomeCliente;
		this.saldo = saldo;
	}

	//GETTERS E SETTERS
	public int getAgencia()
	{
		return agencia;
	}

	public void setAgencia(int agencia)
	{
		this.agencia = agencia;
	}

    public int getNumero()
    {
        return numero;
    }

    public void setNumero(int numero)
    {
        this.numero = numero;
    }

    public double getSaldo()
    {
        return saldo;
    }

    public void setSaldo(double saldo)
    {
        this.saldo = saldo;
    }

	public string getNome()
	{
		return nomeCliente;
	}

	public void setNome(string nomeCliente)
	{
		this.nomeCliente = nomeCliente;
	}

	//MÉTODOS
    public void exibe()
	{
		Console.WriteLine($"Nome = {nomeCliente}\nSaldo = {saldo}\nNumero = {numero}\nAgencia = {agencia}");
	}
}
