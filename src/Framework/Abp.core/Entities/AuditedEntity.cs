using System;
using Abp.Entities.Core;

namespace Abp.Entities
{
    /// <summary>
    /// This class can be used to simplify implementing IAudited.
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class AuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, IAudited
    {
        /// <summary>
        /// Creation date of this entity.
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Creator user of this entity.
        /// </summary>
        public virtual User Creator { get; set; }

        /// <summary>
        /// Last modification date of this entity.
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Last modifier user of this entity.
        /// </summary>
        public virtual User LastModifier { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        protected AuditedEntity()
        {
            CreationTime = DateTime.Now;
        }
    }

    public abstract class AuditedEntity : AuditedEntity<int>
    {
        
    }
}