using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WowForum.Models
{
    public class CharacterInformationModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string realm { get; set; }

    }
}