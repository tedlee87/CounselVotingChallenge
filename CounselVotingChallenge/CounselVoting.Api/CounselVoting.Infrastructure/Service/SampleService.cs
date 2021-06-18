using CounselVoting.Domain.Model;
using CounselVoting.Infrastructure.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace CounselVoting.Infrastructure.Service
{
    public interface ISampleService
    {
        SampleModel Insert(SampleModel model);
        SampleModel Update(long id, SampleModel model);
        SampleModel Delete(long id);
        SampleModel Get(long id);
        IQueryable<SampleModel> Get();
        void Dispose();
    }

    public class SampleService : ISampleService, IDisposable
    {
        private readonly ILogger<SampleService> logger;
        private readonly ISampleRepository repository;

        public SampleService(
            ILogger<SampleService> logger,
            ISampleRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        public SampleModel Insert(SampleModel model)
        {
            return repository.Insert(model);
        }

        public SampleModel Update(long id, SampleModel model)
        {
            return repository.Update(id, model);
        }

        public SampleModel Delete(long id)
        {
            return repository.Delete(id);
        }

        public SampleModel Get(long id)
        {
            return repository.Get(id);
        }

        public IQueryable<SampleModel> Get()
        {
            return repository.Get();
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}