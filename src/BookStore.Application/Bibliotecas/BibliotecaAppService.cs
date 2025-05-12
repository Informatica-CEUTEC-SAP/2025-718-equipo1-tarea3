using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Bibliotecas;
using Volo.Abp.Application.Services; 
 


namespace BookStore.Application.Bibliotecas
{
    public class BibliotecaAppService : ApplicationService, IBibliotecaAppService
    {
        private readonly IBibliotecaRepository _bibliotecaRepository;
        private readonly IMapper _mapper;

        public BibliotecaAppService(IBibliotecaRepository bibliotecaRepository, IMapper mapper)
        {
            _bibliotecaRepository = bibliotecaRepository;
            _mapper = mapper;
        }

        
        public async Task<List<BibliotecaDto>> GetListAsync()
        {
            var bibliotecas = await _bibliotecaRepository.GetListAsync();
            return _mapper.Map<List<BibliotecaDto>>(bibliotecas);
        }

       
        public async Task<BibliotecaDto> GetAsync(Guid id)
        {
            var biblioteca = await _bibliotecaRepository.GetAsync(id);
            return _mapper.Map<BibliotecaDto>(biblioteca);
        }

        // Crear una nueva biblioteca
        public async Task<BibliotecaDto> CreateAsync(CreateUpdateBibliotecaDto input)
        {
            var biblioteca = _mapper.Map<Biblioteca>(input);
            await _bibliotecaRepository.InsertAsync(biblioteca);
            return _mapper.Map<BibliotecaDto>(biblioteca);
        }

        // Actualizar una biblioteca existente
        public async Task<BibliotecaDto> UpdateAsync(Guid id, CreateUpdateBibliotecaDto input)
        {
            var biblioteca = await _bibliotecaRepository.GetAsync(id);
            _mapper.Map(input, biblioteca);  // Actualiza las propiedades
            await _bibliotecaRepository.UpdateAsync(biblioteca);
            return _mapper.Map<BibliotecaDto>(biblioteca);
        }

        // Eliminar una biblioteca
        public async Task DeleteAsync(Guid id)
        {
            var biblioteca = await _bibliotecaRepository.GetAsync(id);
            await _bibliotecaRepository.DeleteAsync(biblioteca);
        }
    }
}
