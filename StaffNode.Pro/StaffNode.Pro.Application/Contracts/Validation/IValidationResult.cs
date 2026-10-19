using System;
using System.Collections.Generic;
using System.Text;

namespace StaffNode.Pro.Application.Contracts.Validation
{
    public interface IValidationResult
    {
        bool IsValid { get;}
        List<string> Errors { get; }
    }
}
