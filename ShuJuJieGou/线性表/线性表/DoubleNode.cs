using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    /// <summary>
    /// 双链表实现
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    class DoubleNode<T>{
        private T data;//数据域
        private DoubleNode<T> previous;//前驱引用域==>指向上一个结点
        private DoubleNode<T> next;//后驱引用域==>指向下一个结点

        public T Data { get => data; set => data = value; }
        internal DoubleNode<T> Previous { get => previous; set => previous = value; }
        internal DoubleNode<T> Next { get => next; set => next = value; }

        public DoubleNode(T value, DoubleNode<T> previous,DoubleNode<T> next){
            this.data = value;
            this.previous = previous;
            this.next = next;
        }
        /// <summary>
        /// 考虑到有可能是在末尾，则没有next，所以应该有next为空的构造方法
        /// </summary>
        /// <param name="value"></param>
        /// <param name="previous"></param>
        public DoubleNode(T value, DoubleNode<T> previous)
        {
            this.data = value;
            this.previous = previous;
            this.next = null;
        }
        public DoubleNode(T value, DoubleNode<T> next)
        {
            this.data = value;
            this.previous = null;
            this.next = next;
        }
        public DoubleNode(DoubleNode<T> previous,DoubleNode<T> next)
        {
            this.next = next;
            this.previous = previous;
        }
        public DoubleNode(T value)
        {
            data = value;
            next = null;
            previous = null;
        }
        public DoubleNode()
        {
            data = default(T);
            previous = null;
            next = null;
        }
    }
}
