using AutoMapper;
using GdscRecruitment.Common.Features.Examples.Models;
using GdscRecruitment.Features.Fields.Models;
using GdscRecruitment.Features.Fields.Views;
using GdscRecruitment.Features.Responses.Models;
using GdscRecruitment.Features.Responses.Views;

namespace GdscRecruitment.Utilities.Mappers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap(typeof(FieldModel), typeof(FieldResponseView)).ReverseMap();
        CreateMap<FieldModel, FieldRequestView>().ReverseMap();
        CreateMap<ResponseModel, ResponseRequestView>().ReverseMap();
        CreateMap<ResponseModel, ResponseResponseView>().ReverseMap();
        CreateMap(typeof(ExampleModel), typeof(ExampleViewModel)).ReverseMap();
    }
}
