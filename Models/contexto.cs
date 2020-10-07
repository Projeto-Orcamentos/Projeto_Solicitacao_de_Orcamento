using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Solicitacao_de_orcamento.Models
{
    public class contexto: DbContext
    {
        DbSet<cliente> cliente { get; set; }
    }
}