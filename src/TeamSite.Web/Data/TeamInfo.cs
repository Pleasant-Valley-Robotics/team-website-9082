using TeamSite.Web.Models;

namespace TeamSite.Web.Data;

/// <summary>
/// Everything your team's site says. To change the site, edit this file.
/// Images go in wwwroot/images/.
/// </summary>
public static class TeamInfo
{
    public static readonly Team Team = new()
    {
        Name = "No Limit Robotics",
        ShortName = "No Limit",
        Program = "FRC",
        Number = 9082,
        Tagline = "Departments of experts, one big team, no member cap.",
        Logo = "/images/no-limit-logo.png",
        AccentColor = "#fbbf24",
        Email = "FRC9082@gmail.com",
        Socials =
        [
            new("Instagram", "https://www.instagram.com/frc_9082/"),
            new("TikTok", "https://www.tiktok.com/@frc.9082.no.limit"),
            new("X", "https://www.twitter.com/frc9082"),
        ],
        Highlights =
        [
            "PVHS's only FRC team",
            "No member cap",
            "Five departments",
        ],
        Story =
        [
            "Pleasant Valley CSD sponsors one FIRST Robotics Competition team: #9082 No Limit Robotics. The team has access to classrooms, computers, printers, software, the wood shop and the metal shop.",
            "There's no member cap, so anyone can join and see if the team is right for them. No Limit is organized into departments, so there's a place for everyone to work on what they find interesting. Follow our social media to keep up with the season and our outreach.",
        ],
        Sections =
        [
            new("Departments",
            [
                new("Communications",
                    "The behind-the-scenes crew for media and public relations. They run social media, the website, team apparel and more. Interested in marketing? This is your department."),
                new("Programming",
                    "Writes the Java and Python that make the robot work, and fixes bugs when something goes wrong. If you like to code, start here."),
                new("Design",
                    "Designs the robot and every part on it in CAD. Without design, there's no robot."),
                new("Mechanical",
                    "Builds the robot with design and programming, using the shop machines plus wiring, soldering and manufacturing."),
                new("Stands Crew",
                    "Every member is on Stands Crew, keeping the energy up at competition by cheering for the drive team, meeting other teams and making signs."),
            ]),
        ],
    };

    // The menu at the top of every page. Add a line when you add a page.
    public static readonly List<(string Label, string Href)> Nav =
    [
        ("Home", "/"),
    ];

    public const string PvSite = "https://www.firstpvrobotics.com";
}
