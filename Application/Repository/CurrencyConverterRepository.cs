using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Repository
{
	public sealed class CurrencyConverterRepository
	{

		public static CurrencyConverterRepository Instance { get; } = new();
		public CurrencyCoverterModel CurrencyCoverterModel = new();

		private CurrencyConverterRepository() 
		{

		}
	}
}
