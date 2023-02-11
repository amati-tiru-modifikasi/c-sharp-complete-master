using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstronomicalCalculationApi.Models;
using AstronomicalCalculationLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AstronomicalCalculationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AstronomicalCalculationController : ControllerBase
    {
        private readonly ILogger<AstronomicalCalculationController> _logger;

        public AstronomicalCalculationController(ILogger<AstronomicalCalculationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Calculate")]
        public ActionResult<AstronomicalCalculationResult> Calculate(string mass, string radius)
        {
            if (string.IsNullOrEmpty(mass) || string.IsNullOrEmpty(radius))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Mass and/or radius are empty");
            }
            if (!double.TryParse(mass, out double massParsed) || !double.TryParse(radius, out double radiusParsed))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Mass and/or radius are not recognized as valid double");
            }
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculateGravity(double.Parse(mass), double.Parse(radius)),
                    EscapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(double.Parse(mass), double.Parse(radius))
                };
            }
            // Better to fail fast
            // catch (ArgumentNullException e)
            // {
            //     _logger.LogError(e.Message, null);
            //     return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            // }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message, null);
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, null);
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured. Please contact our support team");
            }
        }

        [HttpGet("CalculateForPlanet")]
        public ActionResult<AstronomicalCalculationResult> CalculateForPlanet(string planetName)
        {
            if (string.IsNullOrEmpty(planetName))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Planet name is empty");
            }
            if (!IsAlphabetical(planetName))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Planet is not alphabetical");
            }
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculatePlanetGravity(planetName),
                    EscapeVelocity = AstronomicalCalculator.CalculatePlanetEscapeVelocity(planetName)
                };
            }
            // Better to fail fast
            // catch (ArgumentNullException e)
            // {
            //     _logger.LogError(e.Message, null);
            //     return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            // }
            catch (ArgumentException e)
            {
                _logger.LogError(e.Message, null);
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, null);
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured. Please contact our support team");
            }
        }

        private bool IsAlphabetical(string planetName)
        {
            var charArray = planetName.ToCharArray();
            foreach (var character in charArray)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
