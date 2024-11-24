using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_com_C_
{
    static class conexaobanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "cadclientes";
        private const string usuario = "root";
        private const string senha = "";

        static public string servidorbanco = $"server={servidor}; user id ={usuario}; database={bancoDados}; passowrd={senha}";
    }
}
