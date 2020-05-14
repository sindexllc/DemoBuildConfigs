using UnityEngine;
using System.Collections.Generic;

public class PlatformDependent : MonoBehaviour
{
    public List<RuntimePlatform> showInPlatforms;

    private void Awake()
    {
        gameObject.SetActive(showInPlatforms.Contains(Application.platform));
    }
}
