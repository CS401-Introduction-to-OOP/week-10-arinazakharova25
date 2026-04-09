namespace Week10;

public class Event
{
    public int NumberTurn { get; set; }
    public string Description { get; set; }
    public EventType EventType { get; set; }
    public string Change { get; set; }

    public Event(int numberTurn, string description, EventType eventType, string change)
    {
        NumberTurn = numberTurn;
        Description = description;
        EventType = eventType;
        Change = change;
    }
    
    public override string ToString()
    {
        return $"Turn {NumberTurn}: {Description} " +
               $" Type: {EventType} " +
               $" Change: {Change}";
    }
}