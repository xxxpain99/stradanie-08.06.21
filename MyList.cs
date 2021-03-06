using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
	class MyList <T>
	{
		public void Add(T value)
		{
			Node<T> asd = new Node<T>();
			asd.value = value;
			if (firstElement == null)
			{
				firstElement = asd;
			}
			else
			{
				GetLast().next = asd;
			}


		}
		Node<T> firstElement;

		Node<T> GetLast() 
		{
			Node<T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		public void Print()
		{
			Node<T> last = GetFirst();
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;

			}
		}
		public void AddFront(T value) // выводит предыдущий элемент
		{
			Node<T> rtd = new Node<T>();
			rtd.value = value;

			if (firstElement == null)
			{
				firstElement = rtd;
			}
			else
			{
				rtd.next = GetFirst();
				rtd.next.prev = rtd;
			}
		}
		Node<T> GetFirst()

		{
			Node<T> last = firstElement;

			while (last.prev != null)
			{
				last = last.prev;
			}
			return last;
		}
		
		public T Get (int index) // dobvlyaet noviy element v konec spiska
		{

		}



		public void PushBack (T value) // dobavlyaet noviy element v nachalo spiska
		{
			Node<T> psh = new Node<T>();
			psh.value = value;
		}



		public void PushFront( T value) // polu4it' posledniy element spiska
		{
			Node<T> pshfr = new Node<T>();
			pshfr.value = value;
		}



		public void PrintForward() //vivesti znacheniya vsego spiska v obratnom poryadke
		{
			MyList<int> list = new MyList<int>();
			list.PushBack(3);
			list.PushBack(4);
			list.PushBack(5);
			list.PushBack(8);

			list.PushFront(99);
			list.PushFront(98);
			list.PushFront(97);

			Console.WriteLine("Print forward");
			list.PrintForward();

			Console.WriteLine("\nPrint backward");
			list.PrintBackward();
		}




		public void PrintBackward()
		{
			
		}
	}
}
