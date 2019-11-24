using System;

namespace Concept.Tuple.Lesson3 {
    class Main {
        public void Run() {
            var t = Ret();
            Console.WriteLine($"{t.Item1}, {t.Item2}");

            var u = Named();
            Console.WriteLine($"{u.id}, {u.cls}");
        }
        private (int, char) Ret() { return (1, 'a'); }
        private (int id, char cls) Named() { return (1, 'a'); }
    }
}
