using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Soluceapp_Csharp
{

    public class Person
    { 
    public int id_registration { get; set; }
    public string Dutil { get; set; }
    public string Dmp { get; set; }
    public string Points { get; set; }
    public string Type { get; set; }
    public string Cat { get; set; }
    public string Classe { get; set; }
    public string Sol1 { get; set; }
    public string Sol2 { get; set; }
    public string Dcle { get; set; }
    }

    public class DataAccess
    {/*
        public List<Person> GetPeople(string Dutil)
        { 
        using (IDbConnection connection = new IDbConnection(Dutil))
        }
        */
    }
}