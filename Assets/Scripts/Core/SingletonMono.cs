using UnityEngine;

namespace Core {
public abstract class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    private bool _initialized;

    protected abstract void AwakeForSingleton();

    public static T I
    {
        get
        {
            // Returns the instance if existed.
            if (_instance)
            {
                return _instance;
            }

            // Find the singleton in the scene. If not found, it means the application quits.
            _instance = (T)FindObjectOfType(typeof(T), true);
            if (!_instance)
            {
                return null;
            }

            // Try initialize it.
            _instance.GetComponent<SingletonMono<T>>().TryInit();
            return _instance;
        }
    }

    private void Awake()
    {
        TryInit();
    }

    private void TryInit()
    {
        if (!_initialized)
        {
            AwakeForSingleton();
            _initialized = true;
        }
    }
}
}