// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");


string ReferranceName = "UserValidation";
Collection<String> RefCol = new Collection<String>();
RefCol.Add(string.Format("samplescope samplescope", ReferranceName));
IEnumerable<String> REQScop = RefCol as IEnumerable<String>;

var Token = OAuthTokenPOC.TokenFile.RequestToken("https://sampleurl.com", "sample", "secret", REQScop);

Console.WriteLine(Token.AccessToken);
Console.WriteLine("Stop on this line");