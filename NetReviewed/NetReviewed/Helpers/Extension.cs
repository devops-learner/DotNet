using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetReviewed.Helpers
{
    static public class Extensions
    {
        public static string ToTraceString<T>(this IQueryable<T> executiongQuery){

            var query = executiongQuery as System.Data.Objects.ObjectQuery<T>;
            var generatedQuery = string.Empty;
            if (query !=null)
            {
                generatedQuery = string.Format("{0}{1}{2}{1}", DateTime.Now, Environment.NewLine, query.ToTraceString());
            }
            return generatedQuery;
        }
    }
}