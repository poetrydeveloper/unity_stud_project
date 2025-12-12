using CodeBase.Services.Input;
using Unity.Android.Gradle.Manifest;

namespace CodeBase.Infrastructure
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public BootstrapState(GameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public static IInputService InputService;
        public void Enter()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            // 1. Создаем сервис
            IInputService inputService = RegisterInputService();
            
            // 2. Регистрируем его в глобальном классе Game
            Game.InputService = inputService;
        }

        public void Exit()
        {
            
        }
        
        private static IInputService RegisterInputService()
        {
            #if UNITY_EDITOR || UNITY_STANDALONE
                        return new StandaloneInputService();
            #else
                        return new MobileInputService();
            #endif
        }
    }
}