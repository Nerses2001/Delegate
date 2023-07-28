using System;

namespace Delegate
{
    internal class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            MyDelegate myDelegate = new MyDelegate(MyClass.Mtehod1);
            myDelegate.Invoke();
            myDelegate();

            MyDelegateString myStringDelegate = new MyDelegateString(myClass.StringReturnMehode);
            myStringDelegate.Invoke("5484135adasads6a+5d");
            myStringDelegate("5484135adasads6a+5d");
            string a = myStringDelegate.Invoke("5484135adasads6a+5d");
            Console.WriteLine(a);
            MyDelegate myDelegate1 = new MyDelegate(MyClass.Mtehod1);
            MyDelegate myDelegate2 = new MyDelegate(MyClass.Method2);
            MyDelegate myDelegate3 = new MyDelegate(MyClass.Method3);
            MyDelegate my = myDelegate1 + myDelegate2 + myDelegate3;

            string choise = Console.ReadLine();


            switch (choise) 
            {
                case "1":
                    {
                        myDelegate1.Invoke();
                        break;
                    }
                case "2":
                    {
                        myDelegate2.Invoke();
                        break;
                    }
                case "3":
                    {
                        myDelegate3.Invoke();
                        break;
                    }
                case "4":
                    {
                        MyDelegate myDelegate4 = my - myDelegate1;
                        myDelegate4.Invoke();
                        break;
                    }
                case "5":
                    {
                        MyDelegate myDelegate5 = my - myDelegate2;
                        myDelegate5.Invoke();
                        break;
                    }
                case "6":
                    {
                        MyDelegate myDelegate6 = my - myDelegate3;
                        myDelegate6.Invoke();
                        break;
                    }
                case "7":
                    {
                        my.Invoke();
                        break;
                    }
                    
            }

            Console.ReadKey();

        }
    }
}
