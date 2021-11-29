using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deudas.Entidades.Modelo
{
    public class TransactionResult
    {
        private int _id;
        private bool _isOk;
        private string _error;

        public TransactionResult()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public bool IsOk { get => _isOk; set => _isOk = value; }
        public string Error { get => _error; set => _error = value; }
    }
}
