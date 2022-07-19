using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class Node<T>
    {
        private T data;//存储数据
        private Node<T> next;//指针，用来指向下一个元素
        public T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }
        public Node(){ 
            data=default(T);
            next=null;
        }
        public Node(T value){
            data=value;
            next=null;
        }
        public Node(Node<T> next) {
            this.next = next;
        }
        public Node(T data, Node<T> next) {
            this.data = data;
            this.next = next;
        }
    }
}
