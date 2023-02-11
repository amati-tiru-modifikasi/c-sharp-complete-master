using System;
using AstronomicalCalculationApi.Models;
using AstronomicalCalculationLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AstronomicalCalculationApi.Controllers
{
    public class AstronomicalCalculationController : ControllerBase
    {
        [HttpGet("Calculate")]
        public ActionResult<AstronomicalCalculationResult> Calculate(string mass, string radius)
        {
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculateGravity(double.Parse(mass), double.Parse(radius)),
                    EscapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(double.Parse(mass), double.Parse(radius))
                };
            }
            catch (Exception ex)
            {
                // Log
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured please contact our support team.");
            }
        }

        [HttpGet("CalculateForPlanet")]
        public ActionResult<AstronomicalCalculationResult> CalculateForPlanet(string planetName)
        {
            try
            {
                return new AstronomicalCalculationResult
                {
                    Gravity = AstronomicalCalculator.CalculatePlanetGravity(planetName),
                    EscapeVelocity = AstronomicalCalculator.CalculatePlanetEscapeVelocity(planetName)
                };
            }
            catch (Exception ex)
            {
                // Log
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occured please contact our support team.");
            }
        }
    }
}
