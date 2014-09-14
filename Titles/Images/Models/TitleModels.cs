using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;

namespace Titles.Models
{
    public class TitlesModel
    {
        [Required]
        [Display(Name = "Title ID")]
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public string ReleaseYear { get; set; }
        public DateTime? ProcessedDateTimeUTC { get; set; }
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

    public class ParticipantModel
    {
        [Required]
        [Display(Name = "Participant ID")]
        public int Id { get; set; }
        [Display(Name = "Participant Name")]
        public string Name { get; set; }
        public string ParticipantType { get; set; }
    }

    public class GenreModel
    {
        [Required]
        [Display(Name = "Genre ID")]
        public int Id { get; set; }
        [Display(Name = "Genre Name")]
        public string Name { get; set; }
    }

    public class AwardModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        public string Award { get; set; }
        public string AwardCompany { get; set; }
    }

    public class StoryLineModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
    }
}