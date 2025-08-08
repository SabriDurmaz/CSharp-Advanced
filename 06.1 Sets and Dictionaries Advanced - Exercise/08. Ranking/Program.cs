var contests = new Dictionary<string, string>();
string line;

while ((line = Console.ReadLine()) != "end of contests")
{
    var parts = line.Split(':');
    contests[parts[0]] = parts[1];
}

var users = new Dictionary<string, Dictionary<string, int>>();

while ((line = Console.ReadLine()) != "end of submissions")
{
    var parts = line.Split("=>");
    var contest = parts[0];
    var password = parts[1];
    var user = parts[2];
    var points = int.Parse(parts[3]);

    if (!contests.ContainsKey(contest) || contests[contest] != password)
        continue;

    if (!users.ContainsKey(user))
        users[user] = new Dictionary<string, int>();

    if (!users[user].ContainsKey(contest))
        users[user][contest] = 0;

    if (points > users[user][contest])
        users[user][contest] = points;
}

var best = users
    .Select(u => new { Name = u.Key, Total = u.Value.Values.Sum() })
    .OrderByDescending(u => u.Total)
    .First();

Console.WriteLine($"Best candidate is {best.Name} with total {best.Total} points.");
Console.WriteLine("Ranking:");

foreach (var user in users.OrderBy(u => u.Key))
{
    Console.WriteLine(user.Key);
    foreach (var contest in user.Value.OrderByDescending(c => c.Value))
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
}
