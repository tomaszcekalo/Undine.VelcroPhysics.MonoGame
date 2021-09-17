using Undine.Core;

namespace Undine.VelcroPhysics.MonoGame
{
    public class RotationFromJointSystem : UnifiedSystem<JointComponent, VelcroPhysicsComponent>
    {
        public override void ProcessSingleEntity(int entityId,
            ref JointComponent a, ref VelcroPhysicsComponent b)
        {
            b.Body.Rotation = a.Joint.BodyA.Rotation;
        }
    }
}