using System;
using LiteDB;
using Microsoft.Extensions.Options;

namespace Amazon.Web.Models
{
    public class LiteBDcontex
    {
        public readonly LiteDatabase Context;
        public LiteBDcontex (IOptions<LiteBDconfig> configs)
        {
            try
            {
                var db = new LiteDatabase(configs.Value.DatabasePath);
                if (db != null)
                    Context = db;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encuentra o no se puede crear LiteDB.", ex);
            }
        }
    }
}
