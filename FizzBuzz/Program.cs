using NumberTranslator;
using System;
using System.Collections.Generic;

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
            var translationRules = RuleApi.GetAllRules();
            return new Translator(translationRules);
        }
    }
}
