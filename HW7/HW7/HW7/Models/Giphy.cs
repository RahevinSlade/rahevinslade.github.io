using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW7.Models
{
    public class Giphy
    {
        public string image { get; set; }
    }

    public class FixedHeightStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class OriginalStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class FixedWidth
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class FixedHeightSmallStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class FixedHeightDownsampled
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class Preview
    {
        public string width { get; set; }
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class FixedHeightSmall
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class DownsizedStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class Downsized
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class DownsizedLarge
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class FixedWidthSmallStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class PreviewWebp
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class FixedWidthStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class FixedWidthSmall
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class DownsizedSmall
    {
        public string width { get; set; }
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class FixedWidthDownsampled
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class DownsizedMedium
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class Original
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string frames { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
        public string hash { get; set; }
    }

    public class FixedHeight
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
        public string webp { get; set; }
        public string webp_size { get; set; }
    }

    public class Looping
    {
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class OriginalMp4
    {
        public string width { get; set; }
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class PreviewGif
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class __invalid_type__480wStill
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string size { get; set; }
    }

    public class Hd
    {
        public string width { get; set; }
        public string height { get; set; }
        public string mp4 { get; set; }
        public string mp4_size { get; set; }
    }

    public class Images
    {
        public FixedHeightStill fixed_height_still { get; set; }
        public OriginalStill original_still { get; set; }
        public FixedWidth fixed_width { get; set; }
        public FixedHeightSmallStill fixed_height_small_still { get; set; }
        public FixedHeightDownsampled fixed_height_downsampled { get; set; }
        public Preview preview { get; set; }
        public FixedHeightSmall fixed_height_small { get; set; }
        public DownsizedStill downsized_still { get; set; }
        public Downsized downsized { get; set; }
        public DownsizedLarge downsized_large { get; set; }
        public FixedWidthSmallStill fixed_width_small_still { get; set; }
        public PreviewWebp preview_webp { get; set; }
        public FixedWidthStill fixed_width_still { get; set; }
        public FixedWidthSmall fixed_width_small { get; set; }
        public DownsizedSmall downsized_small { get; set; }
        public FixedWidthDownsampled fixed_width_downsampled { get; set; }
        public DownsizedMedium downsized_medium { get; set; }
        public Original original { get; set; }
        public FixedHeight fixed_height { get; set; }
        public Looping looping { get; set; }
        public OriginalMp4 original_mp4 { get; set; }
        public PreviewGif preview_gif { get; set; }
        public __invalid_type__480wStill __invalid_name__480w_still { get; set; }
        public Hd hd { get; set; }
    }

    public class User
    {
        public string avatar_url { get; set; }
        public string banner_url { get; set; }
        public string profile_url { get; set; }
        public string username { get; set; }
        public string display_name { get; set; }
        public string twitter { get; set; }
        public bool is_verified { get; set; }
    }

    public class Datum
    {
        public string type { get; set; }
        public string id { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public string bitly_gif_url { get; set; }
        public string bitly_url { get; set; }
        public string embed_url { get; set; }
        public string username { get; set; }
        public string source { get; set; }
        public string rating { get; set; }
        public string content_url { get; set; }
        public string source_tld { get; set; }
        public string source_post_url { get; set; }
        public int is_indexable { get; set; }
        public string import_datetime { get; set; }
        public string trending_datetime { get; set; }
        public Images images { get; set; }
        public string title { get; set; }
        public User user { get; set; }
    }

    public class Pagination
    {
        public int total_count { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
    }

    public class Meta
    {
        public int status { get; set; }
        public string msg { get; set; }
        public string response_id { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
        public Pagination pagination { get; set; }
        public Meta meta { get; set; }
    }
}