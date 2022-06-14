using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atv_4.Models
{
    public class Servico
    {
        public int IdServico {get;set;}
        public string NomeServico {get;set;}
        public double PrecoServico {get;set;}
    }
}