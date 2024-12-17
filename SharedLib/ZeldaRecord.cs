﻿using System.Text.Json.Serialization;

namespace Shared;

public class ZeldaRecord {
    [JsonPropertyName("name")]
    public string Name {get; set;}
    [JsonPropertyName("description")]
    public string Description {get; set;}
    public float[] Embedding {get; set;}
}