using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Web.Http;

[Produces("application/json")]
[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class QrController : ControllerBase
{
    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult GenerateQRCode(string data)
    {
        try
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngBytes = qrCode.GetGraphic(20);
            Random rnd = new Random();
            int random = rnd.Next(2000, 20000);
            int tenPercent = data.Length / 10;
            Console.WriteLine(data);
            return File(qrCodeAsPngBytes, "image/png", $"{data[..tenPercent]+random.ToString()}.png");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
