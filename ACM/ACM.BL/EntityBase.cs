using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        // CHecks if the object is new 
        public bool IsNew { get; private set; }
        // Checks if there has been changes 
        public bool HasChanges { get; set; }
        // Check if the item is active or deleted
        public EntityStateOption EntityState { get; set; }
        // Checks if the current data is valid
        public bool Isvalid
        {
            get { return Validate(); }
        }

        // Abstract, doesnt have an implmentation
        public abstract bool Validate();
    }
}
