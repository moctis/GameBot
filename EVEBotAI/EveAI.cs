namespace EVEBotAI
{
    using System;

    using EveEnv;

    public abstract class EveAI : IEveAI
    {
        public string PlayerName { get; set; }

        public EveClient Client
        {
            get
            {
                return Env.EveClients[this.PlayerName];
            }
        }
         
        public abstract void Process();

        public static MoveCargoAi CreateMoveCargo(string playerName)
        {
            return new MoveCargoAi {PlayerName = playerName};
        }
    }

    public interface IEveAI
    { 
        void Process();
    }
}