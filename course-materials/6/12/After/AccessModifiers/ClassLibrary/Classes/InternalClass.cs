namespace ClassLibrary.Classes
{
    // The type or member can be accessed by any code 
    // in the same assembly, but not from another assembly
    internal class InternalClass
    {
        private string _privateField;
        internal string InternalField;
        public string PublicField;
        protected string ProtectedField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;
    }
}