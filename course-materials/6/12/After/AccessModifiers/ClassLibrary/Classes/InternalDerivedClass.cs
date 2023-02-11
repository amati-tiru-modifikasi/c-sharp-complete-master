namespace ClassLibrary.Classes
{
    // The type or member can be accessed by any code 
    // in the same assembly, but not from another assembly
    internal class InternalDerivedClass : InternalClass
    {
        public void Method()
        {
            // ProtectedField is accessible InternalClass is a base class
            ProtectedField = string.Empty;
            // ProtectedInternalField is accessible, it's in the same assembly 
            // and InternalClass is a base class
            ProtectedInternalField = string.Empty;
            // PrivateProtectedField is accessible, InternalClass in the same assembly 
            // and InternalClass is a base class
            PrivateProtectedField = string.Empty;
            InternalField = string.Empty;
            PublicField = string.Empty;
        }
    }
}