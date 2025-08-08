var results = new Dictionary<string, int>();
var languages = new Dictionary<string, int>();

string input;
while ((input = Console.ReadLine()) != "exam finished")
{
    var parts = input.Split('-');
    var username = parts[0];

    if (parts[1] == "banned")
    {
        results.Remove(username);
    }
    else
    {
        var language = parts[1];
        var points = int.Parse(parts[2]);

        if (!results.ContainsKey(username))
            results[username] = 0;

        if (points > results[username])
            results[username] = points;

        if (!languages.ContainsKey(language))
            languages[language] = 0;
        languages[language]++;
    }
}

Console.WriteLine("Results:");
foreach (var user in results.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
    Console.WriteLine($"{user.Key} | {user.Value}");

Console.WriteLine("Submissions:");
foreach (var lang in languages.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
    Console.WriteLine($"{lang.Key} - {lang.Value}");
