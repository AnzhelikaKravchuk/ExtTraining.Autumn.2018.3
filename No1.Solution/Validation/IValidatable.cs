namespace No1.Solution.Validation
{
    /// <summary>
    ///     <see cref="IValidatable{T}"/> interface
    /// </summary>
    public interface IValidatable<in T>
    {
        /// <summary>
        ///     Checks if item is valid
        /// </summary>
        /// <param name="item">Source item</param>
        /// <returns>True if is valid else false</returns>
        bool IsValid(T item);
    }
}