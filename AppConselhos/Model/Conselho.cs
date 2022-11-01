using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppConselhos.Model
{
    public class Conselho
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Conselho()
        {
            
            this.Descricao = "";
        }
    }

    
}
