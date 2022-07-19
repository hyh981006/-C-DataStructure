using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeqList<string> seqList = new SeqList<string>();
            seqList.Add("计算机学院");
            seqList.Add("软件学院");
            seqList.Add("艺术学院");
            for (int i = 0; i < seqList.GetLength(); i++) {
                Console.WriteLine("数据{0}:{1}", i, seqList[i]);
            }
            Console.WriteLine("顺序表长度:"+seqList.GetLength());
            Console.WriteLine("顺序表中第一个数值:" + seqList.GetElem(0));
            Console.WriteLine("删除顺序表中第二个数据:"+seqList.Delete(2));
            Console.WriteLine("顺序表长度:" + seqList.GetLength());
            seqList.Insert("工程学院", 1);
            for (int i = 0; i < seqList.GetLength(); i++) {
                Console.WriteLine("添加完后的数据{0}个:{1}", i, seqList[i]);
            }
            Console.WriteLine("顺序表长度:" + seqList.GetLength());
            Console.WriteLine("数据所在位置:"+seqList.Locate("艺术学院")+"【注：-1代表未查询到】");
            Console.WriteLine("---------------------------------------------------------------------");
            LinkList<string> nodeList = new LinkList<string>();
            nodeList.Add("计算机科学与技术");
            nodeList.Add("软件工程");
            nodeList.Add("自动化");
            for (int i = 0; i < nodeList.GetLength(); i++)
            {
                Console.WriteLine("数据{0}:{1}", i, nodeList[i]);
            }
            Console.WriteLine("单链表长度:" + nodeList.GetLength());
            Console.WriteLine("单链表中第一个数值:" + nodeList.GetElem(0));
            Console.WriteLine("删除单链表中第二个数据:" + nodeList.Delete(2));
            Console.WriteLine("单链表长度:" + nodeList.GetLength());
            nodeList.Insert("艺术与实践", 1);
            for (int i = 0; i < nodeList.GetLength(); i++)
            {
                Console.WriteLine("添加完后的数据{0}个:{1}", i, nodeList[i]);
            }
            Console.WriteLine("单链表长度:" + nodeList.GetLength());
            Console.WriteLine("数据所在位置:" + nodeList.Locate("软件工程") + "【注：-1代表未查询到】");
            Console.WriteLine("---------------------------------------------------------------------");
            DoubleLinkList<string> doubleLinkList = new DoubleLinkList<string>();
            doubleLinkList.Add("王者荣耀");
            doubleLinkList.Add("和平精英");
            doubleLinkList.Add("多多自走棋");
            for (int i = 0; i < doubleLinkList.GetLength(); i++)
            {
                Console.WriteLine("数据{0}:{1}", i, doubleLinkList[i]);
            }
            Console.WriteLine("Add后==>双链表长度:" + doubleLinkList.GetLength());
            doubleLinkList.Clear();
            Console.WriteLine("Clear后==>双链表长度:" + doubleLinkList.GetLength());
            Console.ReadLine();
        }
    }
}
