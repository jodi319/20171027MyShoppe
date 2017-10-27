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
    public class UserController : TableController<User>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            myshoppe_demoContext context = new myshoppe_demoContext();
            DomainManager = new EntityDomainManager<User>(context, Request);
        }

        public IQueryable<User> GetAllUser()
        {
            return Query(); 
        }

        public SingleResult<User> GetUser(string id)
        {
            return Lookup(id);
        }

        public Task<User> PatchUser(string id, Delta<User> patch)
        {
             return UpdateAsync(id, patch);
        }

        public async Task<IHttpActionResult> PostUser(User item)
        {
            User current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        public Task DeleteUser(string id)
        {
             return DeleteAsync(id);
        }
    }
}
