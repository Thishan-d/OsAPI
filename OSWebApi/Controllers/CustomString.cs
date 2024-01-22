using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OSWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomString : ControllerBase
    {
        private readonly ICustomStringService _ICustomStringService;
        public CustomString(ICustomStringService _services)
        {
            _ICustomStringService = _services;
        }

        [HttpGet]
        public ObjectResult  GetCustomString(string InputString)
        {
            try
            {
                var reversedString = _ICustomStringService.ReverseString(InputString);
                var convertedAllVowels = _ICustomStringService.ConvertVowelsToLowercase(reversedString);
                var ConvertAllConsonants = _ICustomStringService.ConvertConsonantsToUppercase(convertedAllVowels);
                var FinalString = _ICustomStringService.IgnoreNumbersInWord(ConvertAllConsonants);     //IgnoredNumbers
                return Ok(FinalString);
            }

            catch(Exception ex)
            {
                var errorObjectResult = new ObjectResult(ex.Message);
                errorObjectResult.StatusCode = StatusCodes.Status500InternalServerError;
                return errorObjectResult;
            }

        }
    }
}
