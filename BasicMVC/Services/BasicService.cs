namespace BasicMVC.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BasicMVC.Entities;
    using BasicMVC.Repository;

    public class BasicService : IBasicService
    {
        private readonly IBasicRepository _basicRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BasicService(IBasicRepository basicRepository, IUnitOfWork unitOfWork)
        {
            _basicRepository = basicRepository;
            _unitOfWork = unitOfWork;
        }

        public bool BasicFunction()
        {
            return true;
        }
    }
}
