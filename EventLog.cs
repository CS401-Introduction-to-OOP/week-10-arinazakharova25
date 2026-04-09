using System.Collections;
namespace Week10;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events = new();
    public int Count => _events.Count;

    public void Add(Event eventItem)
    {
        _events.Add(eventItem);
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<Event> GetEnumerator()
    {
        List<Event> sortedByChronology = new List<Event>(_events);
        sortedByChronology.Sort((first, second) => first.NumberTurn.CompareTo(second.NumberTurn));
        foreach (var action in sortedByChronology)
        {
            yield return action;
        }
    }
    
    public  IEnumerable<Event> GetTypedEvent(EventType eventType)
    {
        foreach (var act in _events)
        {
            if (act.EventType == eventType)
            {
                yield return act;
            }
        }
    }

    public IEnumerable<Event> GetLastSortedNActions(int number)
    {
        List<Event> events = new List<Event>(_events);
        events.Sort((first, second) => first.NumberTurn.CompareTo(second.NumberTurn));
        
        int first =  events.Count -number;
        if (first < 0)
        {
            first = 0;
        }

        for (int i = first; i < events.Count; i++)
        {
            yield return events[i];
        }
        
    }
}