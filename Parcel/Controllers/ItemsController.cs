using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Index(string sweight, string sheight, string swidth, string slength)
        {
            int newWeight = int.Parse(sweight);
            int newHeight = int.Parse(sheight);
            int newWidth = int.Parse(swidth);
            int newLength = int.Parse(sweight);


            Item myItem = new Item(newWeight, newHeight, newWidth, newLength);
            myItem.GetVolume();
            myItem.GetCost();
            return View(myItem);
        }
    }
}