# QRCodeGenerator-API
This is a C# ASP.NET Core 6 API that takes in two parameters, data and filePath, and generates a QR code image file using the "QRCoder.Core" library. It then sends the generated QR code image file back as a response to the user of the API.

## Getting Started
1. Install the "QRCoder.Core" NuGet package by running the following command in the Package Manager Console: 
```
dotnet add package QRCoder.Core
```
2. In the QrController class, add the GenerateQRCode method. This method accepts two parameters, data and filePath, where data is the data to be encoded in the QR code, and filePath is the file path to save the generated QR code image file.

3. In the GenerateQRCode method, a QR code is generated using the "QRCoder.Core" library using the provided data and filePath parameters.

4. The generated QR code image file is then saved to the specified filePath on the server.

5. The API then returns the file as a FileStreamResult to the user of the API.

## Usage
To use the API, send a GET request to the endpoint /api/qr with the data and filePath as query parameters.

### Example
```GET /api/qr?data=example_data&filePath=C:\example\qrcode.png```
