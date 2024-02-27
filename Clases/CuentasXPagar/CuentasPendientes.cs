using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Clases.CuentasXPagar
{
    public class CuentasPendientes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string? Descripcion { get; set; }
    }
}
