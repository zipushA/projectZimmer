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
        public IEnumerable<DtoOwnerGet> GetAll()
        {
            var list = _ownerRepository.Get();
            var listDto = new List<DtoOwnerGet>();
            foreach (var owner in list)
            {
                listDto.Add(_mapper.Map<DtoOwnerGet>(owner));
            }
            return listDto;
        }
        public DtoOwnerGet GetOne(int id)
        {
            return _mapper.Map<DtoOwnerGet>(_ownerRepository.GetById(id));
            
        }
        public bool Add(DtoOwnerPost owner)
        {
            var dto = _mapper.Map<Owner>(owner);
            _ownerRepository.Post(dto);
            return true;
        }
        public bool update(int id, DtoOwnerPost value)
        {
            var dto = _mapper.Map<Owner>(value);
            _ownerRepository.Put(id, dto);
            return true;
        }
        public void Remove(int id)
        {
            _ownerRepository.Delete(id);
           
        }
    }
}
