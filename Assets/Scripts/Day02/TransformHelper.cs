using UnityEngine;

/// <summary>
/// 变换组件助手类，无需继承MonoBehaviour
/// </summary>
public class TransformHelper
{
    public static Transform GetChild(Transform parentTF, string childName)
    {
        Transform childTF = parentTF.Find(childName);
        if (childTF != null) return childTF;

        int count = parentTF.childCount;
        for (int i = 0; i < count; i++)
        {
            childTF = GetChild(parentTF.GetChild(i), childName);
            if (childTF != null) return childTF;
        }
        return null;
    }
}