using System;

namespace Concept.Tuple.Lesson1 {
    class Main {
        public void Run() {
            Equal();
            NotEqual();
            Var();
            EqualNamed();
            NotEqualNamed();
            Nested();
            NotEqualNested();
        }
        private void Equal() { Console.WriteLine((1, 'a') == (1, 'a')); }
        private void NotEqual() { Console.WriteLine((1, 'a') == (1, 'b')); }
        private void Var() {
            var a = (1, 'a');
            var b = (1, 'b');
            Console.WriteLine(a == b);
        }
        private void EqualNamed() {
            var a = (id:1, cls:'a');
            var b = (id:1, cls:'a');
            Console.WriteLine(a == b);
        }
        private void NotEqualNamed() {
            var a = (i1:1, i2:'a');
            var b = (k1:1, k2:'a');
            Console.WriteLine(a == b);
        }
        private void Nested() {
            var a = (id:1, cls:(1, 'a'));
            var b = (id:1, cls:(1, 'a'));
            Console.WriteLine(a == b);
        }
        private void NotEqualNested() {
            var a = (id:1, cls:(1, 'a'));
            var b = (id:1, cls:(1, 'b'));
            Console.WriteLine(a == b);
        }
    }
}
