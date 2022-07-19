using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class LinkList<T> : IListDS<T>
    {
        private Node<T> head;//存储一个头结点

        public LinkList()
        {
            head = null;
        }
        /// <summary>
        /// 返回索引下的数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index] {
            get{
                Node<T> temp = head;
                for (int i = 1; i <= index; i++){
                    temp = temp.Next;
                }
                return temp.Data;
            }
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item) {
            Node<T> newNode = new Node<T>(item); //根据新的数据创建一个新的节点
            //如果头结点为空，那么这个新的节点就是头节点
            if(head==null) head = newNode;
            else {
                //把新来的节点放到链表的尾部
                //要访问到链表的尾节点
                Node<T> temp = head;
                while (true) {
                    if (temp.Next != null) {
                        temp=temp.Next;
                    }
                    else{
                        break;
                    }
                }
                temp.Next = newNode;//把新来的节点放到链表的尾部
            }
        }
        /// <summary>
        /// 清空单链表
        /// </summary>
        public void Clear() {
            head=null;
        }
        /// <summary>
        /// 删除指定索引数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index) {
            T data = default(T);
            if(index==0){  //删除头节点
                data =head.Data;
                head=head.Next;
            }
            else {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++){
                    //让temp向后移动一个位置
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                Node<T> nextNode = temp.Next.Next;
                //上一节点指向新的节点
                preNode.Next = nextNode;
            }
            return data;
        }
        /// <summary>
        /// 获取索引下的数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetElem(int index){
            return this[index];
        }
        /// <summary>
        /// 获取单链表长度
        /// </summary>
        /// <returns></returns>
        public int GetLength(){
            if (head == null) return 0;
            Node<T> temp = head;
            int count = 1;
            while (true){
                if (temp.Next != null){
                    count++;
                    temp = temp.Next;
                }
                else{
                    break;
                }
            }
            return count;
        }
        /// <summary>
        /// 插入数据【需要考虑插入的是头部还是其他位置】
        /// </summary>
        /// <param name="item">所要插入的数据</param>
        /// <param name="index">插入的位置索引</param>
        public void Insert(T item, int index) {
            Node<T> newNode=new Node<T>(item);
            //插入到头节点
            if (index == 0) {
                newNode.Next = head;
                head = newNode;
            }
            else {
                Node<T> temp = head;
                for (int i = 1;i<=index-1;i++){
                    //让temp向后移动一个位置
                    temp=temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                //上一节点指向新的节点
                preNode.Next = newNode;
                //新节点指向当前节点
                newNode.Next = currentNode;
            }
        }
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() {
            return head == null;
        }
        /// <summary>
        /// 返回所要查找的数据位置索引
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Locate(T value) {
            Node<T> temp=head;
            int index = 0;
            if (temp == null) return -1;
            else {
                while (true) {
                    if(temp.Data.Equals(value)){
                        return index;
                    }
                    else {
                        if (temp.Next != null) {
                            temp = temp.Next;
                            index++;
                        }
                        else {
                            break;
                        }
                    }
                }
                return -1;
            }
        }
    }
}
