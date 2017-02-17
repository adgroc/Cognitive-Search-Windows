using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Specifies which details to retrieve for a video.
    /// </summary>
    public enum VideoModule
    {
        /// <summary>
        /// The related videos
        /// </summary>
        RelatedVideos,
        /// <summary>
        /// The video result
        /// </summary>
        VideoResult
    }
}
