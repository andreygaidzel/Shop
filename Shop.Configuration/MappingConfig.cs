using AutoMapper;
using Shop.DAL.Mapping;

namespace Shop.Configuration
{
    public static class MappingConfig
    {
        public static void Register()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<CategoryProfile>();
            });
        }
    }
}
