# OOP
## 배열을 활용하여 스택 구현
```cs
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
```
![image](https://user-images.githubusercontent.com/122343846/227838591-500506e0-fb7d-4a58-bbe8-5d716d5e7584.png)

## 링크드리스트를 활용한 스택 구현

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01_0327
{
    internal class Program
    {
        class LinkedListNode                //노드이다. 첫번째 노드가 나머지 노드들을 연결한다.
        {
            public int data;                
            public LinkedListNode next;     

            public LinkedListNode(int x)    //만든 x 노드에 대한 참조
            {                               //연결된 목록 노드에 넣고자 하는 새 데이터를 가져와 생성
                data = x;
                next = null;
            }
        }

        class LinkedList
        {
            int count;
            LinkedListNode head;            //포함하는 연결 목록을 만든 다음 연결된 목록이 있기 떄문에 
                                            // 헤드 노드에 대한 참조
            public LinkedList()             // 생성자를 정의
            {
                head = null;                //헤드 노드를 null로 초기화
                count = 0;                   //카운트를 0으로 지시
            }


            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data); //새 데이터로 새 노드를 만드는것
                node.next = head;                               // 새 노드에 헤드가 무엇인지 또는 현재 위치를 가리키도록 지시
                head = node;                                    
                count++;
            }

            public void deleteNodeToFront(int data)             //노드 삭제
            {
                head = head.next;
            }

            public void printList()                              // 헤드 노드에 대한 임시 참조를 생성할 인쇄 목록 메서드
            {                                                    // 기본적으로 복사본을 생성하고 있으며
                LinkedListNode runner = head;                    // 전체 목록을 반복하고 그 안에 있는 데이터를 인쇄하는 루프 계속 진행
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }
        

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);                      
            linkedList.AddNodeToFront(6);
            linkedList.AddNodeToFront(1);
            linkedList.AddNodeToFront(7);
            linkedList.AddNodeToFront(8);
            linkedList.AddNodeToFront(0);
            linkedList.deleteNodeToFront(0);
            linkedList.printList();

        }
    }
}
```
![image](https://user-images.githubusercontent.com/122343846/227838758-5f9a068b-9f24-40e3-a5a7-5dfc936fbead.png)





객체지향프로그래밍
물품 관리 프로그램 
저의 초기 화면은 종료버튼과 로그인버튼 회원가입버튼으로 구성되어 있습니다.
로그인버튼을 누르면 2번째 로그인창 화면으로 넘어가게 되며 아이디,비밀번호를 기입할수 있습니다.
하지만 회원가입이 안되어 있다면 로그인이 되지 않음으로 
회원가입버튼을 눌러 회원가입을 진행해야 합니다.
회원가입시 먼저 이메일인증을 통해 보안을 강화 했으며
이메일을 넣고 이메일인증 버튼을 누르게 되면 해당 이메일로 인증번호가 전송이 됩니다.
이후 인증번호를 기입한후 이메일 인증 버튼을 누르게 되면 인증 성공이라는 문구가 뜨게 되며 
이후 회원가입에 필요한 이름 아이디 비밀번호를 적는 란이 나오게 됩니다.
작성후 회원가입을 누르게되면 디비에 저장이 됩니다.
로그인 성공시 관리자 창을 누를수 있는 화면이 뜨게 되고
버튼을 누를시 상품판매창의 화면이 뜨게 됩니다. 
상품명, 가격, 개수, 합계 기입란 취소버튼, 담기 버튼, 계산하기버튼, 판매내역 버튼이 있습니다.
상품을 클릭하여 계산하기 버튼을 누를시 디비에 저장이 되며 이후 판매 내역에 저장되게 됩니다.
이상입니다!
















