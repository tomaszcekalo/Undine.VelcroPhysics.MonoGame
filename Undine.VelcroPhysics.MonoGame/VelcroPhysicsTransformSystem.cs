using Undine.Core;
using Undine.MonoGame;
using VelcroPhysics.Utilities;

namespace Undine.VelcroPhysics.MonoGame
{
    public class VelcroPhysicsTransformSystem : UnifiedSystem<VelcroPhysicsComponent, TransformComponent>
    {
        public override void ProcessSingleEntity(int entityId,
            ref VelcroPhysicsComponent a,
            ref TransformComponent b)
        {
            b.Position = ConvertUnits.ToDisplayUnits(a.Body.Position);
            b.Rotation = a.Body.Rotation;
        }
    }
}