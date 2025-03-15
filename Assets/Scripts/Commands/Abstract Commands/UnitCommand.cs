using System.Windows.Input;
using Command.Player;
using UnityEngine;

namespace Command.Commands
{
    public abstract class UnitCommand : ICommand
    {
        public int actorUnitID;
        public int TargetUnitID;
        public int ActorPlayerID;
        public int TargetPlayerID;

        protected UnitController actorUnit;
        protected UnitController targetUnit;

        public abstract void Execute();

        public abstract bool WillHitTarget();
    }
}