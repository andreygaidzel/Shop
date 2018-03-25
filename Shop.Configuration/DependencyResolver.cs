using LightInject;
using Shop.BLL.Abstract.Services;
using Shop.BLL.Services;
using Shop.DAL;
using Shop.DAL.Absctract.Repositories;
using Shop.DAL.Repositories;

namespace Shop.Configuration
{
    public class DependencyResolver
    {
        public static void Register(ServiceContainer container)
        {
            container.Register<ICategoryRepository, CategoryRepository>();

            container.Register<ICategoryService, CategoryService>();

            container.Register<ShopContext>(new PerScopeLifetime());
        }
    }
}
