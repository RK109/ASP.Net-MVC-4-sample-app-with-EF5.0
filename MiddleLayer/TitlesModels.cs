using System;
using System.Collections.Generic;

namespace Titles.BusinessLayer
{
    public class TitlesModel
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public string ReleaseYear { get; set; }
        public DateTime? ProcessedDateTimeUTC { get; set; }
    }

    public class ParticipantsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParticipantType { get; set; }
    }

    public class GenresModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TitleParticipantModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int ParticipantId { get; set; }
        public bool IsKey { get; set; }
        public string RoleType { get; set; }
        public bool IsOnScreen { get; set; }
    }

    public class TitleGenreModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int GenreId { get; set; }
    }

    public class StoryLineModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
    }

    public class AwardsModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        public string Award { get; set; }
        public string AwardCompany { get; set; }
    }

    public class TitleDetailsModel
    {
        public TitlesModel Titles { get; set; }
        public ParticipantsModel Participants { get; set; }
        public GenresModel Genres { get; set; }
        public TitleParticipantModel TitleParticipant { get; set; }
        public TitleGenreModel TitleGenres { get; set; }
        public AwardsModel Awards { get; set; }
        public StoryLineModel StoryLines { get; set; }
    }


}