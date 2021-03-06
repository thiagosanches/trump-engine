﻿using System.IO;

namespace TrumpEngine.Shared
{
    public class SpotifySecrets
    {
        public string BaseUrl { get; set; }
        public string TokenUrl { get; set; }
        public string PathRecommendationsByGenre { get; set; }
        public string PathArtistInformation { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string GetUrlByGenre()
        {
            return Path.Combine(BaseUrl, PathRecommendationsByGenre);
        }

        public string GetUrlArtistInformation()
        {
            return Path.Combine(BaseUrl, PathArtistInformation);
        }
    }
}
