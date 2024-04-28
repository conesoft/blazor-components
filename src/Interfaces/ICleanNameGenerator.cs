namespace Conesoft.Blazor.Components.Interfaces;

public interface ICleanNameGenerator
{
    public string GenerateCleanNameFromString(string tagListSource);
}