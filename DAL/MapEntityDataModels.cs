using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.DAL.EntityModels;
using System.Data.Entity;

namespace Titles.DAL
{
    public class MapEntityDataModels : IDataAccessService
    {
        #region IDataAccessService Members

        public IList<Title> GetTitlesByName(string titleName)
        {
            using (var db = new TitlesEntities())
            {
                return db.Titles.Where(e => e.TitleName == titleName).ToList<EntityModels.Title>();
            }
        }

        public IList<TitleDetail> GetTitleDetails(int titleId)
        {
            using (var db = new TitlesEntities())
            {
                return db.TitleDetails.Where(e => e.TitleId == titleId).ToList<EntityModels.TitleDetail>();
            }
        }

        //public IList<TitleDetail> GetTitleDetails(int titleId)
        //{
        //    using (var db = new TitlesEntities())
        //    {
        //       var titleDetails = (from t in db.Titles
        //         join tg in db.TitleGenres on t.TitleId equals tg.TitleId
        //         join g in db.Genres on tg.GenreId equals g.Id
        //         join a in db.Awards on t.TitleId equals a.TitleId
        //         where t.TitleId == titleId
        //         select new TitleDetailModel{
        //             TitleId = t.TitleId,
        //             TitleName = t.TitleName,
        //             Genre = g.Name,
        //             AwardYear = a.AwardYear,
        //             AwardCompany = a.AwardCompany
        //         });

        //       return titleDetails.ToList();
        //    }
        //}

        #endregion
    }

    //public class TitleDetailModel 
    //{
    //    public int TitleId { get; set; }
    //    public string  TitleName { get; set; }
    //    public string Genre { get; set; }
    //    public int? AwardYear { get; set; }
    //    public string AwardCompany { get; set; }
    //}
}