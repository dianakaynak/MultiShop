using Multishop.Order.Application.Features.CQRS.Queries.AddressQueries;
using Multishop.Order.Application.Features.CQRS.Results.AddressResults;
using Multishop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.AddressHendlers
{
	public class GetAddressByIdQueryHandler
	{
		private readonly IRepository<Address> _repository;

		public GetAddressByIdQueryHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}
		public async Task<GetAddressByIdQueryResult> Handle(
			GetAddressByIdQuery query)
		{
			var values=await _repository.GetByIdAsync(query.Id);
			return new GetAddressByIdQueryResult
			{
				AdressId = values.AdressId,
				City = values.City,
				Detail = values.Detail,
				District = values.District,
				UserId = values.UserId

			};
		}
	}
}
