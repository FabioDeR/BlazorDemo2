using AutoMapper;
using Recipebook.Application.Features.Articles.Commands.CreateArticle.Record;
using RecipeBook.Application.Features.Articles.Commands.UpdateArticle;
using RecipeBook.Common.Artciles.Dto;
using RecipeBook.Common.Artciles.ViewModels;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipebook.Application.Features.Articles.Profiles
{
    public class ArticleMappingProfile : Profile
	{
		public ArticleMappingProfile()
		{

			CreateMap<Article, CreateArticleCommand>().ReverseMap();
			CreateMap<Article, UpdateArticleCommand>().ReverseMap();
			CreateMap<Article, CreateArtcilesDto>().ReverseMap();
			CreateMap<Article, GetListArticleVM>().ReverseMap();
			CreateMap<Article, GetArticleVM>().ReverseMap();
		}
	}
}
