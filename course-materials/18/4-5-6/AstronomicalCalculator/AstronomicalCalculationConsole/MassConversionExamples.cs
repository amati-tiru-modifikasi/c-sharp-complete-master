using System;
using AstronomicalCalculationLibrary;

namespace AstronomicalCalculationConsole
{
    public static class MassConversionExamples
    {
        private static readonly string _separator = "-------------------";
        public static void MassConversions()
        {
            ConvertToSolarMassAndPrint(Stars.R136A1.ToString(), Constants.Stars.R136A1.MASS);
            Console.WriteLine(_separator);
            ConvertToEarthMassAndPrint(Satellites.Europa.ToString(), Constants.Satellites.Europa.MASS);
            Console.WriteLine(_separator);
            ConvertToReferenceMassAndPrint("50 meters asteroid",1000000000,1000);
            Console.WriteLine(_separator);
        }
        public static void ConvertInConsole()
        {
            Console.WriteLine("What is the name of the object to compare ?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the mass in kg of the object to compare ?");
            ConsoleInputHelper.PromptForMass(out long massInKg);
            Console.WriteLine("What is the reference mass in kg ?");
            ConsoleInputHelper.PromptForMass(out long referenceMassInKg);
            ConvertToReferenceMassAndPrint(name, massInKg, referenceMassInKg);
        }

        private static void ConvertToSolarMassAndPrint(string objectName, double objectMass)
        {
            double objectSolarMass = ReferenceMassConverter.ToSolarMasses(objectMass);
            Console.WriteLine($"{objectName} equivalent solar masses : {Math.Round(objectSolarMass, 5)}");
        }

        private static void ConvertToEarthMassAndPrint(string objectName, double objectMass)
        {
            double objectEarthMass = ReferenceMassConverter.ToEarthMasses(objectMass);
            Console.WriteLine($"{objectName} equivalent earth masses : {Math.Round(objectEarthMass, 5)}");
        }
        private static void ConvertToReferenceMassAndPrint(string objectName, long objectMass, long referenceMass)
        {
            long objectReferenceMass = ReferenceMassConverter.ToReferenceMasses(objectMass, referenceMass);
            Console.WriteLine($"{objectName} equivalent reference masses : {objectReferenceMass}");
        }
    }
}
