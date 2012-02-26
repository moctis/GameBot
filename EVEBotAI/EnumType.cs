using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVEBotAI
{
    using EveEnv;

    public enum LocationType
    {
        Space,
        Station,
    }



    public class Ship
    {
        public CargoWindow MyCargo { get; set; }


    }
    

    public class ContainerWindow : Window
    {
        
    }

    public class CargoWindow : ContainerWindow
    {
        public bool HasItem()
        {
            throw new NotImplementedException();
        }
    }
     

    public class Test
    {
     
        void test ()
        {
            var list = this.Space.Overview.Cargo;
        }

        protected Space Space { get; set; }
    }

    public class Space
    {
        public Overview Overview { get; set; }
    }

    public class Overview : Window
    {
        public Tab Cargo;
    }

    public class Tab
    {

    }

    public class Window
    {        
        public void MoveTo(Window target)
        {
            throw new NotImplementedException();
        }
    }

    public class Station
    {
        public void Dock()
        {
            
        }
    }

   


    public class Undock : Command
    {
        public override void Execute()
        {
            
        }

        public override void UnExecute()
        {
            
        }
    }

    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
