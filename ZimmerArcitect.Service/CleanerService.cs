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
        public async Task< IEnumerable<DtoCleanersGet>> GetAllAsync()
        {
            var list =await _cleanerRepository.GetAsync();
            var listDto = new List<DtoCleanersGet>();
            foreach (var cleaner in list)
            {
                listDto.Add(_mapper.Map<DtoCleanersGet>(cleaner));
            }
            return listDto;
        }
        public async Task<DtoCleanersGet> GetOneAsync(int id)
        {

            var cleaner = await _cleanerRepository.GetByIdAsync(id); // הוספת await
            return _mapper.Map<DtoCleanersGet>(cleaner); // מיפוי ל-DTO
            //return await _mapper.Map<DtoCleanersGet>(_cleanerRepository.GetByIdAsync(id));
        }
        public async Task<bool> AddAsync(DtoCleanersPost cleaner)
        {
            var dto = _mapper.Map<Cleaner>(cleaner);
            await _cleanerRepository.PostAsync(dto);
            return true;
        }
        public async Task<bool> updateAsync(int id, DtoCleanersPost value)
        {
            var dto = _mapper.Map<Cleaner>(value);
           await _cleanerRepository.PutAsync(id, dto);
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
           await  _cleanerRepository.DeleteAsync(id);
            return true;
            
        }
    }
}
