using System.Text;
using Net.Codecrete.QrCodeGenerator;

var qr = QrCode.EncodeText("Akash Shivaji Ajab", QrCode.Ecc.Medium);
            string svg = qr.ToSvgString(4);
            File.WriteAllText("Akash-qr.svg", svg, Encoding.UTF8);