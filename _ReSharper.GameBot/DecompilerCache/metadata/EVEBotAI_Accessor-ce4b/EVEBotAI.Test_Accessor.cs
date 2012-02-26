// Type: EVEBotAI.Test_Accessor
// Assembly: EVEBotAI_Accessor, Version=0.0.0.0, Culture=neutral
// Assembly location: D:\My Projects\GameBot\TestProject1\obj\Debug\EVEBotAI_Accessor.dll

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Runtime.InteropServices;

namespace EVEBotAI
{
    [Shadowing("EVEBotAI.Test")]
    public class Test_Accessor : BaseShadow
    {
        #region Constants and Fields

        protected static PrivateType m_privateType;

        #endregion

        #region Constructors and Destructors

        public Test_Accessor([In] PrivateObject obj0);

        [Shadowing(".ctor@0")]
        public Test_Accessor();

        #endregion

        #region Properties

        public static PrivateType ShadowedType { get; }

        [Shadowing("Space")]
        public object Space { [Shadowing("get_Space@0")]
        get; [Shadowing("set_Space@1")]
        set; }

        #endregion

        #region Public Methods

        public static Test_Accessor AttachShadow([In] object obj0);

        [Shadowing("test@0")]
        public void test();

        #endregion
    }
}
