namespace ClassLibrary.Structures
{
    // The type or member can be accessed by any other code
    // in the same assembly or another assembly that references it
    public struct PublicStructure
    {
        // InternalStructure is accessible, it's in the same assembly 
        private InternalStructure InternalStructureField;
        
        private string _privateField;
        internal string InternalField;
        public string PublicField;
        
        // Compiling error, cannot declare a protected field here
        // protected string ProtectedField;

        public void Method()
        {
            // InternalStructure PublicField is accessible, it's public 
            InternalStructureField.PublicField = string.Empty;
            // InternalStructure InternalField is accessible, it's in the same assembly 
            InternalStructureField.InternalField = string.Empty;
        }
    }
}