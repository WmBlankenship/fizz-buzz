using System.Collections.Generic;
using NumberTranslator;
using NUnit.Framework;

namespace NumberTranslatorTests {
    [TestFixture]
    public class TranslateShould {

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "3")]
        [TestCase(4, "4")]
        [TestCase(5, "5")]
        [TestCase(15, "15")]
        [TestCase(100, "100")]
        public void ReturnStringOfNumberIfThereAreNoRules(int number, string expected) {
            var rules = new List<TranslationRule>();
            var translator = new Translator(rules);

            var result = translator.Translate(number);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        public void ReturnStringOfNumberIfNoRulesApply(int number, string expected) {
            var translator = TranslatorWithFizzRule();

            var result = translator.Translate(number);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(99)]
        public void ReturnTranslationIfOnlyOneRuleApplies(int number) {
            var translator = TranslatorWithFizzRule();

            var result = translator.Translate(number);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(90)]
        public void ReturnConcatenatedTranslationsWhenMultipleRulesApply(int number) {
            var translator = TranslatorWithFizzBuzzRules();

            Assert.That(translator.Translate(number), Is.EqualTo("FizzBuzz"));
        }


        private static Translator TranslatorWithFizzRule() {
            var rules = new List<TranslationRule> {
                new TranslationRule {Factor = 3, Translation = "Fizz"}
            };
            var translator = new Translator(rules);
            return translator;
        }

        private static Translator TranslatorWithFizzBuzzRules() {
            var rules = new List<TranslationRule> {
                new TranslationRule {Factor = 3, Translation = "Fizz"},
                new TranslationRule {Factor = 5, Translation = "Buzz"}
            };
            var translator = new Translator(rules);
            return translator;
        }
    }
}
