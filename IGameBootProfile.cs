namespace Monolith
{
    
    public interface IGameBootProfile
    {
        
        string Id { get; }
        IGameBootOptions BootOptions { get; }

    }
    
}