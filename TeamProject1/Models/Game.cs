namespace TeamProject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Game")]
    public partial class Game
    {
        public int GAMEID { get; set; }

        [Required]
        [StringLength(2)]
        public string WEEK_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string TEAM_1_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TEAM_2_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TEAM_1_Score { get; set; }

        [Required]
        [StringLength(10)]
        public string TEAM_2_Score { get; set; }
    }
}
