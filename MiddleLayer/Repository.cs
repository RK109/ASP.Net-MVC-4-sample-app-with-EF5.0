using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Titles.DAL;
using Titles.DAL.EntityModels;
using System.Data.Entity;

namespace Titles.BusinessLayer
{
    public class Repository : IRepository
    {
        IDataAccessService dataAccessService;

        public Repository()
        {
            dataAccessService = new MapEntityDataModels();
        }

        #region IRepository Members

        public IList<Title> GetTitlesByName(string titleName)
        {
            var result = dataAccessService.GetTitlesByName(titleName);
            return result;
        }

        public IList<TitleDetail> GetTitleDetails(int titleId)
        {
            var result = dataAccessService.GetTitleDetails(titleId);
            return result;
        }

        public IList<Title> GetTitlesByGenre(string Genre)
        {
            throw new NotImplementedException();
        }

        public IList<Title> GetTitlesByParticipant(string Participant)
        {
            throw new NotImplementedException();
        }

        public IList<Title> GetAllTitles(string titleGenre)
        {
            throw new NotImplementedException();
        }

        

        #endregion
    }
}
