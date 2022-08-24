using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Part2.DataStructure {

    /*
     * 배열, 동적 배열, 연결 리스트 비교
     * 
     * 선형 구조는 자료를 순차적으로 나열한 형태
     * - 배열
     * - 연결 리스트
     * - 스택/큐
     * 
     * 비선형 구조는 하나의 자료 뒤에 다수의 자료가 올 수 있는 형태
     * -트리
     * -그래프
     */
    class Board {

        public int[] _data1 = new int[25]; // 배열

        public MyList<int> _data2 = new MyList<int>(); // 동적 배열

        public MyLinkedList<int> _data3 = new MyLinkedList<int>(); // 연결 리스트

        public void Initalize() {

            //_data2.Add(101);
            //_data2.Add(102);
            //_data2.Add(103);
            //_data2.Add(104);
            //_data2.Add(105);

            //int temp = _data2[2];

            //_data2.RemoveAt(2);

            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }

    class MyLinkedListNode<T> {
        public T Data;
        public MyLinkedListNode<T> Next;
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T> {
        public MyLinkedListNode<T> Head = null; //첫번째
        public MyLinkedListNode<T> Tail = null; //마지막
        public int Count = 0;

        // 0(1)
        public MyLinkedListNode<T> AddLast(T data) {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T> ();
            newRoom.Data = data;

            // 만약에 아직 방이 아예 없었다면, 새로 추가한 첫번째 방이 곧 Head이다.
            if(Head == null)
               Head = newRoom;

            // 기본의 [마지막 방]과 [새로 추가되는 방]을 연결해준다.
            if(Tail != null) {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            // [새로 추가되는 방]을 [마지막 방]으로 인정한다.
            Tail = newRoom;
            Count++;
            return newRoom;
        }

        // 0(1)
        // 101 102 103 104 105
        public void Remove(MyLinkedListNode<T> room) {

            // 기존의 처번째 방의 다음 방을 첫번째 방으로 인정한다.
            if (Head == room)
                Head = Head.Next;

            // 기존의 마지막 방의 이전 방을 마지막 방으로 인정한다.
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    // 동적 배열 분석
    class MyList<T> {

        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count = 0; // 실제로 사용중인 데이터 갯수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 갯수

        // 0(N)
        public void Add(T item) {
            // 1.공간이 충분히 남아 있는지 확인한다.
            if (Count >= Capacity) {
                // 공간을 다시 늘려서 확보한다.
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }

            // 2.공간에다가 데이터를 넣어준다.
            _data[Count] = item;
            Count++;
        }
        // 0(1)
        public T this[int index] {
            get { return _data[index]; }
            set { _data[index] = value; }

        }
        // 0(N)
        public void RemoveAt(int index) {
            // 101 102 103 104 105
            for(int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
    }
}
