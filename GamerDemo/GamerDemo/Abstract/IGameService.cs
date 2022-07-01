namespace GamerDemo.Entities
{
    public interface IGameService
    {
        void Add(Game game);
        void Remove(Game game);
        void Update(Game game);
    }
}