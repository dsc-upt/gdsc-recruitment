using GdscRecruitment.Base.Models;

namespace GdscRecruitment.Features.Forms;

public class FieldModel : Model
{
    public string Name { get; set; }

    public bool IsRequired { get; set; }

    public string? Placeholder { get; set; }
}