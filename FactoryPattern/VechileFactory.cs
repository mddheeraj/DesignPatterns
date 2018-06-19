namespace FactoryPattern
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VechileFactory
    {
        public abstract IFactory GetVechile(string vechileType);
    }
}
