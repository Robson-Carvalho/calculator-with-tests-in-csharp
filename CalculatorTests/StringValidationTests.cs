using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidationTests
    {
        private StringValidation _validations;

        public StringValidationTests()
        {
            _validations = new StringValidation();
        }

        [Fact]
        public void MustCountTheNumberOfCharactersAndReturnTheCountedNumber()
        {
            string word = "robson";

            int result = _validations.CountCharacters(word);

            Assert.Equal(6, result);

        }

        // Theory - Conjunto de dados que passamos para um método e será validado casa dado.

        [Theory]
        [InlineData(new string[] {"Robson", "oi", "uva"}, new int[] {6, 2, 3})]
        public void MustCountTheNumberOfCharactersAndReturnTheCountedNumberUsingTheory(string[] texts, int[] values){

            for(int count = 0; count < texts.Length; count++)
            {
                Assert.Equal(values[count], _validations.CountCharacters(texts[count]));
            }
        }
    }
}
