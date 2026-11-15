
using UnityEngine;

public class SetSpaceBackground : MonoBehaviour
{
    public Material spaceMaterial;

    void Start()
    {
        RenderSettings.skybox = spaceMaterial;
        DynamicGI.UpdateEnvironment();
    }
}
