using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
//server = . para que se conecte al localhost


namespace Tp10.Models
{
    
public class BD{
    private static string _connectionString = @"Server=.; Database=BDSeries; Trusted_Connection=True;"; 


    public static List<Series> CargarSeries(){
        List<Series> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            devolver = db.Query<Series>(sql).ToList();
        }
        return devolver;
    }

    public static List<Actores> VerActores(int idSerie){
        List<Actores> devolver = null;
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @IdSerie";
            devolver = db.Query<Actores>(sql, new{IdSerie = idSerie}).ToList();
        }
        return devolver;
    }


    public static List<Temporadas> VerTemporadas(int IdSerie){
        List<Temporadas> listaTemporadas = new List<Temporadas>();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            listaTemporadas = db.Query<Temporadas>(sql, new { pIdSerie = IdSerie }).ToList();
        }
        return listaTemporadas; 
    }

    public static Series VerInfoSerie(int IdSerie)
        {
            Series sActual = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
                sActual = db.QueryFirstOrDefault<Series>(sql,new {pIdSerie = IdSerie});
            }
            return sActual;
        }
    }
 
 }



