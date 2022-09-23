using Infrastructure.BusinessObject;
using Infrastructure.Entities;
using Infrastructure.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class ReaderService : IReaderService
    {
        private IApplicationUnitofWork _work;
        public ReaderService(IApplicationUnitofWork work)
        {
            _work = work;
        }
        public void CreateReader(BReader bReader)
        {
            Reader reader = new Reader();
            reader.Name = bReader.Name;
            reader.Address = bReader.Address;

            _work.readerRepository.Add(reader);
            _work.Save();
        }
    }
}
