// File:    DataAccess.cs
// Author:  nmege
// Created: samedi 26 novembre 2022 11:00:28
// Purpose: Definition of Class DataAccess

using System;
using System.Data;
using System.Windows;
using Npgsql;

//ATTENTION à bien donner les droits à votre utilisateur :
//GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA public TO matinfo;
//GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA public TO matinfo;

namespace MATINFO /// A MODIFIER SI VOTRE PROJET A UN AUTRE NOM
{

    public class DataAccess
   {
      public NpgsqlConnection? NpgSQLConnect
      {
         get
         ;
         set
         ;
      }
      
      /// <summary>
      /// Connexion à la base de données
      /// </summary>
      /// <returns> Retourne un booléen indiquant si la connexion est ouverte ou fermée</returns>
      public bool OpenConnection()
      {
          try
          {
              NpgSQLConnect = new NpgsqlConnection
              {
                  ConnectionString = "Server=51.83.36.122;port=5432;Database=rouemi;Search Path=saematinfo;uid=rouemi;password=dBHSdQ;" // A MODIFIER POUR VOTR BD
              };
              NpgSQLConnect.Open();
                
                return NpgSQLConnect.State.Equals(System.Data.ConnectionState.Open);
          }
          catch (Exception e)
          {
                MessageBox.Show(e.ToString());
                return false;
          }
      }
      
      /// <summary>
      /// Déconnexion de la base de données
      /// </summary>
      private void CloseConnection()
      {
          if (NpgSQLConnect!=null)
              if (NpgSQLConnect.State.Equals(System.Data.ConnectionState.Open))
              {
                  NpgSQLConnect.Close();
              }
      }
      
      /// <summary>
      /// Accès à des données en lecture
      /// </summary>
      /// <returns>Retourne un DataTable contenant les lignes renvoyées par le SELECT</returns>
      /// <param name="getQuery">Requête SELECT de sélection de données</param>
      public DataTable GetData(string getQuery)
      {
          try
          {
                
                if (OpenConnection())
                {
                    

                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(getQuery, NpgSQLConnect);
                    /*NpgsqlDataAdapter npgsqlAdapter = new NpgsqlDataAdapter
                    {
                        SelectCommand = npgsqlCommand
                    };*/
                    NpgsqlDataAdapter npgsqlAdapter = new NpgsqlDataAdapter(npgsqlCommand);
                    DataTable dataTable = new DataTable();
                    npgsqlAdapter.Fill(dataTable);
                    CloseConnection();
                    

                    return dataTable;

                }
                else
                {
                   
                    return null;
                }
          }
          catch (Exception e)
          {
              MessageBox.Show(e.ToString());
              CloseConnection();
              return null;
          }
      }
      
      /// <summary>
      /// Permet d'insérer, supprimer ou modifier des données
      /// </summary>
      /// <returns>Retourne un entier contenant le nombre de lignes ajoutées/supprimées/modifiées</returns>
      /// <param name="setQuery">Requête SQL permettant d'insérer (INSERT), supprimer (DELETE) ou modifier des données (UPDATE)</param>
      public int SetData(string setQuery)
      {
          try
          {
              if (OpenConnection())
              {
                  NpgsqlCommand sqlCommand = new NpgsqlCommand(setQuery, NpgSQLConnect);
                  int modifiedLines = sqlCommand.ExecuteNonQuery();
                  CloseConnection();
                  return modifiedLines;
              }
              else
                  return 0;
          }
          catch 
          {
                
                CloseConnection();
                return 0;
          }
      }
   
   }
}