namespace Monolith.Extensions
{
    
    public static class CharExtensions
    {

        public static bool IsDefineDirectiveSafe(this char chr)
        {
            return (chr == '_') || char.IsLetterOrDigit(chr);
        }
        
    }
    
}