using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace MbPocoPoc.Web.Controllers
{
    public class ParentController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return CurrentTemplate(((Parent) model.Content).Proxy);
        }
    }
}