using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

namespace Core
{
    // TODO: delete this class and add LoadBattleScene in GameManager.
    public class SceneLoader : SingletonMono<SceneLoader>
    {
        protected override void AwakeForSingleton()
        {
        }
        
        [Button]
        private void LoadBattleScene()
        {
            Assert.IsTrue(Application.isPlaying, "Must be in play mode when changing scene.");
            
            SceneManager.LoadScene("BattleScene");
        }
    }
}