using System;
using System.Collections.Generic;
namespace Concept.Tuple.Lesson5 {
    class Main {
        public void Run() {
            Out1();
            Out2();
        }
        private Dictionary<int, (int, string)> GetDict() => new Dictionary<int, (int, string)>() {
            [1] = (234, "First!"),
            [2] = (345, "Second"),
            [3] = (456, "Last"),
        };
        private void Out1() {
            var dict = GetDict();
            dict.TryGetValue(2, out (int num, string place) pair);
            Console.WriteLine($"{pair.num}: {pair.place}");
            Console.WriteLine($"{pair.Item1}: {pair.Item2}");
        }
        private void Out2() {
            var dict = GetDict();
            dict.TryGetValue(2, out (int, string) pair);
            Console.WriteLine($"{pair.Item1}: {pair.Item2}");
        }
    }
}
