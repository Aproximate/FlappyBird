using UnityEngine;

public class LayerSetter : MonoBehaviour
{
    public void SetLayer(string layerName)
    {
        gameObject.layer = LayerMask.NameToLayer(layerName);
    }
}