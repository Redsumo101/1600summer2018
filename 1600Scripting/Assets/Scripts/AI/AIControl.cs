using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIControl : ScriptableObject
{
    public float Speed;
    public float AngularSpeed;

    public void ConfigAI(NavMeshAgent agent)
    {
        agent.speed = Speed;
        agent.angularSpeed = AngularSpeed;
    }


}
