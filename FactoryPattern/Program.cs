using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new DotNetResourceFacory().GetProfessional().SayHi();
            new JavaResourceFacory().GetProfessional().SayHi();
        }
    }

    public interface IResource
    {
        void SayHi();
    }

    public interface IResourceFactory
    {
        public IResource GetProfessional();
    }

    public class DotNetResourceFacory : IResourceFactory
    {
        public IResource GetProfessional()
        {
            return new DotNetResource();
        }
    }

    public class JavaResourceFacory : IResourceFactory
    {
        public IResource GetProfessional()
        {
            return new JavaResource();
        }
    }

    public class DotNetResource : IResource
    {
        public void SayHi()
        {
            Console.WriteLine("Hi !!! I am a dotnet resource");
        }
    }

    public class JavaResource : IResource
    {
        public void SayHi()
        {
            Console.WriteLine("Hi !!! I am a java resource");
        }
    }
}
