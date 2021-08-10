using BaseExporter.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseExporter.Controller
{
  public class PrincipalControlller
    {

        public void BuscarTabelas(DataGridView grid_tabela)
        {

            DataTable DtResultado = new DataTable("Tabelas");
            string cmd = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";
            SqlCommand comando = new SqlCommand(cmd, data_conecction.GetSqlConnection());
            SqlDataAdapter dt = new SqlDataAdapter(comando);
            dt.Fill(DtResultado);
            grid_tabela.DataSource = DtResultado;

        }
        public void BuscarColunas(DataGridView grid_coluna, string tabela)
        {

            DataTable DtResultado = new DataTable("Colunas");
            string cmd = "	SELECT COLUMN_NAME,	COLUMNS.DATA_TYPE,COLUMNS.CHARACTER_MAXIMUM_LENGTH " +
                "FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tabela";
            SqlCommand comando = new SqlCommand(cmd, data_conecction.GetSqlConnection());
            comando.Parameters.Add("@tabela", SqlDbType.VarChar).Value = tabela;
            SqlDataAdapter dt = new SqlDataAdapter(comando);
            dt.Fill(DtResultado);
            grid_coluna.DataSource = DtResultado;

        }    
    }
}
