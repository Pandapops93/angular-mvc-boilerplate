﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Models {

    public sealed class Nakama {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("crew_position")]
        public string CrewPosition { get; set; }

        [JsonProperty("bounty")]
        public int Bounty { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public Nakama() { }

        public Nakama(int id, string name, string url, string position, int bounty) {
            Id = id;
            Name = name;
            ImageUrl = url;
            CrewPosition = position;
            Bounty = bounty;
        }
    }
}
