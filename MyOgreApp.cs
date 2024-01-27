//using Ogre;

using Mogre;

namespace MOgreTut
{
    public class MyOgreApp
    {
        public MyOgreLevel ogreLevel;

        Root root;
        RenderWindow window;
        Viewport viewport;


        public MyOgreApp() 
        {
            ogreLevel = new MyOgreLevel();

            root = new Root();
            if (root.ShowConfigDialog())
            {
                window = root.Initialise(true, "MOgre3D");
                SceneManager sceneManager = root.CreateSceneManager(SceneType.ST_GENERIC);
                Camera camera = sceneManager.CreateCamera("Camera");
                camera.SetPosition(0, 0, 50);

                camera.LookAt(new Vector3(0, 0, 0));
                camera.NearClipDistance = 5.0f;

                viewport = window.AddViewport(camera);
                viewport.BackgroundColour = ColourValue.Black;

                camera.AspectRatio = (float)viewport.ActualWidth / (float)viewport.ActualHeight;

                ResourceGroupManager.Singleton.AddResourceLocation("Media/packs/Sinbad.zip", "Zip");
                ResourceGroupManager.Singleton.InitialiseAllResourceGroups();
                Entity ent = sceneManager.CreateEntity("Sinbad.mesh");
                sceneManager.RootSceneNode.AttachObject(ent);

                AxisAlignedBox axisAlignedBox = ent.BoundingBox;

                root.StartRendering();

            }
        }
    }
}
