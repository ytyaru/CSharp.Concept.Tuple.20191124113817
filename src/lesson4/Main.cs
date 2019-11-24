using System;

namespace Concept.Tuple.Lesson4 {
    class Main {
        public void Run() {
            Decompose1();
            Decompose2();
            Decompose3();
            Decompose4();
            Decompose5();
            Decompose6();
            Decompose7();
        }
        private void Decompose1() {
            var t = (1, 'a');
            (int i, char c) = t;
            Console.WriteLine($"{i}, {c}");
        }
        private void Decompose2() {
            var t = (1, 'a');
            var (i, c) = t;
            Console.WriteLine($"{i}, {c}");
        }
        private void Decompose3() {
            var t = (1, 'a');
            (int i, var c) = t;
            Console.WriteLine($"{i}, {c}");
        }
        class Point {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y) => (X,Y) = (x,y);
        }
        private void Decompose4() {
            var p = new Point(1,2);
            Console.WriteLine($"{p.X}, {p.Y}");
        }
        private void Decompose5() {
            var n = new Name("A", "B");
            var (f, l) = n;
            Console.WriteLine($"{f}, {l}");
        }
        private void Decompose6() {
            var n = new Name3("A", "B", "C");
            var (f, m, l) = n;
            Console.WriteLine($"{f}, {m}, {l}");
        }
        private void Decompose7() { // Deconstructは比較できない
            var n = new Name("A", "B");
            var m = new Name("A", "B");
            Console.WriteLine($"{n == m}"); // False
//            Console.WriteLine($"{n == ("A", "B")}"); // error CS0019
        }
    }
    public class Name {
        public string First { get; }
        public string Last { get; }
        public Name(string first, string last) => (First, Last) = (first, last);
        public void Deconstruct(out string first, out string last) => (first, last) = (First, Last);
    }
    public class Name3 : Name {
        public string Middle { get; }
        public Name3(string first, string middle, string last) : base(first, last) => Middle = middle;
    }
    // error CS1109: Extension methods must be defined in a top level static class; Extensions is a nested class
    public static class Extensions
    {
        public static void Deconstruct(this Name3 n, out string first, out string middle, out string last)
        {
            first = n.First;
            middle = n.Middle;
            last = n.Last;
        }
    }
}
