using LayerModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerModel
{
    public class Create
    {
        public static void Add(B b)
        {
            try
            {
                using (var db = new JutroContext())
                {
                    db.Bs.Add(b);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
