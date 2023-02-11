using System;
using AstronomicalCalculationLib;

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

        internal static void ConvertInConsole()
        {
            Console.WriteLine("--- Start --- MassConversionExamples --- ConvertInConsole ---");
            Console.WriteLine("What is the name of the object to compare ?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the mass of the object to compare ?");
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
            catch (AstronomicalCalculationException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Magenta;
                throw new AstronomicalCalculationException(ex);
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
            catch (AstronomicalCalculationException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Magenta;
                throw new AstronomicalCalculationException(ex);
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
                throw new Exception("Unexpected exception !!!");
                long objectReferenceMass = ReferenceMassConverter.ToReferenceMasses(objectMass, referenceMass);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{objectName} equivalent reference masses : {objectReferenceMass}");
            }
            catch (AstronomicalCalculationException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Magenta;
                throw new AstronomicalCalculationException(ex);
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
