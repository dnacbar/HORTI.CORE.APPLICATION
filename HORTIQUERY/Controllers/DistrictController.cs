﻿using HORTIQUERY.DOMAIN.INTERFACE.APP;
using HORTIQUERY.DOMAIN.MODEL.SIGNATURE;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HORTIQUERY.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public sealed class DistrictController : ControllerBase
    {
        private readonly IDistrictQueryApp _districtQueryApp;

        public DistrictController(IDistrictQueryApp districtQueryApp)
        {
            _districtQueryApp = districtQueryApp;
        }

        [HttpPost(nameof(GetDistrictByIdOrName))]
        public async Task<IActionResult> GetDistrictByIdOrName(DistrictQuerySignature signature)
        {
            return Ok(await _districtQueryApp.GetDistrictByIdOrName(signature));
        }

        [HttpGet(nameof(GetFullListOfDistricts))]
        public async Task<IActionResult> GetFullListOfDistricts()
        {
            return Ok(await _districtQueryApp.GetFullListOfDistricts());
        }

        [HttpPost(nameof(GetListOfDistricts))]
        public async Task<IActionResult> GetListOfDistricts(DistrictQuerySignature signature)
        {
            return Ok(await _districtQueryApp.GetListOfDistricts(signature));
        }
    }
}
