using AutoMapper;
using Recipebook.Application.Features.UnitOfMeasurements.Commands.CreateUnitOfMeasurement.Record;
using RecipeBook.Common.Shifts.Dto;
using RecipeBook.Common.UnitOfMeasurements.ViewModels;
using RecipeBook.Domain.Entities;
using RecipeBook.UnitOfMeasurements.Features.UpdateUnitOfMeasurement.Commands.UpdateUnitOfMeasurement.Record;

namespace Recipebook.Application.Features.UnitOfMeasurements.Profiles
{
	public class UnitOfMeasurementMappingProfile : Profile
	{
		public UnitOfMeasurementMappingProfile()
		{

			CreateMap<UnitOfMeasurement, CreateUnitOfMeasurementCommand>().ReverseMap();
			CreateMap<UnitOfMeasurement, CreateShiftDto>().ReverseMap();
			CreateMap<UnitOfMeasurement, UpdateUnitOfMeasurementCommand>().ReverseMap();
			CreateMap<UnitOfMeasurement, GetListUnitOfMeasurementVM>().ReverseMap();
			CreateMap<UnitOfMeasurement, GetUnitOfMeasurementVM>().ReverseMap();

		}
	}
}
