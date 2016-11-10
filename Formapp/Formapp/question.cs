﻿using Newtonsoft.Json;
using SQLite;

namespace Formapp
{
    public class question
    {
        [PrimaryKey, AutoIncrement]
        public int NR { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "Question")]
        public string Question { get; set; }
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "Info")]
        public string Info { get; set; }
        [JsonProperty(PropertyName = "Answer1")]
        public string Answer1 { get; set; }
        [JsonProperty(PropertyName = "Next1")]
        public int Next1 { get; set; }
        [JsonProperty(PropertyName = "Answer2")]
        public string Answer2 { get; set; }
        [JsonProperty(PropertyName = "Next2")]
        public int Next2 { get; set; }
        [JsonProperty(PropertyName = "Answer3")]
        public string Answer3 { get; set; }
        [JsonProperty(PropertyName = "Next3")]
        public int Next3 { get; set; }
    }
}
