namespace No1.Solution.Repository
{
    /// <summary>
    ///     Repository interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<in T>
    {
        /// <summary>
        ///     Saves item to <see cref="IRepository{T}"/>
        /// </summary>
        /// <param name="item">Item to save</param>
        void Create(T item);
    }
}