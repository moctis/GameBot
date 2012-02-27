namespace EVEBotAI
{
    using System;

    using EveEnv;

    public class MoveCargoAi : EveAI
    {
        public override void Process()
        {
            var myCargo = Client.Windows.MyCargo;
            var corpHanger = Client.Windows.CorpHanger;

            if (myCargo.HasItem())
            {
                myCargo.MoveTo(corpHanger);
            }
        }
    }
}