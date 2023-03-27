using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01_0327
{
    internal class Program01
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
