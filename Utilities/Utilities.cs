public class Utilities
{
    public static string ReplaceJsonValues(string jsonTemplate, string newFirstName, string newLastName)
    {
        // Use string.Format to replace placeholders with actual values
        string jsonString = string.Format(jsonTemplate, newFirstName, newLastName);

        return jsonString;
    }
}