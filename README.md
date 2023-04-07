<p align="center">
<img src="https://user-images.githubusercontent.com/25421570/230541973-e59fe6d4-c3a2-4bb4-865d-41d396bb77d5.png">
</p>

# The API
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
```GET /api/qr?data=example_data```

# The Frontend

the frontend is simple and is intended to demonstrate this api
1. Launch the API 
2. Browse the index.html file
3. Use the website

if you face any problems with the QR code not generating , make sure the URL in this line in the script.js file is set to the correct API Url

``` const response = await fetch(`https://localhost:7133/Qr?data=${encodeURIComponent(data)}```
