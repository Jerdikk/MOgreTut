//using Ogre;

namespace MOgreTut
{
    public class MyOgreLevel
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public MyOgreScene Scene { get; set; }
        public MyOgreLevel() 
        {
            Scene = new MyOgreScene();
        }
    }
}
