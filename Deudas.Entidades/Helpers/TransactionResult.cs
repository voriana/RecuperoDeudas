using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Deudas.Entidades.Helpers
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public string Error { get; set; }

    }
}
