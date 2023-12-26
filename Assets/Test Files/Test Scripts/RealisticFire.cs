using UnityEngine;
public class RealisticFire : MonoBehaviour
{
    public ParticleSystem fireParticles;
    public Material fireMaterial;
    void Start()
    {
        // Attach a custom shader to the fire material for realistic flame effects
        fireMaterial.shader = Shader.Find("Custom/FireShader");
    }
}
