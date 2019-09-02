using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using YeelightAPI;

namespace Xiaomi_Svet
{
    public class DeviceM
    {
       public DeviceM(string name, string ip)
        {
            this.name = name;
            ipName = ip;
            device = new Device(ipName);
            Connect();


        }

        public string name { get; set; }
        public string ipName { get; set; }
        public string mesto { get; set; }
        bool isSostoanie = false;
        public bool IsSostoanie
        {
            get
            {
                return isSostoanie;
            }
            set
            {
                isSostoanie = value;
                device.SetPower(IsSostoanie);
            }
        }
        Device device;
        bool isSostoaniConnecte = false;
        public string IsSostoanieConnect
        {
            get
            {
                if(isSostoaniConnecte)
                {
                    return "Подключено";
                }
                return "Не в сети";

            }
           
        }
        public async void Connect()
        {
            bool es = true;
         
            for (int port=1000; port<10000; port++)
            {

            
            try
            {


                isSostoaniConnecte = await device.Connect();
if(isSostoaniConnecte)
                    {
                        MessageDialog hh = new MessageDialog(port.ToString());
                         await hh.ShowAsync();
                    }

                }
            catch (Exception ex)
            {
                    //MessageDialog hh = new MessageDialog(ex.Message);
                    // await hh.ShowAsync();
                    Debug.WriteLine("error"+"\t"+port.ToString());
                    device = new Device(ipName, port);
                }
            }
            
        }
        int volSvet = 10;
        public int VolSvet
        {
            get
            {
                return volSvet;
            }
            set
            {
                volSvet = value;
                device.SetBrightness(VolSvet);

            }
        }
       
    }
}
