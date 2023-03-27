using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project0327
{
    internal class Program
    {
        static void Main(string[] args)                                         // 배열로 스택 구현    
        {
            char[] parking = new char[5];                                       //parking 이라는 이름의 배열을 만든다. 크기는 4byte가 5개 있다.
            int top = 0;                                                        //top이라는 변수를 0으로 초기화 시킨다.

            parking[top] = 'A';                                                 //top이 0이므로 parking[0]에 A가 들어간다. 
            Console.WriteLine("{0}자동차가 주차장에 들어감", parking[top]);
            top++;                                                              //top을 하나 증가 시킨다.

            parking[top] = 'B';                                                 //top이 1이므로 parking[1]에 B가 들어간다. 
            Console.WriteLine("{0}자동차가 주차장에 들어감", parking[top]);
            top++;                                                              //top을 하나 증가 시킨다.

            parking[top] = 'C';                                                 //top이 2이므로 parking[2]에 C가 들어간다.
            Console.WriteLine("{0}자동차가 주차장에 들어감", parking[top]);
            top++;                                                              //top을 하나 증가 시킨다.

            Console.WriteLine();                                                //한줄을 내린다.

            top--;                                                              //top을 하나 감소 시킨다.
            Console.WriteLine("{0}자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';                                                 //top이 2이므로 parking[2]에 빈공간이 들어간다.

            top--;                                                              //top을 하나 감소 시킨다.
            Console.WriteLine("{0}자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';                                                 //top이 1이므로 parking[1]에 빈공간이 들어간다.

            top--;                                                              //top을 하나 감소 시킨다.
            Console.WriteLine("{0}자동차가 주차장을 빠져나감", parking[top]);
            parking[top] = ' ';                                                 //top이 0이므로 parking[0]에 빈공간이 들어간다.

        }
        
    }
}
