using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mogre;
using MogreNewt.CollisionPrimitives;
//using Ogre;



namespace MOgreTut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Root root = new Root();
            if (root.ShowConfigDialog())
            {
                RenderWindow window = root.Initialise(true, "MOgre3D");
                SceneManager sceneManager = root.CreateSceneManager(SceneType.ST_GENERIC);
                Camera camera = sceneManager.CreateCamera("Camera");
                camera.SetPosition(0, 0, 50);

                camera.LookAt(new Vector3(0, 0, 0));
                camera.NearClipDistance = 5.0f;

                Viewport viewport = window.AddViewport(camera);
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
