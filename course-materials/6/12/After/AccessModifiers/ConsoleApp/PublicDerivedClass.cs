using ClassLibrary.Classes;

namespace ConsoleApp
{
    public class PublicDerivedClass : PublicClass
    {
        public void Method()
        {
            ProtectedField = string.Empty;
            ProtectedInternalField = string.Empty;
        }
    }
}