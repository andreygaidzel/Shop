namespace Shop.DAL.Repositories.Base
{
    public class BaseRepository
    {
        public ShopContext Context { get; }

        public BaseRepository(ShopContext context)
        {
            Context = context;
        }
    }
}
