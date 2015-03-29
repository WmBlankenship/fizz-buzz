using System;
using System.Linq;
using System.Collections.Generic;
using NumberTranslator;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {
            PlayFizzBuzzUpTo(100);
            Console.ReadLine();
        }

        private static void PlayFizzBuzzUpTo(int limit) {
            var translator = FizzBuzzTranslator();

            for (var number = 1; number <= limit; number++) {
                Console.WriteLine(translator.Translate(number));
            }
        }

        private static Translator FizzBuzzTranslator()
        {
            var ruleImport = GetRuleImport();
            return new Translator(ruleImport);
        }

        private static List<TranslationRule> GetRuleImport()
        {
            return RuleApi.GetAllRules().ToList();
        }
    }
}
