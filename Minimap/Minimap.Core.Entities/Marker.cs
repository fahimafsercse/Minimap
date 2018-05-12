using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Marker
    {
        [Required]
        public string MarkerName { get; set; }
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Longi { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarkerId { get; set; }

        public DateTime CreationDate { get; set; }
        public string MarkerDescription { get; set; }
        [Required]
        public int UserId { get; set; }
        public Notification MarkerNotification { get; set; }
    }
}