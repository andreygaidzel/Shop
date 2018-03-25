using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.BLL.Abstract.Services;
using Shop.Domain.Category;

namespace Shop.WEB.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        public ICategoryService CategoryService { get; }

        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }

        [HttpGet]
        [Route("list")]
        public List<CategoryDomain> List()
        {
            return CategoryService.List();
        }
    }
}
