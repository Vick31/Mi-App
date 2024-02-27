using MiApp.Clases.CuentasXPagar;
using SQLite;

namespace MiApp.Clases
{
    public class HelperSQLite(string dbPath)
    {
        private SQLiteConnection connection;

        private void Init()
        {
            if (connection is not null)
                return;
            connection = new(dbPath);

            connection.CreateTable<CuentasPendientes>();
        }

        public void AgregarCuentaPendiente(string dato)
        {
            int result = 0;
            try
            {
                Init();

                CuentasPendientes cuenta = new() { Descripcion = dato };
                result = connection.Insert(cuenta);
            }
            catch (Exception)
            {

            }
        }

        public List<CuentasPendientes> GetCuentasPendientes()
        {
            try
            {
                Init();
                return connection.Table<CuentasPendientes>().ToList();
            }
            catch (Exception)
            {

            }

            return new List<CuentasPendientes>();
        }
    }
}
