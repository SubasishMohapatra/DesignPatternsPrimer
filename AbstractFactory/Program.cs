using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new SoftwareDeveloperFactory().GetDotNetProfessional().GetDeskTopDevelopers().SayHi();
            new SoftwareDeveloperFactory().GetDotNetProfessional().GetWebDevelopers().SayHi();
            new SoftwareDeveloperFactory().GetDotNetProfessional().GetMobileDevelopers().SayHi();
            new SoftwareDeveloperFactory().GetJavaProfessional().GetDeskTopDevelopers().SayHi();
            new SoftwareDeveloperFactory().GetJavaProfessional().GetMobileDevelopers().SayHi();
            new SoftwareDeveloperFactory().GetJavaProfessional().GetWebDevelopers().SayHi();
        }
    }

    class SoftwareDeveloperFactory : ISoftwareDeveloperFactory
    {
        public IDotNetFactory GetDotNetProfessional()
        {
            return new DotNetFactory();
        }

        public IJavaFactory GetJavaProfessional()
        {
            return new JavaFactory();
        }
    }

    interface IDotNetFactory
    {
        IDesktopDeveloper GetDeskTopDevelopers();
        IWebDeveloper GetWebDevelopers();
        IMobileDeveloper GetMobileDevelopers();
    }

    public class DotNetFactory : IDotNetFactory
    {
        public IDesktopDeveloper GetDeskTopDevelopers()
        {
            return new DotNetDesktopDeveloper();
        }

        public IMobileDeveloper GetMobileDevelopers()
        {
            return new DotNetMobileDeveloper();
        }

        public IWebDeveloper GetWebDevelopers()
        {
            return new DotNetWebDeveloper();
        }
    }

    public interface IWebDeveloper
    {
        void SayHi();
    }

    public interface IMobileDeveloper
    {
        void SayHi();
    }

    public interface IDesktopDeveloper
    {
        void SayHi();
    }

    interface IJavaFactory
    {
        IDesktopDeveloper GetDeskTopDevelopers();
        IWebDeveloper GetWebDevelopers();
        IMobileDeveloper GetMobileDevelopers();
    }

    public class JavaFactory : IJavaFactory
    {
        public IDesktopDeveloper GetDeskTopDevelopers()
        {
            return new JavaDesktopDeveloper();
        }

        public IMobileDeveloper GetMobileDevelopers()
        {
            return new JavaMobileDeveloper();
        }

        public IWebDeveloper GetWebDevelopers()
        {
            return new JavaWebDeveloper();
        }
    }
    public class DotNetDesktopDeveloper:IDesktopDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Dotnet desktop developer at your service sir");
        }
    }
    public class DotNetWebDeveloper : IWebDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Dotnet web developer at your service sir");
        }
    }
    public class DotNetMobileDeveloper : IMobileDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Dotnet mobile developer at your service sir");
        }
    }
    public class JavaDesktopDeveloper : IDesktopDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Java desktop developer at your service sir");
        }
    }
    public class JavaWebDeveloper : IWebDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Java web developer at your service sir");
        }
    }
    public class JavaMobileDeveloper : IMobileDeveloper
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!!! Java mobile developer at your service sir");
        }
    }

    interface ISoftwareDeveloperFactory
    {
        IDotNetFactory GetDotNetProfessional();
        IJavaFactory GetJavaProfessional();
    }
}
