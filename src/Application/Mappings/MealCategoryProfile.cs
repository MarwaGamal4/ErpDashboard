using AutoMapper;
using ErpDashboard.Application.Features.MealsCategory.Commands.AddEdit;
using ErpDashboard.Application.Features.MealsCategory.Queries.Dto;
using ErpDashboard.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Mappings
{
    public class MealCategoryProfile :Profile
    {
        public MealCategoryProfile()
        {
            CreateMap<AddEditMealsCategoryCommand, TbMealsCategory>().ReverseMap();
            CreateMap<GetMealCategoryResponse, TbMealsCategory>().ReverseMap();

        }
    }
}
