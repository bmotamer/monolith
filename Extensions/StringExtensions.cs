namespace Monolith.Extensions
{
    
    public static class StringExtensions
    {

        public static bool IsDefineDirectiveSafe(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            foreach (char chr in str)
            {
                if (!chr.IsDefineDirectiveSafe()) return false;
            }

            return true;
        }
        
    }
    
}