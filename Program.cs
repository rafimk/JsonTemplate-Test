using System.Text.RegularExpressions;



    Regex re = new Regex(@"\{(\w*?)\}", RegexOptions.Compiled); // store this...

    string jsonTemplate = "{\"FirstName\":\"{name}\",\"LastName\":\"{food}\",\"Age\":30}";

    Dictionary<string, string> vals = new Dictionary<string, string>();
    vals.Add("name", "Fred");
    vals.Add("food", "milk");

    string q = re.Replace(jsonTemplate, delegate(Match match)
    {
        string key = match.Groups[1].Value;
        return vals[key];
    });

    Console.WriteLine(q);