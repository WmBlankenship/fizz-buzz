using System;
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

        private static Translator FizzBuzzTranslator() {
            var rules = new List<TranslationRule> {
                new TranslationRule {Factor = 3, Translation = "Fizz"},
                new TranslationRule {Factor = 5, Translation = "Buzz"}
            };
            return new Translator(rules);
        }
    }
}
