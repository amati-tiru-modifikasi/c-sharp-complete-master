namespace ClassLibrary.Structures
{
    // The type or member can be accessed by any code 
    // in the same assembly, but not from another assembly
    internal struct InternalStructure
    {
        private string _privateField;
        internal string InternalField;
        public string PublicField;
        
        // Compiling error, cannot declare a protected field here
        // protected string ProtectedField;
    }
}