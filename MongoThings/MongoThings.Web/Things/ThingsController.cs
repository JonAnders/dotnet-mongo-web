#region License
// --------------------------------------------------
// Copyright © PayEx. All Rights Reserved.
// 
// This software is proprietary information of PayEx.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------
#endregion

using Microsoft.AspNetCore.Mvc;

namespace MongoThings.Web.Things
{
    public class ThingsController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View("Things/Index.cshtml");
        }
    }
}