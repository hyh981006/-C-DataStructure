using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
     public interface IListDS<T>
    {
        /// <summary>
        /// 求相关数组/链表长度
        /// </summary>
        /// <returns></returns>
        int GetLength();
        /// <summary>
        /// 清空数据操作
        /// </summary>
        void Clear();
        /// <summary>
        ///  //判断线性表是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
        /// <summary>
        /// 添加数据操作
        /// </summary>
        /// <param name="item">数据域</param>
        void Add(T item);
        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        void Insert(T item, int i);
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="i">删除的位置下标</param>
        /// <returns></returns>
        T Delete(int i); 
        /// <summary>
        /// 获取表元
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        T GetElem(int i);
        /// <summary>
        /// 定义一个索引器 获取元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; }
        /// <summary>
        /// 按值查找
        /// </summary>
        /// <param name="value">数据</param>
        /// <returns>返回索引下标</returns>
        int Locate(T value);
    }
}
