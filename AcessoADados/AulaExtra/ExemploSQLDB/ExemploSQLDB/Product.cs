using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSQLDB
{
    public record Product
    (
        string id,
        string category,
        string name,
        int quantity,
        bool sale
    );
}
