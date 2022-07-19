using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    /// <summary>
    /// 顺序表实现方式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqList<T> : IListDS<T>
    {
        public T[] data;//用来存储数据
        private int count=0;//表示存了多少个数据
        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }
        /// <summary>
        /// 默认构造函数容量为10
        /// </summary>
        public SeqList() : this(10) { }
        public T this[int index]
        {
            get { return GetElem(index); }
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            //说明数据组已经存满
            if (count == data.Length){
                Console.WriteLine("当前顺序表已经存满，不允许在存入数据");
            }
            else {
                data[count] = item;
                count++;
            }
        }
        /// <summary>
        /// 清空数据
        /// </summary>
        public void Clear() {
            count = 0;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Delete(int index) {
            T temp=data[index];
            for (int i = index+1; i < count; i++) {
                data[i - 1] = data[i];
            }
            count--;
            return temp;
        }
        /// <summary>
        /// 根据索引获取数据
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetElem(int i){
            //若索引存在
            if (i >= 0 && i <= count - 1) {
                return data[i];
            }
            else {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }
        /// <summary>
        /// 取到的数据大小
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetLength() {
            return count;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="item">数据</param>
        /// <param name="index">下标索引</param>
        public void Insert(T item, int index) {
            for (int i = count-1; i>=index; i--) {
                data[i+1]=data[i];
            }
            data[index] = item;
            count++;
        }
        //清空数据
        public bool IsEmpty() {
            return count == 0;
        }
        /// <summary>
        /// 返回所要查找的数据位置索引
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Locate(T value) {
            for (int i = 0; i < count; i++) {
                if (data[i].Equals(value)) {
                    return i;
                }
            }
            return -1;
        }
    }
}
