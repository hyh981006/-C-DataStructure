using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class DoubleLinkList<T> : IListDS<T>
    {
        private DoubleNode<T> head;
        public T this[int index]
        {
            get
            {
                DoubleNode<T> temp = head;
                for (int i = 1; i <= index; i++)
                {
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }
        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(item); //根据新的数据创建一个新的节点
            //如果头结点为空，那么这个新的节点就是头节点
            if (head == null) head = newNode;
            else
            {
                //把新来的节点放到链表的尾部
                //要访问到链表的尾节点
                DoubleNode<T> temp = head;
                while (true)
                {
                    if (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;//把新来的节点放到链表的尾部
                newNode.Previous = temp;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int i)
        {
            return this[i];
        }

        public T GetElem(int i)
        {
            return this[i];
        }

        public int GetLength()
        {
            if (head == null) return 0;
            DoubleNode<T> temp = head;
            int count = 1;
            while (true)
            {
                if (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        public void Insert(T item, int i)
        {
            
        }

        public bool IsEmpty()
        {
            return false;
        }

        public int Locate(T value)
        {
            return 1;
        }
    }
}
