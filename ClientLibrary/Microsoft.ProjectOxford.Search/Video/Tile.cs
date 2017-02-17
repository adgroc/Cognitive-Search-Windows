using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Tile returned from the video detail API.
    /// </summary>
    public class Tile
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        public Tile()
        {
            this.Tiles = new List<TileDetail>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        [JsonProperty("tiles")]
        public List<TileDetail> Tiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        #endregion Properties
    }
}
