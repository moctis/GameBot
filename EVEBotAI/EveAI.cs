// sss
namespace EVEBotAI
{
    #region

    using EveEnv;

    #endregion

    public abstract class EveAI : IEveAI
    {
        #region Properties

        public EveClient Client
        {
            get
            {
                return Env.EveClients[this.PlayerName];
            }
        }

        public string PlayerName { get; set; }

        #endregion

        #region Public Methods

        public static MoveCargoAi CreateMoveCargo(string playerName)
        {
            return new MoveCargoAi { PlayerName = playerName };
        }

        #endregion

        #region Implemented Interfaces

        #region IEveAI

        public abstract void Process();

        #endregion

        #endregion
    }

    public class Test22
    {
        
    }
    public interface IEveAI
    {
        #region Public Methods

        void Process();

        #endregion
    }
}