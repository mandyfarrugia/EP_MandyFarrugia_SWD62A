using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Poll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Option1Text { get; set; }

        [Required]
        public string Option2Text { get; set; }

        [Required]
        public string Option3Text { get; set; }

        [Required]
        public int Option1VotesCount { get; set; }

        [Required]
        public int Option2VotesCount { get; set; }

        [Required]
        public int Option3VotesCount { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}