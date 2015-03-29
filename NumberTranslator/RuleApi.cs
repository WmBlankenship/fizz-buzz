using System.Collections.Generic;

namespace NumberTranslator
{
    public class RuleApi
    {
        public static List<TranslationRule> GetAllRules()
        {
            return new List<TranslationRule>
            {
                new TranslationRule { Factor = 3, Translation = "Fizz" },
                new TranslationRule { Factor = 5, Translation = "Buzz" }
            };
        }
    }
}
