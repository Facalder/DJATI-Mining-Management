using DJATI_EAM.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DJATI_EAM.Shared.StoredProcedures;
using System.Text.Json;

namespace DJATI_EAM.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DJATIEAMController : ControllerBase
    {
        private readonly DJATIEAMDBContext _context;

        public DJATIEAMController(DJATIEAMDBContext context)
        {
            this._context = context;
        }
    }
}
