const input = document.querySelector('input[type="text"]');
const button = document.querySelector('button');
const qrCodeImg = document.getElementById('qr-code');
const downloadBtn = document.getElementById('download-btn');

// Initially hide the image and download button
qrCodeImg.style.display = 'none';
downloadBtn.style.display = 'none';

button.addEventListener('click', async () => {
  const data = input.value;
  if (data) {
    try {
      const response = await fetch(`https://localhost:7133/Qr?data=${encodeURIComponent(data)}`, {
        method: 'GET',
        headers: {
          'Content-Type': 'image/png',
          'Content-Disposition': 'inline',
        },
      });
      const blob = await response.blob();
      const url = URL.createObjectURL(blob);
      qrCodeImg.setAttribute('src', url);
      qrCodeImg.style.display = 'inline';
      downloadBtn.style.display = 'inline';
      downloadBtn.setAttribute('href', url);
      downloadBtn.setAttribute('download', 'QRimg.png');
      console.log('Response:', response);
	document.getElementById("textbox1").value = "";
    } catch (error) {
      console.log('Error:', error);
    }
  }
});

// Add an event listener to the download button
downloadBtn.addEventListener('click', () => {
  downloadBtn.click();
});
