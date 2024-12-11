using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
    // Start is called before the first frame update
    public class myClass
    {
        public int i;
        public int j;
        
    }
    public struct MyStruct
    {
        public struct name;
        public int age;
    }


    public class MyList<Titem>
    {
        private int[] array = new int[4];

        public int count { get; }

        public void Push(int i)
        {

        }

        public void Insert(int index, Titem item)
        {

        }
        public void Remove(Titem index)


        public void Clear() { }

        public void IndexOf(Titem item)
        {
            return;
        }

        public void RemoveAt(int index) { }

    }

    public void Test<T>(ref T i)
    {

    }

    void Start()
    {
        var ms = new myClass(); 
        var ms = new MyStruct();
        var ms2 = new MyStruct();
        ms = ms2;
        int i = 10;

        MyList<myClass> standartlist = new MyList<myClass>();

        Test<int>(ref i);
        myList<MyClass> myList = new MyList<MyListClass>();
        myList.Push(new myClass());

    }
}
