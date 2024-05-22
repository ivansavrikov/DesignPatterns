using Patterns.Core.Interfaces;

namespace Patterns.Core.Adapter
{
    internal class Aug : LegacyAug, IScopable
    {
        public void Scope()
        {
            OpenScope();
        }
    }
}
