using Multishop.Order.Application.Features.CQRS.Commands.AddressCommands;
using Multishop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.AddressHendlers
{
	public class RemoveAddressCommandHandler
	{
		private readonly IRepository<Address> _repository;

		public RemoveAddressCommandHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}
		public async Task Handle(RemoveAddressCommand command)
		{
			var values = await _repository.GetByIdAsync(command.Id);
			await _repository.DeleteAsync(values);
		}
	}
}
