using Caravel;
using Caravel.Core;
using Caravel.Core.Physics;
using Caravel.Core.Process;
using Microsoft.Xna.Framework;

namespace MyNewGame
{
    public class MyNewGameApp : CaravelApp
    {
        public MyNewGameApp(int screenWidth, int screenHeight, bool allowWindowResize = false) : base(screenWidth, screenHeight, allowWindowResize)
        {
            UseDevelopmentDirectories = true;
        }

        protected override bool VCheckGameSystemResources()
        {
            return true;
        }

        protected override Cv_GameLogic VCreateGameLogic()
        {
            return new Cv_GameLogic(this);
        }

        protected override Cv_GamePhysics VCreateGamePhysics()
        {
            return new Cv_VelcroPhysics(this);
        }

        protected override Cv_GameView[] VCreateGameViews()
        {
            var pv = new Cv_PlayerView(Cv_Player.One, Vector2.One, Vector2.Zero);
            return new Cv_GameView[] { pv };
        }

        protected override string VGetGameAppDirectoryName()
        {
            return "starter_project";
        }

        protected override string VGetGameTitle()
        {
            return "MyNewGame";
        }

        protected override bool VInitialize()
        {
            //Logic.ChangeState(Cv_GameLogic.Cv_GameState.LoadingScene);
            return true;
        }

        protected override bool VLoadGame()
        {
            /*
            var loadProcess = new Cv_LoadSceneProcess("Some Scene", "Default", "Scene Name Here");
            ProcessManager.AttachProcess(loadProcess);
            */
            return true;
        }
    }
}