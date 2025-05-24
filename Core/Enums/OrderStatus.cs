﻿using System.Text.Json.Serialization;

namespace Core.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderStatus
    {
        Pending,
        Cancelled,
        Completed
    }
}
