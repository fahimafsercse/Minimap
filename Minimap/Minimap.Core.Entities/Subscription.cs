using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class Subscription
    {
        [Required, Key]
        public int NotUse { get; set; }
        [Required]
        public int UserId { get; set; }
       // [ForeignKey("Channel")]
        [Required]
        public int ChannelId { get; set; }

    }
}