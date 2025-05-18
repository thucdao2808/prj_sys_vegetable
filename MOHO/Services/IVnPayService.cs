using Microsoft.AspNetCore.Http;
using MOHO.Models;

namespace MOHO.Services;
public interface IVnPayService
{
    string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
    PaymentResponseModel PaymentExecute(IQueryCollection collections);
}