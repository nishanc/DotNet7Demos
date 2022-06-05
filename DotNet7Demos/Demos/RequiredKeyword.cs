namespace DotNet7Demos.Demos
{
    public class RequiredKeyword
    {
        // Read more - https://github.com/dotnet/csharplang/blob/main/proposals/required-members.md#detailed-design
        public RequiredKeyword(string firstName)
        {
            this.FirstName = firstName;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        // public required string FirstName { get; set; }
        // This will be possible on C# 11 and constructor initialization can be removed.
        // More info at - https://github.com/dotnet/csharplang/blob/main/proposals/required-members.md
        public string LastName { get; set; }
    }
}