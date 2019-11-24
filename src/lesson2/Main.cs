using System;

namespace Concept.Tuple.Lesson2 {
    class Main {
        public void Run() {
            Assignment();
            IgnoreNamed();
//            ErrorTypeOrNum();
        }
        private void Assignment() {
            var a = (1, 'a');
            var b = (1, 'b');
            a = b;
            Console.WriteLine(a);
        }
        private void IgnoreNamed() {
            var a = (1, 'a');
            var b = (id: 1, cls: 'b');
            a = b;
            Console.WriteLine(a);
            Console.WriteLine(a.Item1);
//            Console.WriteLine(a.id); // error CS1061
        }
        // 数や型が違うとエラー
        private void ErrorTypeOrNum() {
            var a = (1, 'a');
            var b = (1, 2);
//            a = b; // error CS0266
            Console.WriteLine(a);
        }
    }
}
