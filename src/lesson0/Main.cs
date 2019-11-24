using System;

namespace Concept.Tuple.Lesson0 {
    class Main {
        public void Run() {
            Indexed();
            Named();
        }
        private void Indexed() {
            var t = (1, 'a', "abc");
            Console.WriteLine($"{t.Item1}, {t.Item2}, {t.Item3}");
        }
        private void Named() {
            var t = (id:1, cls:'a', name:"abc");
            Console.WriteLine($"{t.id}, {t.cls}, {t.name}");
        }
    }
}
