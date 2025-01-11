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
    public class ZimmerService: IZimmerService
    {
        private readonly IZimmerRepository _ZimmerRepository;
        private readonly IMapper _mapper;
        public ZimmerService(IZimmerRepository zimmerRepository,IMapper mapper)
        {
            _ZimmerRepository = zimmerRepository;
            _mapper = mapper;
        }
        public IEnumerable<DtoZimmer> GetAll()
        {
            var list = _ZimmerRepository.Get();
            var listDto = new List<DtoZimmer>();
            foreach (var owner in list)
            {
                listDto.Add(_mapper.Map<DtoZimmer>(owner));
            }
            return listDto;
        }
        public DtoZimmer GetOne(int id)
        {
            return _mapper.Map<DtoZimmer>(_ZimmerRepository.GetById(id));

        }
        public bool Add(DtoZimmer zimmer)
        {
            var dto = _mapper.Map<Zimmer>(zimmer);
            _ZimmerRepository.Post(dto);
            return true;
        }
        public bool update(int id, DtoZimmer value)
        {
            var dto = _mapper.Map<Zimmer>(value);
            _ZimmerRepository.Put(id, dto);
            return true;
        }
        public void Remove(int id)
        {
            _ZimmerRepository.Delete(id);
           
        }
    }
}
