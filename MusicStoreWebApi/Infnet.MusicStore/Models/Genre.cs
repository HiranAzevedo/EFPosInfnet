﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infnet.MusicStore.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Genre
    {
        [JsonProperty("GenreId")]
        [Key]
        public int GenreId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Descritpion")]
        public string Description { get; set; }

        public virtual ICollection<Album> Albuns { get; set; }
    }
}