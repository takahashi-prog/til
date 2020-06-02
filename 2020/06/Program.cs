using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            var list = Enumerable.Range(1, 10);
            var result = Calc(list, divide3);
            result = Calc(list, power);
            result = Calc(list, multi2);
        }

        public static int power(int i) {
            return i * i;
        }
        public static int divide3(int i) {
            return (int)(i / 3);
        }
        public static int multi2(int i) {
            return (int)(i * 2);
        }

        public static IEnumerable<int> Calc(IEnumerable<int> list, Func<int, int> calculator) {
            var result = new List<int>();
            foreach (var i in list) {
                result.Add(calculator(i));
            }
            return result;
        }
    }
}
