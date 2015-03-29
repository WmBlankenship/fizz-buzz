using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTranslator
{
    public class RuleApi
    {
        public static IEnumerable<TranslationRule> GetAllRules()
        {
            yield return new TranslationRule
            {
                Factor = 3,
                Translation = "Fizz"
            };
            yield return new TranslationRule
            {
                Factor = 5,
                Translation = "Buzz"
            };
        }
    }
}
