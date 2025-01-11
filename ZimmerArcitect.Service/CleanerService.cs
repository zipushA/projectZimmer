using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.DTO;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;
using ZimmerArcitect.core.Services;

namespace ZimmerArcitect.Service
{
    public class CleanerService: IClenerService
    {
        private readonly ICleanerRepository _cleanerRepository;
        private readonly IMapper _mapper;
        public CleanerService(ICleanerRepository cleanerRepository, IMapper mapper)
        {
            _cleanerRepository = cleanerRepository;
            _mapper = mapper;
        }
        public IEnumerable<DtoCleanersGet> GetAll()
        {
            var list = _cleanerRepository.Get();
            var listDto = new List<DtoCleanersGet>();
            foreach (var cleaner in list)
            {
                listDto.Add(_mapper.Map<DtoCleanersGet>(cleaner));
            }
            return listDto;
        }
        public DtoCleanersGet GetOne(int id)
        {
            return _mapper.Map<DtoCleanersGet>(_cleanerRepository.GetById(id));
        }
        public bool Add(DtoCleanersPost cleaner)
        {
            var dto = _mapper.Map<Cleaner>(cleaner);
            _cleanerRepository.Post(dto);
            return true;
        }
        public bool update(int id, DtoCleanersPost value)
        {
            var dto = _mapper.Map<Cleaner>(value);
            _cleanerRepository.Put(id, dto);
            return true;
        }
        public void Remove(int id)
        {
            _cleanerRepository.Delete(id);
            
        }
    }
}
