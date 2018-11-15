using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using MongoDB.Driver;

namespace MongoThings.Web.Things
{
    public class ThingsController : Controller
    {
        private readonly IMongoCollection<Thing> collection;


        public ThingsController(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("mongo-things");
            this.collection = database.GetCollection<Thing>("things");
        }


        [Route("/delete")]
        [HttpPost]
        public IActionResult DeleteAllTheThings()
        {
            this.collection.DeleteMany(x => true);

            return RedirectToAction(nameof(Index));
        }


        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var allTheThings = await this.collection.Find(x => true).ToListAsync();

            var indexViewModel = new IndexViewModel
            {
                Things = allTheThings
            };
            return View("Things/Index.cshtml", indexViewModel);
        }


        [Route("/new-thing")]
        public IActionResult NewThing()
        {
            return View("Things/NewThing.cshtml");
        }


        [Route("/new-thing")]
        [HttpPost]
        public IActionResult NewThing(NewThingFormModel form)
        {
            this.collection.InsertOne(new Thing
            {
                Name = form.Name,
                Description = form.Description
            });

            return RedirectToAction(nameof(Index));
        }
    }
}