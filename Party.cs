using System.Collections;
namespace Week10;

public class Party : IEnumerable<Character>
{
    private List<Character> characters = new List<Character>();
    public int Count => characters.Count;

    public void Add(Character character)
    {
        characters.Add(character);
    }

    public void Remove(Character character)
    {
        characters.Remove(character);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in characters)
        {
            yield return character;
        }
    }

    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var character in characters)
        {
            if (character.Status == StatusCharacter.Active)
            {
                yield return character;
            }
        }
    }

    public IEnumerable<Character> GetCharactersByLimit(int limit)
    {
        foreach (var character in characters)
        {
            if (character.Health <= limit)
            {
                yield return character;
            }
        }
    }
}