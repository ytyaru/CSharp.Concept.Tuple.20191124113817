using System;
namespace Concept.Tuple.Lesson6 {
    class Main {
        public void Run() {
            var (i, _) = T(); // 2番目の引数は破棄する
            Console.WriteLine($"{i}");
        }
        private (int, char) T() => (1, 'a');
    }
}
