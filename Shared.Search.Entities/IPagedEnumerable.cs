namespace Shared.Search.Entities
{
    public interface IPagedEnumerable<out TModel>
    where TModel : class, new()
    {
        public IEnumerable<TModel> Data { get; }

        public int TotalPages { get; }

        public int CurrentPage { get; }

        public int TotalItems { get; }
    }
}