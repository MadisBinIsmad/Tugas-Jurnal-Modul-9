using System.Collections.Generic;

namespace modul9_103082400038.Models

{
    public class Movie
    {
        public string Title { get; set; } = "";
        public string Director { get; set; } = "";
        public List<string> Stars { get; set; } = new List<string>();
        public string Description { get; set; } = "";
    }


}
