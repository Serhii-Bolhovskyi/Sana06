namespace Sana06.Models;

public class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public List<Technology> Technologies { get; set; }
}

public class Technology
{
    public string Name { get; set; }
    public string Icon { get; set; } 
}