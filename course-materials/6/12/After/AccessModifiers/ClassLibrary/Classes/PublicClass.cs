namespace ClassLibrary.Classes
{
    // The type or member can be accessed by any other code
    // in the same assembly or another assembly that references it
    public class PublicClass
    {
        // InternalClass is accessible, it's in the same assembly 
        private InternalClass InternalClassField;
        
        // Properties
        private string _privateField;
        internal string InternalField;
        public string PublicField;
        protected string ProtectedField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;


        public void Method()
        {
            // InternalClass PublicField is accessible, it's public 
            InternalClassField.PublicField = string.Empty;
            // InternalClass InternalField is accessible, it's internal 
            InternalClassField.InternalField = string.Empty;
            // ProtectedInternalField of InternalClass is accessible, it's in the same assembly 
            InternalClassField.ProtectedInternalField = string.Empty;
            
            // Compiling error, PrivateProtectedField of InternalClass is not accessible 
            // InternalClass is not a base class
            // InternalClass.PrivateProtectedField = string.Empty;
            
            // Compiling error, cannot access a protected field
            // from InternalClass, it's not a base class of this class
            // InternalClass.ProtectedField = string.Empty;
        }
    }
}