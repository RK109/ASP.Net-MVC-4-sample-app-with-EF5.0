using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Titles.DAL;
using Titles.DAL.EntityModels;

namespace Titles.BusinessLayer
{
    public interface IRepository
    {
        IList<Title> GetTitlesByName(string titleName);
        IList<Title> GetTitlesByGenre(string Genre);
        // IList<EntityModels.Title> GetTitlesByLanguage(string Language)();
        IList<Title> GetTitlesByParticipant(string Participant);
        IList<Title> GetAllTitles(string titleGenre);
        IList<TitleDetail> GetTitleDetails(int titleId);
    }
}
