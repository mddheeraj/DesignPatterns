namespace PrototypePattern
{
    /// <summary>
    /// The 'Prototype' interface
    /// </summary>
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
