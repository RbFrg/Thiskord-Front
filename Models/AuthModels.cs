using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Thiskord_Front.Models
{
    public class AuthModels
    {
        [JsonPropertyName("user")]
        public Dictionary<string, string> UserData { get; set; } = new();

        [JsonPropertyName("server")]
        public Dictionary<string, int> ServerData { get; set; } = new();
    }
}
