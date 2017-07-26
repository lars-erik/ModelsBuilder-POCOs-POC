using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MbPocoPoc.Core
{
    public class Parent
    {
        public Parent()
        {
        }

        public IHtmlString RichText { get; set; }

        public IEnumerable<Child> PocoChildren { get; set; }
    }
}
