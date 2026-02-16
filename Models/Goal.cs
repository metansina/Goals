namespace Goals.Models;

public class Goal
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime DueDate { get; set; }
    public required string Status { get; set; }
    public required string Priority { get; set; }
}
