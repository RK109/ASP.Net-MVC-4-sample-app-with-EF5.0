using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Titles.DataAccessLayer
{
    public class MapEntityDataModels
    {
        public IList<EntityModels.Title> GetTitlesByName(string titleName)
        {
            using (var db = new EntityModels.TitlesEntities())
            {
                return db.Titles.Where(e => e.TitleName == titleName).ToList<EntityModels.Title>();
            }
        }
    }
}