using MudBlazor;

namespace GdscRecruitment.Utilities.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class DisplayColorAttribute : Attribute
{
    public DisplayColorAttribute(Color color)
    {
        Color = color;
    }

    public Color Color { get; }
}
