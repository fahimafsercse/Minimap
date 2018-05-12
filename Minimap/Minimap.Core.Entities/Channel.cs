using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Channel
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string ChannelName { get; set; }
        [Required,Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChannelId { get; set; }
        public string ChannelDescription { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public int TotaMarker { get; set; }
        public int TotalSubscriber { get; set; }
        public int TotalView { get; set; }
        public int Rating { get; set; }
    }
}