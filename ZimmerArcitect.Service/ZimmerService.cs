using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<DtoZimmer>> GetAllAsync()
        {
            var list =await _ZimmerRepository.GetAsync();
            var listDto = new List<DtoZimmer>();
            foreach (var owner in list)
            {
                listDto.Add(_mapper.Map<DtoZimmer>(owner));
            }
            return listDto;
        }
        public async Task<DtoZimmer> GetOneAsync(int id)
        {
            var zimmer = await _ZimmerRepository.GetByIdAsync(id);
            if (zimmer == null)
            {
                throw new Exception("Zimmer not found.");
            }
            return _mapper.Map<DtoZimmer>(zimmer);
            //var zimmer = await _ZimmerRepository.GetByIdAsync(id); // הנח ש-GetByIdAsync קיימת
            //return _mapper.Map<DtoZimmer>(zimmer);

        }
        public async Task< bool> AddAsync(DtoZimmer zimmer)
        {
            var dto = _mapper.Map<Zimmer>(zimmer);
            await _ZimmerRepository.PostAsync(dto);
            return true;
        }
        public bool update(int id, DtoZimmer value)
        {
            var dto = _mapper.Map<Zimmer>(value);
            _ZimmerRepository.Put(id, dto);
            return true;
        }
        public async Task<bool> RemoveAsync(int id)
        {
           return await _ZimmerRepository.DeleteAsync(id);
           
        }
    }
}
