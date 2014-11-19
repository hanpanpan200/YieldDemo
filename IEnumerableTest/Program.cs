using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Fionhan.IEnumerableTest
{
    class Persons:System.Collections.IEnumerable
    {
        static void Main(string[] args)
        {
            var persons = new Persons();
            //每一次迭代都会执行GetEnumerator方法获取迭代结果
            //通过这个例子可以看出每一次迭代，yield return 语句都是从上一次迭代的地方开始下次迭代的
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }

        #region IEnumerable 成员
        /// <summary>
        /// yield测试-每一次迭代时，都从上一次的结果开始找起！
        /// </summary>
        /// <returns></returns>
        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "1";
            //Thread.Sleep(1000);
            yield return "2";
            //Thread.Sleep(1000);
            yield return "3";
            //Thread.Sleep(1000);
            yield return "4";
            //Thread.Sleep(1000);
            yield return "5";
            //Thread.Sleep(1000);
        }

        #endregion
    }
}
