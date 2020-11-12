using System;

namespace SajithLakjaya.DncBoilerplate.Core.Domain
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}
