using System.Collections.Generic;
using System.Linq;

namespace NumberTranslator {
    public class Translator {
        private readonly IList<TranslationRule> rules;

        public Translator(IList<TranslationRule> rules) {
            this.rules = rules;
        }

        public string Translate(int number) {
            var fullTranslation = string.Empty;
            var ruleHasBeenApplied = false;

            foreach (var rule in rules.Where(rule => RuleAppliesToNumber(rule, number))) {
                fullTranslation += rule.Translation;
                ruleHasBeenApplied = true;
            }

            return ruleHasBeenApplied ? fullTranslation : number.ToString();
        }

        private static bool RuleAppliesToNumber(TranslationRule rule, int number) {
            return number % rule.Factor == 0;
        }
    }
}
