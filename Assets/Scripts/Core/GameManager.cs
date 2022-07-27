using UnityEngine;

namespace Core
{
    public class GameManager : SingletonMono<GameManager>
    {
        [SerializeField] private bool isQuitting;

        public static bool IsQuitting => I == null || I.isQuitting;

        protected override void AwakeForSingleton()
        {
            Application.quitting += MarkQuitting;
        }

        private void MarkQuitting()
        {
            isQuitting = true;
        }
    }
}