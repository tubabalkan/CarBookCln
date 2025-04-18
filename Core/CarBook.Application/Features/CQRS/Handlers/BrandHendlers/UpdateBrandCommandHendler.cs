﻿using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHendlers
{
    public class UpdateBrandCommandHendler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHendler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BrandId);
            values.Name = command.Name;
            
            await _repository.UpdateAsync(values);
        }
    }
}
