// File:    Crud.cs
// Author:  nmege
// Created: vendredi 20 décembre 2013 09:15:09
// Purpose: Definition of Interface Crud

using System.Collections.ObjectModel;

namespace MATINFO
{
    public interface Crud<T>
   {
      void Create();
      
      void Read();
      
      void Update();
      
      void Delete();
      
      ObservableCollection<T> FindAll();
      
      ObservableCollection<T> FindBySelection(string criteres);
   
   }
}