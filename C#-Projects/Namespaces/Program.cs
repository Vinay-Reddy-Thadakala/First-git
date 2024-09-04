using System;

namespace Namespaces
{
    class Class
    {
        static void Main(string[] args)
        {
            ProjectA.TeamA.TeamLeader.TeamMember();
            ProjectB.TeamB.TeamLeader.TeamMember(); 
        }
    }
}

namespace ProjectA
{
    namespace TeamA 
    {
        class TeamLeader
        {
            public static void TeamMember()
            {
                Console.WriteLine("ProjectA.Team.TeamLeader.TeamMember();");
            } 
        }
    }
}

namespace ProjectB
{
    namespace TeamB
    {
        class TeamLeader
        {
            public static void TeamMember()
            {
                Console.WriteLine("ProjectA.TeamB.TeamLeader.TeamMember();");
            }
        }
    }
}