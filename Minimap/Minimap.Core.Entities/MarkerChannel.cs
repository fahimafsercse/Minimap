using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class MarkerChannel
    {
        [Key]
        public int notUse { get; set; }
        [Required]
        public int ChannelId { get; set; }
        [Required]
        public int MarkerId { get; set; }
        [Required]
        public string MarkerName { get; set; }
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Longi { get; set; }
        [Required]
        public int UserId { get; set; }
      
    }
}