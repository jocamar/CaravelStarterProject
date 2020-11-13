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
            //You can inherit from this class if you want to override some of the methods but most times just the base game logic is fine
            return new Cv_GameLogic(this);
        }

        protected override Cv_GamePhysics VCreateGamePhysics()
        {
            return new Cv_VelcroPhysics(this);
        }

        protected override Cv_GameView[] VCreateGameViews()
        {
            //Create a default player view that occupies the entire screen starting at pos 0,0
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
            //Do any loading and initialization logic here then send the game to load state
            Logic.ChangeState(Cv_GameLogic.Cv_GameState.LoadingScene);
            return true;
        }

        protected override bool VLoadGame()
        {
            //Load our first scene
            var loadProcess = new Cv_LoadSceneProcess("testScene.cvs", "Default", "Example Scene");
            ProcessManager.AttachProcess(loadProcess);
            return true;
        }
    }
}