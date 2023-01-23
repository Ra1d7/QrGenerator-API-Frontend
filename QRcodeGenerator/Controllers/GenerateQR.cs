using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Web.Http;

[Produces("application/json")]
[ApiController]
[Microsoft.AspNetCore.Mvc.Route("[controller]")]
public class QrController : ControllerBase
{
    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult GenerateQRCode(string data, string filePath)
    {
        try
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngBytes = qrCode.GetGraphic(20);
            return File(qrCodeAsPngBytes, "application/octet-stream", $"{filePath}.png");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
