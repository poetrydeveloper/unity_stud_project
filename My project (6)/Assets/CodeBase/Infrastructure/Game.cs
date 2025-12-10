using CodeBase.Services.Input;
using Unity.Android.Gradle.Manifest;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game()
        {
            RegisterInputService();
        }

        private static void RegisterInputService()
        {
            #if UNITY_EDITOR
                        InputService = new StandaloneInputService();
            #else
                        InputService = new MobileInputService();
            #endif
        }
    }
}