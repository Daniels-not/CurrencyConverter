using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Enum;
using Application.Models;
using Application.Repository;

namespace Application.Services
{
    public class CurrencyConverterServices
    {
        public void ConvertTo(CurrencyCoverterModel data)
        {
            if(data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.DOP && 
                data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.USD)
            {
                CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 0.019);

            } else
            {
                if(data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.DOP && data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.EUR)
                {
                    CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 0.019);

                } else
                {
                    if (data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.USD && data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.DOP)
                    {
                        CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 52.44);

                    } else
                    {
                        if (data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.USD && data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.EUR)
                        {
                            CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 1.00);

                        } else
                        {
                            if (data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.EUR && data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.DOP)
                            {
                                CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 52.44);

                            }
                            else
                            {
                                if (data.CurrencyType1 == (int)CurrencyConvertEnums.CurrencyType.EUR && data.CurrencyType2 == (int)CurrencyConvertEnums.CurrencyType.DOP)
                                {
                                    CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = (data.Currency * 1.00);

                                } else
                                {
                                    CurrencyConverterRepository.Instance.CurrencyCoverterModel.resutls = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        public CurrencyCoverterModel getResult()
        {
            return CurrencyConverterRepository.Instance.CurrencyCoverterModel;
        }
    }
}
