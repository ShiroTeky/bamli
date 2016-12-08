
using System.Collections.Generic;
namespace PeopLost.Web.Models
{
    public class PictureModels
    {
        /// <summary>
        /// Gets or sets the people picture mime type
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the people image in bit
        /// </summary>
        public byte[] Binary { get; set; }
    }

    public class ListPictureViewModels
    {
        public IList<PictureModels> _Items{get;set;}
        public ListPictureViewModels()
        {
            this._Items = new List<PictureModels>();
        }
    }
}
