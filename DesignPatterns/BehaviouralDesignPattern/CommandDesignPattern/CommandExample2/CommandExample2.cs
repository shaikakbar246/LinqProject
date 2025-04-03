using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.DesignPatterns.BehaviouralDesignPattern.CommandDesignPattern.CommandExample2
{
    public class CommandExample2
    {
        static void Main(string[] args)
        {
            var tv = new Tv();

            var tvOncommand = new TvOnCoomand(tv);
            var tvOfCommand = new TvOfCoomand(tv);
            var remote = new RemoteController();
            remote.SetCommand(tvOncommand);
            remote.PressOButton();
            remote.SetCommand(tvOfCommand);
            remote.PressOFButton();
            Console.ReadLine();

        }

        public interface ICommand
        {
            void Execute();
        }

        public class Tv
        {
            public void TvOn()
            {
                Console.WriteLine("Tv on");
            }
            public void TvOff()
            {
                Console.WriteLine("Tv Of");
            }
        }
        public class TvOnCoomand : ICommand
        {
            private Tv _tv;
            public TvOnCoomand(Tv tv)
            {
                _tv = tv;
            }
            public void Execute()
            {
                _tv.TvOn();
            }
        }
        public class TvOfCoomand : ICommand
        {
            private Tv _tv;
            public TvOfCoomand(Tv tv)
            {
                _tv = tv;
            }
            public void Execute()
            {
                _tv.TvOff();
            }
        }

        public class RemoteController
        {
            private ICommand _command;
            public void SetCommand(ICommand command)
            {
                _command = command;

            }
            public void PressOButton()
            {
                _command.Execute();
            }
            public void PressOFButton()
            {
                _command.Execute();
            }
        }
    }
}
