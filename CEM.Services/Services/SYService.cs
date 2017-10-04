using CEM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CEM.Core.Models;
using CEM.Core.Entities;
using CEM.Repositories;

namespace CEM.Services
{
    public class SYService : ISYService
    {
        private readonly IRepository<SY> _repository;

        public SYService(IRepository<SY> repository)
        {
            _repository = repository;
        }

        public ICollection<SYViewModel> GetAll()
        {
            _repository.GetAll();

            return new List<SYViewModel>();
        }
    }
}
