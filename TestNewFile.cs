using System;
using System.Collections.Generic;

namespace TestNewFile {
    public class NumberGenerator {
        public List<int> numbers = new List<int>();
        public NumberGenerator() {
           numbers.Add(1);
           numbers.Add(1);
        }

        public void NewNumber() {
            numbers.Add(numbers[numbers.Count-1] + numbers[numbers.Count-2]);
            Console.WriteLine(numbers[numbers.Count-1]);
        }
    }
}