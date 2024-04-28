namespace Conesoft.Blazor.Components.Interfaces;

public interface ITagListGenerator
{
    public IEnumerable<string> GenerateTagListFromString(string tagListSource);
}