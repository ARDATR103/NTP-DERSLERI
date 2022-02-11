using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VideoOyunları> Oyunlar = new List<VideoOyunları>();
            VideoOyunları League_of_Legends = new VideoOyunları();
            League_of_Legends.OyunAdı = "League of Legends";
            League_of_Legends.Geliştirici = "Riot Games";
            League_of_Legends.Platform = "Windows,Mac OS";
            League_of_Legends.ÇıkışTarihi = "27 Ekim 2009";
            League_of_Legends.Tür = "Çevrimiçi Çok Oyunculu Savaş Arenası(MOBA)";

            VideoOyunları Dying_Light_2_Stay_Human = new VideoOyunları();
            Dying_Light_2_Stay_Human.OyunAdı = "Dying Light 2 Stay Human";
            Dying_Light_2_Stay_Human.Geliştirici = "Techland";
            Dying_Light_2_Stay_Human.Platform = "Windows,Playstation 4,Playstation 5,Xbox One,Xbox Series X/S";
            Dying_Light_2_Stay_Human.ÇıkışTarihi = "4 Şubat 2022";
            Dying_Light_2_Stay_Human.Tür = "Aksiyon Rol Yapma(RPG),Hayatta Kalma Korku";

            Oyunlar.Add(League_of_Legends);
            Oyunlar.Add(Dying_Light_2_Stay_Human);
            foreach (VideoOyunları oyun in Oyunlar)
            {
                Console.WriteLine(oyun.OyunAdı + oyun.Geliştirici + oyun.Platform + oyun.ÇıkışTarihi + oyun.Tür);
                Console.WriteLine("--------------------------");
            }

            List<Filimler> filimler = new List<Filimler>();
            Filimler Labirent_Alev_Deneyleri = new Filimler();
            Labirent_Alev_Deneyleri.FilimAdı = "Labirent Alev Deneyleri";
            Labirent_Alev_Deneyleri.Yönetmen = "Wes Ball";
            Labirent_Alev_Deneyleri.Dağıtıcı = "20th Century Fox";
            Labirent_Alev_Deneyleri.ÇıkışTarihi = "18 Eylül 2015";
            Labirent_Alev_Deneyleri.Hasılat = "312.3 Milyon Dolar";

            Filimler Çığlık_5 = new Filimler();
            Çığlık_5.FilimAdı = "Çığlık 5";
            Çığlık_5.Yönetmen = "Matt Bettinelli-Olpin,Tyler Gillett";
            Çığlık_5.Dağıtıcı = "Paramount Pictures";
            Çığlık_5.ÇıkışTarihi = "14 Ocak 2022";
            Çığlık_5.Hasılat = "Bilinmiyor";

            filimler.Add(Labirent_Alev_Deneyleri);
            filimler.Add(Çığlık_5);
            foreach (Filimler filim in filimler)
            {
                Console.WriteLine("Filim Adı : " + filim.FilimAdı + "/" + "Yönetmen : " + filim.Yönetmen + "/" + "Dağıtıcı : " + filim.Dağıtıcı + "/" + "ÇıkışTarihi : " + filim.ÇıkışTarihi + "/" + "Hasılat : " + filim.Hasılat);
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }


    class VideoOyunları
    {
        public string OyunAdı;
        public string Geliştirici;
        public string Platform;
        public string ÇıkışTarihi;
        public string Tür;
    }

    class Filimler
    {
        public string FilimAdı;
        public string Yönetmen;
        public string Dağıtıcı;
        public string ÇıkışTarihi;
        public string Hasılat;
    }
}
