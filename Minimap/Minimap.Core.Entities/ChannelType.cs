using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Minimap.Core.Entities
{
    public class ChannelType
    {
        [Required, Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChanneTypelId { get; set; }
        public string ChanneTypeName { get; set; }
    }
}