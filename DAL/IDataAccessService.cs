using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Titles.DAL.EntityModels;

namespace Titles.DAL
{
    public interface IDataAccessService
    {
        IList<Title> GetTitlesByName(string titleName);
        IList<TitleDetail> GetTitleDetails(int titleId);
    }
}
