namespace DotNet7Demos.Demos
{
    // README: You need to install System.Runtime.Experimental
    // nuget package to make this work. 
    // https://www.nuget.org/packages/System.Runtime.Experimental/7.0.0-preview.2.22152.2
    // Read more - https://github.com/dotnet/sdk/issues/23073
    public static class INumberInterface
    {
        public static void Demo(){
            // var result = AddAll(new[] { 1, 2, 3, 4, 5});
            // Console.WriteLine(result);
        }

        // static T AddAll<T>(T[] values) where T : INumber<T>{
        //     T result = T.AdditiveIdentity;
        //     foreach (var value in values)
        //     {
        //         result += value;
        //     }
        //     return result;
        // }
    }
}