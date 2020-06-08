using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymoTest
{
    // 出力部
    class PolymoTest
    {
        static void Main(string[] args)
        {

            var seed = new Random().Next();
            Animal animal;

            // Birdクラスを元にインスタンスを生成する
            if (seed % 2 == 0)
            {
                animal = new Bird();
            }
            else
            {
                animal = new Dog();
            }

            // 鳴き声とクラスの表示
            Console.WriteLine(animal.ClassName());
            Console.WriteLine(animal.Cry());
            Console.ReadLine();
        }

    }

    abstract class Animal
    {
        // 抽象メソッド(サブクラスで共通名のメソッドを使用するという制約をかける)
        public abstract string Cry();

        public string ClassName()
        {
            return this.GetType().Name;
        }
    }


    // Animalを継承した鳥の鳴き声を返すBirdクラス
    class Bird : Animal
    {
        public override string Cry()
        {
            return "ピヨピヨ";
        }
        public string Fly()
        {
            return "I can fly.";
        }

    }

    class Dog : Animal
    {
        public override string Cry()
        {
            return "ワン";
        }

    }

}
