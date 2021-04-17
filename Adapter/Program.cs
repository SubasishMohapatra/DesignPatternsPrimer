using System;
using System.Runtime.ExceptionServices;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IWesternPlug westernPlug = new WesternPlug();
            westernPlug.FitIntoWesternSocket();
            IWesternPlug adapter = new Adapter(new IndianPlug());
            adapter.FitIntoWesternSocket();
        }

        class WesternPlug : IWesternPlug
        {
            public void FitIntoWesternSocket()
            {
                Console.WriteLine("Western plug fitted into western socket");
            }
        }

        class IndianPlug : IIndianPlug
        {
            public void FitIntoIndianSocket()
            {
                Console.Write("Indian plug fitted");
            }
        }

        class Adapter : IWesternPlug
        {
            IndianPlug _indianPlug;
            public Adapter(IndianPlug indianPlug)
            {
                _indianPlug = indianPlug;
            }

            public void FitIntoWesternSocket()
            {
                _indianPlug?.FitIntoIndianSocket();
                Console.WriteLine(" into an western socket");
            }
        }
    }

    interface IWesternPlug
    {
        void FitIntoWesternSocket();
    }
    interface IIndianPlug
    {
        void FitIntoIndianSocket();
    }
}
