using Undine.Core;

namespace Undine.VelcroPhysics.MonoGame
{
    public class VelcroPhysicsSystem : UnifiedSystem<VelcroWorldComponent>
    {
        public float ElapsedGameTimeTotalSeconds { get; set; }
        public VelcroPhysicsSystem()
        {
        }

        public override void ProcessSingleEntity(int entityId, ref VelcroWorldComponent t)
        {
            t.World.Step(ElapsedGameTimeTotalSeconds);
        }
    }
}