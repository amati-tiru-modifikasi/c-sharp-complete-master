using System;
using AstronomicalCalculationLibrary;

namespace AstronomicalCalculationConsole
{
    public static class MassConversionExamples
    {
        public static void MassConversions()
        {
            Console.WriteLine("--- Start --- MassConversionExamples --- MassConversions ---");
            ConvertToSolarMassAndPrint(Stars.R136A1.ToString(), Constants.Stars.R136A1.MASS);
            ConvertToEarthMassAndPrint(Satellites.Europa.ToString(), Constants.Satellites.Europa.MASS);
            ConvertToReferenceMassAndPrint("50 meters asteroid", 1000000000, 1000);
            Console.WriteLine("--- End --- MassConversionExamples --- MassConversions ---");
        }

        public static void ConvertInConsole()
        {
            Console.WriteLine("--- Start --- MassConversionExamples --- ConvertInConsole ---");
            Console.WriteLine("What is the name of the object to compare ?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the mass in kg of the object to compare ?");
            ConsoleInputHelper.PromptForMass(out long massInKg);
            Console.WriteLine("What is the reference mass in kg ?");
            ConsoleInputHelper.PromptForMass(out long referenceMassInKg);
            ConvertToReferenceMassAndPrint(name, massInKg, referenceMassInKg);
            Console.WriteLine("--- End --- MassConversionExamples --- ConvertInConsole ---");
        }   

        private static void ConvertToSolarMassAndPrint(string objectName, double objectMass)
        {
            try
            {
                double objectSolarMass = ReferenceMassConverter.ToSolarMasses(objectMass);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{objectName} equivalent solar masses : {Math.Round(objectSolarMass, 5)}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
            }
        }
        private static void ConvertToEarthMassAndPrint(string objectName, double objectMass)
        {
            try
            {
                double objectEarthMass = ReferenceMassConverter.ToEarthMasses(objectMass);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{objectName} equivalent earth masses : {Math.Round(objectEarthMass, 5)}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
            }
        }
        private static void ConvertToReferenceMassAndPrint(string objectName, long objectMass, long referenceMass)
        {
            try
            {
                long objectReferenceMass = ReferenceMassConverter.ToReferenceMasses(objectMass, referenceMass);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{objectName} equivalent reference masses : {objectReferenceMass}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
