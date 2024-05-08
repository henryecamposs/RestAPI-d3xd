namespace wResAPI_d3xd
{


    partial class DSRetail
    {
        public static void cambiarNombreTabla(string nombreTablaOriginal, string nombreTablaFinal, System.Data.OleDb.OleDbCommand[] cmmCollection)
        {
            int i = 0;
            foreach (System.Data.OleDb.OleDbCommand oledbcmm in cmmCollection)
            {
                oledbcmm.CommandText = cmmCollection[i].CommandText.Replace(nombreTablaOriginal, nombreTablaFinal);
                i++;
            }
        }
    }

}
namespace wResAPI_d3xd.DSRetailTableAdapters
{
    partial class a_089TableAdapter
    {
        public void cambiarTabla(string nombreTablaOriginal, string nombreTablaFinal)
        {
            DSRetail.cambiarNombreTabla(nombreTablaOriginal, nombreTablaFinal, CommandCollection);
        }
    }
    partial class cf_088TableAdapter
    {
        public void cambiarTabla(string nombreTablaOriginal, string nombreTablaFinal)
        {
            DSRetail.cambiarNombreTabla(nombreTablaOriginal, nombreTablaFinal, CommandCollection);
        }
    }

}
