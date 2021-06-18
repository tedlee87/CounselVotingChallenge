using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CounselVoting.Domain.Model
{
    public class SampleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SampleId { get; set; }

        [Required]
        public string Text { get; set; }
    }
}