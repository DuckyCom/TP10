using System.Data.SqlClient; 
using Dapper; 
public class Series
{

public int IdSerie{get;set;}

public string Nombre{get;set;}

public int AñoInicio{get;set;} //si tira error, sacar la ñ}

public string Sinopsis{get;set;}

public string ImagenSerie{get;set;}

}