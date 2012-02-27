using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using SystemLib;

namespace EveEnv
{
    using System.Collections.Generic;

    public class EveClient : BaseEveClient, IEnvObject
    {
        private readonly Process _process;
 
        public EveClient(Process process)
        {
            _process = process;
            var title = process.MainWindowTitle;
            PilotName = title.Length > 6 ? title.Remove(0, 6) : string.Empty;

            Screen = new EveScreen(process);
            Windows = new EveWindowList(Screen.Location);
        }
 

        public string PilotName { get; set; }

        public EveScreen Screen { get; set; }

        public EveWindowList Windows { get; set; }

    }

    public class EveWindowList
    {
        public EveWindowList(AiPoint parent)
        {
            FloatingCargo = new CargoWindow(parent); 

            MyCargo = new CargoWindow(parent);
            MyCargo.Location.Delta.X = 32;
            MyCargo.Location.Delta.Y = 337;

            CorpHanger = new CorpHangerWindow(parent);
            CorpHanger.Location.Delta.X = 32;
            CorpHanger.Location.Delta.Y = 142;

        }
        public CargoWindow FloatingCargo { get; set; }

        public CargoWindow MyCargo { get; set; }

        public CorpHangerWindow CorpHanger { get; set; }
    }

    public class CorpHangerWindow : CargoWindow
    {
        public CorpHangerWindow(AiPoint parent) : base(parent)
        {
            ItemLocation.Delta = new AiPoint(23, 138);
        }
    }

    public class CargoWindow : EveWindow
    {
        public AiPoint Location { get; set; }
        public AiPoint ItemLocation { get; set; }

        public CargoWindow(AiPoint parent)
        {
            Location = new AiPoint(parent, 0, 0);
            ItemLocation = new AiPoint(Location, 23, 113);
        }

        public void MoveTo(CargoWindow win)
        {
            var p1 = ItemLocation;
            var p2 = win.ItemLocation;
            Mouse.DragDrop(p1, p2, 1000);
        }
    }

    public class EveWindow
    {
        public bool HasItem()
        {
            //todo: check HasItem
            return true;
        }
    }


    public class AiPoint 
    {
        public string Name { get; set; }
        private int _x;
        public int X
        {
            get { return IsGlobal ? _x : Parent.X + Delta.X; }
            set
            {
                _x = value;
                if (!IsGlobal) Delta.X = value - Parent.X;
            }
        }

        private int _y;

        public AiPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public AiPoint(AiPoint parent, int x, int y)
        {
            Parent = parent;
            Delta = new AiPoint(x, y);
        }

        public int Y
        {
            get { return IsGlobal ? _y : Parent.Y + Delta.Y; }
            set
            {
                _y = value;
                if (!IsGlobal) Delta.Y = value - Parent.Y;
            }
        }

        public AiPoint Delta { get; set; }
        public AiPoint Parent { get; set; }
        private bool IsGlobal { get { return Parent == null || Delta == null; } }

        public static implicit operator Point(AiPoint p)
        {
            return new Point(p.X, p.Y);
        }
    }
}
