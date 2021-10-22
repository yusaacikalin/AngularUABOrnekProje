using API.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class LimanController : Controller
    {

        [HttpGet("getall")]
        public string GetAll()
        {
            #region Data
            List<LimanModel> model = new List<LimanModel>();
            for (int i = 0; i < 6; i++)
            {
                LimanModel liman = new LimanModel();
                liman.id = i + 1;
                liman.LimanAdi = "Liman-" + (i + 1);
                liman.LimanSoyadi = "Limanı-" + (i + 1);
                model.Add(liman);
            }
            #endregion

            return JsonSerializer.Serialize(model);
        }
    }
}
