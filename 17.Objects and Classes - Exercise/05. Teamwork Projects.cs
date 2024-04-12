using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Transactions;
using System.Xml.Linq;

internal class Team
{
    public string Creator { get; set; }
    public List<string> Member { get; set; }
    public string Teams { get; set; }

    public Team(string creator, string teams)
    {
        Creator = creator;
        Member = new List<string>();
        Teams = teams;
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Team> list = new List<Team>();

        for (int i = 0; i < n; i++)
        {
            List<string> register = Console.ReadLine().Split("-").ToList();

            string creator = register[0];
            string member = null;
            string teams = register[1];

            Team team = new Team(creator, teams);

            if (i == 0)
            {
                list.Add(team);
                Console.WriteLine($"Team {teams} has been created by {creator}!");
            }

            else
            {
                if (!list.Exists(team => team.Creator == creator))
                {
                    if (!list.Exists(team => team.Teams == teams))
                    {
                        list.Add(team);
                        Console.WriteLine($"Team {teams} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teams} was already created!");
                    }
                }
                else
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

        }

        List<string> secondList = Console.ReadLine().Split("->").ToList();

        int count = 0;

        while (secondList[0] != "end of assignment")
        {
            string member = secondList[0];
            string teams = secondList[1];

            if (!list.Exists(t => t.Creator == member || t.Member.Contains(member)))
            {
                if (!list.Exists(t => t.Teams == teams))
                {
                    Console.WriteLine($"Team {teams} does not exist!");
                }
                else
                {
                    list.Find(team => team.Teams == teams).Member.Add(member);
                }
            }
            else
            {
                Console.WriteLine($"Member {member} cannot join team {teams}!");
            }

            secondList = Console.ReadLine().Split("->").ToList();

            count++;
        }

        list = list.OrderByDescending(t => t.Member.Count).ThenBy(t => t.Teams).ToList();

        List<Team> dispatch = new List<Team>();

        foreach (Team item in list)
        {
            if (item.Member.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", item.Teams)}");
                Console.WriteLine($"- {string.Join(" ", item.Creator)}");
                Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", item.Member.OrderBy(t => t))}");
            }
            else
            {
                dispatch.Add(item);
            }
        }

        dispatch = dispatch.OrderBy(d => d.Teams).ToList();

        Console.WriteLine($"Teams to disband:");

        foreach (Team creator in dispatch)
        {
            Console.WriteLine($"{creator.Teams}");
        }
    }
}