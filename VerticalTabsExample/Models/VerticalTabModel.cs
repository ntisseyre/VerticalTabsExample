using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerticalTabsExample.Models
{
    public class VerticalTabModel
    {
        public VerticalTabModel(String id, Alignment alignment, String top)
        {
            this.Id = id;
            this.Alignment = alignment;
            this.Top = top;
            this.Href = "#" + this.Id;
        }

         public VerticalTabModel(String id, Alignment alignment, String top, String href)
        {
            this.Id = id;
            this.Alignment = alignment;
            this.Top = top;
            this.Href = href;
        }

        public String Id { get; set; }

        public Alignment Alignment { get; set; }

        public String Top { get; set; }

        public String Href { get; set; }

        public String TabImage
        {
            get { return "~/Content/img/" + this.Id + ".png"; }
        }
    }
}