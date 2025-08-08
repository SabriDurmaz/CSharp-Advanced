Dictionary<string, HashSet<string>> followers = new();
Dictionary<string, HashSet<string>> followings = new();

string input;
while ((input = Console.ReadLine()) != "Statistics")
{
    string[] parts = input.Split();
    if (parts[1] == "joined")
    {
        string vlogger = parts[0];
        if (!followers.ContainsKey(vlogger))
        {
            followers[vlogger] = new HashSet<string>();
            followings[vlogger] = new HashSet<string>();
        }
    }
    else if (parts[1] == "followed")
    {
        string follower = parts[0];
        string followed = parts[2];

        if (follower != followed &&
            followers.ContainsKey(follower) &&
            followers.ContainsKey(followed) &&
            !followings[follower].Contains(followed))
        {
            followings[follower].Add(followed);
            followers[followed].Add(follower);
        }
    }
}

Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");

int rank = 1;
foreach (var vlogger in followers
    .OrderByDescending(f => f.Value.Count)
    .ThenBy(f => followings[f.Key].Count))
{
    Console.WriteLine($"{rank++}. {vlogger.Key} : {vlogger.Value.Count} followers, {followings[vlogger.Key].Count} following");

    if (rank == 2)
    {
        foreach (var follower in vlogger.Value.OrderBy(f => f))
            Console.WriteLine($"*  {follower}");
    }
}