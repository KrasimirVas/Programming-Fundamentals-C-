using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace E1.ConvertFromBase10toBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            List<BigInteger> nums = data.Split().Select(BigInteger.Parse).ToList();
            List<BigInteger> res = new List<BigInteger>();
            var baseNum = nums[0];
            var number = nums[1];
            while (number != 0)
            {
                var result = number % baseNum;    //7 10 =13  
                res.Add(result);    //3 1
                number = number / baseNum; //1 /0
            }
            var revRes = string.Join("", res);
            revRes = new string(revRes.Reverse().ToArray());
            Console.WriteLine(revRes);

        }
    }
}
