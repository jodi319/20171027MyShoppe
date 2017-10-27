using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using myshoppe_demoService.DataObjects;
using myshoppe_demoService.Models;

namespace myshoppe_demoService.Controllers
{
    public class FavouriteController : TableController<Favourite>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myshoppe_demoContext context = new myshoppe_demoContext();
            DomainManager = new EntityDomainManager<Favourite>(context, Request);
        }

        public IQueryable<Favourite> GetAllFeedback()
        {
            return Query(); 
        }

        public SingleResult<Favourite> GetFavourite(string id)
        {
            return Lookup(id);
        }

        public Task<Favourite> PatchFavourite(string id, Delta<Favourite> patch)
        {
             return UpdateAsync(id, patch);
        }

        public async Task<IHttpActionResult> PostFavourite(Favourite item)
        {
            Favourite current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        public Task DeleteFavourite(string id)
        {
             return DeleteAsync(id);
        }
    }
}
