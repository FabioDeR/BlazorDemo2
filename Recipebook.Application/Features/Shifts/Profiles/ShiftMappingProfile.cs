using AutoMapper;
using Recipebook.Application.Features.Shifts.Commands.CreateShift.Record;
using RecipeBook.Common.Shifts.Dto;
using RecipeBook.Common.Shifts.ViewModels;
using RecipeBook.Domain.Entities;
using RecipeBook.Shifts.Features.UpdateShift.Commands.UpdateShift.Record;

namespace Recipebook.Application.Features.Shifts.Profiles
{
	public class ShiftMappingProfile : Profile
	{
		public ShiftMappingProfile()
		{
			CreateMap<Shift, CreateShiftCommand>().ReverseMap();
			CreateMap<Shift, CreateShiftDto>().ReverseMap();
			CreateMap<Shift, UpdateShiftCommand>().ReverseMap();
			CreateMap<Shift, GetListShiftVM>().ReverseMap();
			CreateMap<Shift, GetShiftVM>().ReverseMap();
		}
	}
}
