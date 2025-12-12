//Game.cs
using CodeBase.Services.Input;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService { get; set; }
        public GameStateMachine _stateMashine;
        

        public Game()
        {
           _stateMashine =  new GameStateMachine(); 
        }
        
    }
}