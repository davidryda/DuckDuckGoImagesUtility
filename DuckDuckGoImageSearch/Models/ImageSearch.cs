using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DuckDuckGoImageSearch.Models
{
    public class ImageSearch
    {
        [JsonPropertyName("ads")]
        public object Ads { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("queryEncoded")]
        public string QueryEncoded { get; set; }

        [JsonPropertyName("response_type")]
        public string ResponseType { get; set; }

        [JsonPropertyName("results")]
        public List<ImageResult> ImageResults { get; set; }

        //[JsonPropertyName("vqd")]
        //public Vqd Vqd { get; set; }
    }

    /// <summary>
    /// The Vqd class property name is generated dynamically based on the search query.
    /// The property name is the search query that has been url encoded.
    /// Not necessary, so commenting out.
    /// </summary>
    //public class Vqd
    //{
    //    [JsonPropertyName("dragon%20ball%20z")]
    //    public string Dragon20ball20z { get; set; }
    //}
}
