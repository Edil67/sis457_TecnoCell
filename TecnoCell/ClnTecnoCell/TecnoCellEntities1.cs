using System;

namespace ProductoCln
{
    internal class TecnoCellEntities : IDisposable
    {
        public object Producto { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}