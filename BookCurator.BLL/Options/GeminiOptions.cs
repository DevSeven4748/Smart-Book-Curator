using System;
using System.Collections.Generic;
using System.Text;

namespace BookCurator.BLL.Options
{
    public class GeminiOptions
    {
        public string ApiKey { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = string.Empty;
    }
}
