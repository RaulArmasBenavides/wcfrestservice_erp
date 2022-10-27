using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ServicioWCFRest.common.Helper
{

    public class StringHelper
    {
        public static bool VerificarTodosDigitos(string stringtocheck)
        {
            bool isIntString = stringtocheck.All(char.IsDigit);
            return isIntString;
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        ///     Executes the query, and returns the result set as DataSet.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DataSet that is equivalent to the result set.</returns>
        public static DataSet ExecuteDataSet(this SqlCommand @this)
        {
            var ds = new DataSet();
            using (var dataAdapter = new SqlDataAdapter(@this))
            {
                dataAdapter.Fill(ds);
            }

            return ds;
        }
        /// <summary>
        /// Helper methods for the lists.
        /// </summary>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
