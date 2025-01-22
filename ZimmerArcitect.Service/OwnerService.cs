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
using ZimmerArcitect.Data.Repositories;

namespace ZimmerArcitect.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;
        private readonly IMapper _mapper;
        public OwnerService(IOwnerRepository ownerRepository,IMapper mapper)
        {
            _ownerRepository = ownerRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DtoOwnerGet>> GetAllSaync()
        {
            var list =await _ownerRepository.GetAsync();
            var listDto = new List<DtoOwnerGet>();
            foreach (var owner in list)
            {
                listDto.Add(_mapper.Map<DtoOwnerGet>(owner));
            }
            return listDto;
        }
        public async Task<DtoOwnerGet> GetOneAsync(int id)
        {
            var owner = await _ownerRepository.GetByIdAsync(id);
            return _mapper.Map<DtoOwnerGet>(owner);
            
        }
        public async Task<bool> AddAsync(DtoOwnerPost owner)
        {
            var dto = _mapper.Map<Owner>(owner);
            await _ownerRepository.PostAsync(dto);
            return true;
        }
        public bool update(int id, DtoOwnerPost value)
        {
            var dto = _mapper.Map<Owner>(value);
            _ownerRepository.Put(id, dto);
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            return await _ownerRepository.DeleteAsync(id);
           
        }
    }
}
