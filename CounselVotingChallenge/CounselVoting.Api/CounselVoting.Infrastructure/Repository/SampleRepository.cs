using CounselVoting.Domain.Model;
using CounselVoting.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CounselVoting.Infrastructure.Repository
{
    public interface ISampleRepository
    {
        SampleModel Insert(SampleModel model);
        SampleModel Update(long id, SampleModel model);
        SampleModel Delete(long id);
        SampleModel Get(long id);
        IQueryable<SampleModel> Get();
        void Dispose();
    }

    public class SampleRepository : ISampleRepository, IDisposable
    {
        private readonly CounselContext _context;
        private readonly DbSet<SampleModel> _dbSet;

        public SampleRepository()
        {
            _context = new CounselContext();
            _dbSet = _context.Sample;
        }

        public SampleModel Insert(SampleModel model)
        {
            _dbSet.Add(model);
            _context.SaveChanges();
            return model;
        }

        public SampleModel Update(long id, SampleModel model)
        {
            var found = _dbSet.Find(id);
            if (found != null)
            {
                found.Text = model.Text;

                _dbSet.Update(found);
                _context.SaveChanges();
                return found;
            }

            return null;
        }

        public SampleModel Delete(long id)
        {
            var found = _dbSet.Find(id);
            if (found != null)
            {
                _dbSet.Remove(found);
                _context.SaveChanges();
                return found;
            }

            return null;
        }

        public SampleModel Get(long id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<SampleModel> Get()
        {
            return _dbSet;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}