using System;
using AstronomicalCalculationApi.Models;
using AstronomicalCalculationLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AstronomicalCalculationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AstronomicalCalculationController : ControllerBase
    {
        [HttpGet("Calculate")]
        public ActionResult<AstronomicalCalculationResult> Calculate(string mass, string radius)
        {
            if (string.IsNullOrEmpty(mass) || string.IsNullOrEmpty(radius))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Mass and/or radius are empty");
            }
            if (!double.TryParse(mass, out double massParsed) || !double.TryParse(radius, out double radiusParsed))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Mass and/or radius are not valid");                
            }
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculateGravity(double.Parse(mass), double.Parse(radius)),
                    EscapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(double.Parse(mass), double.Parse(radius))
                };
            }
            catch (AstronomicalCalculationException ex)
            {
                // Log
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                // Log
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured, please contact our support team.");
            }
        }

        [HttpGet("CalculateForPlanet")]
        public ActionResult<AstronomicalCalculationResult> Calculate(string planetName)
        {
            if (string.IsNullOrEmpty(planetName))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Planet name is empty");
            }
            if (!IsAlphabetical(planetName))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Planet name is not alphabetical");
            }
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculatePlanetGravity(planetName),
                    EscapeVelocity = AstronomicalCalculator.CalculatePlanetEscapeVelocity(planetName)
                };
            }
            catch (AstronomicalCalculationException ex)
            {
                // Log
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (Exception)
            {
                // Log
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured, please contact our support team.");
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
