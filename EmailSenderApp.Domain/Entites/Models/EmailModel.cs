using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmailSenderApp.Domain.Entites.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string Subject { get; set; }

        [JsonIgnore]
        public string? Body { get; set; }
    }
}
