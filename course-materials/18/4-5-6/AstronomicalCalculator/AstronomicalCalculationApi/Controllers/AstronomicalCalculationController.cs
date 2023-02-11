using System;
using AstronomicalCalculationApi.Models;
using AstronomicalCalculationLibrary;
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
            
            return new AstronomicalCalculationResult
            {
                Gravity = AstronomicalCalculator.CalculateGravity(double.Parse(mass), double.Parse(radius)),
                EscapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(double.Parse(mass), double.Parse(radius))
            };
        }

        [HttpGet("CalculateForPlanet")]
        public ActionResult<AstronomicalCalculationResult> CalculateForPlanet(string planetName)
        {
            return new AstronomicalCalculationResult
            {
                Gravity = AstronomicalCalculator.CalculatePlanetGravity(planetName),
                EscapeVelocity = AstronomicalCalculator.CalculatePlanetEscapeVelocity(planetName)
            };
        }
    }
}
