namespace TunerViewer.Contracts
{
    /// <summary>
    /// Channel object
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// Channel guide name.
        /// </summary>
        public string GuideName { get; set; } = "";
        /// <summary>
        /// Channel guide number.
        /// </summary>
        public double GuideNumber { get; set; }
        /// <summary>
        /// Channel video codec.
        /// </summary>
        public string VideoCodec { get; set; } = "";
        /// <summary>
        /// Channel audio codec.
        /// </summary>
        public string AudioCodec { get; set; } = "";
        /// <summary>
        /// Channel is HD.
        /// </summary>
        public bool HD { get; set; }
        /// <summary>
        /// Channel is DRM protected.
        /// </summary>
        public bool DRM { get; set; }
        /// <summary>
        /// Channel streaming URL
        /// </summary>
        public string URL { get; set; } = "";
    }
}
