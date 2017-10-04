using CEM.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEM.Services.Interfaces
{
    public interface ISYService
    {
        ICollection<SYViewModel> GetAll();
    }
}
