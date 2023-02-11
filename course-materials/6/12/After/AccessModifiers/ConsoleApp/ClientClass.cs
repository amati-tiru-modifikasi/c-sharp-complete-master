using ClassLibrary.Classes;
using ClassLibrary.Structures;

namespace ConsoleApp
{
    // This class is not in the same assembly than 
    // the types declared in the class library
    public class ClientClass
    {
        private PublicClass PublicClassField;
        private PublicStructure PublicStructField;
        private PublicDerivedClass PublicDerivedClassField;

        public void Method()
        {
            // Compiling error, cannot access internal class here
            // var internalClass = new InternalClass();

            // Compiling error, cannot access internal struct here
            // var internalStruct = new InternalStructure();

            // PublicClass
            PublicClassField.PublicField = string.Empty;

            // Compiling error, cannot access publicClass private member
            // from here
            // PublicClassMember._privateField = string.Empty;

            // Compiling error, cannot access publicClass internal member
            // from here
            // PublicClassMember.InternalField = string.Empty;

            // Compiling error, cannot access publicClass protected member
            // from here
            // PublicClassMember.ProtectedField = string.Empty;


            // Compiling error, cannot access PublicDerivedClass protected internal member
            // from here
            
            // publicDerivedClass.ProtectedInternalField = string.Empty;
            PublicDerivedClassField.PublicField = string.Empty;


            // PublicStructure
            PublicStructField.PublicField = string.Empty;
            // Compiling error, cannot access publicStruct private member
            // from here
            // PublicStructMember._privateField = string.Empty;

            // Compiling error, cannot access publicStruct internal member
            // from here
            // PublicStructMember.InternalField = "hello!";


        }
    }
}