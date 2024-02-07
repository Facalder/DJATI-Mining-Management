using DJATI_EAM.Model;
using Microsoft.AspNetCore.Mvc;

namespace DJATI_EAM.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EAMController : ControllerBase
    {
        private readonly EAMDBContext _context;

        public EAMController(EAMDBContext context)
        {
            this._context = context;
        }
    }
}