using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace UP_L2_Skaner
{
    class Scanner
    {
        DeviceInfo scannerInfo = null;
        Device scanner = null;
        ImageFile actualImage;
        public void connect()
        {
            var deviceManager = new DeviceManager();

            foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
            {
                if (deviceInfo.Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }
                else
                {
                    scannerInfo = deviceInfo;
                }
            }

            System.Diagnostics.Debug.WriteLine(scannerInfo.Properties["Name"].get_Value().ToString());
            scanner = scannerInfo.Connect();

        }

        public ImageFile scan()
        {
            var item = scanner.Items[1];
            if (item == null)
            {
                return new ImageFile();
            }
            else
            {
                actualImage = (ImageFile)item.Transfer(FormatID.wiaFormatPNG);
                return actualImage;

            }
        }

        public void saveImageAs(String extension)
        {

            var path = @"D:\Studia\SKANY\scan." + extension;

            if (actualImage != null)
            {
                actualImage.SaveFile(path);
            }
            else
            {
                MessageBox.Show("Najpierw należy wykonać skan");
            }


        }
    }
}
