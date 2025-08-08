var users = new Dictionary<string, string>();
string input;

while ((input = Console.ReadLine()) != "Lumpawaroo")
{
    if (input.Contains(" | "))
    {
        var parts = input.Split(" | ");
        var side = parts[0];
        var user = parts[1];

        if (!users.ContainsKey(user))
            users[user] = side;
    }
    else
    {
        var parts = input.Split(" -> ");
        var user = parts[0];
        var side = parts[1];

        users[user] = side;
        Console.WriteLine($"{user} joins the {side} side!");
    }
}

foreach (var group in users
    .GroupBy(u => u.Value)
    .Where(g => g.Any())
    .OrderByDescending(g => g.Count())
    .ThenBy(g => g.Key))
{
    Console.WriteLine($"Side: {group.Key}, Members: {group.Count()}");
    foreach (var user in group.OrderBy(u => u.Key))
        Console.WriteLine($"! {user.Key}");
}