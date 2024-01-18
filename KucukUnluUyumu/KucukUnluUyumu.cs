using System;

namespace KucukUnluUyumu
{
    public class KucukUnluUyumu
    {
        public bool KucukUnluUyumunaUygunMu(string kelime)
        {
            List<char> sesliHarfler = new List<char>() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> duzUnluler = new List<char>() { 'a', 'e', 'ı', 'i' };
            List<char> yuvarlakUnluler = new List<char>() { 'o', 'ö', 'u', 'ü' };
            List<char> digerSonuclar = new List<char>() { 'a', 'e', 'u', 'ü' };
            List<char> kelimeninSesliHarfleri = new List<char>();

            kelime = kelime.Replace('I', 'ı').ToLower();

            // kelimede hiç sesli harf olmaması durumu
            if (kelime.All(k => !sesliHarfler.Contains(k)))
                return false;

            foreach (var harf in kelime)
            {
                if (sesliHarfler.Contains(harf))
                    kelimeninSesliHarfleri.Add(harf);
            }

            for (int i = 0; i < kelimeninSesliHarfleri.Count; i++)
            {   // a,e,ı,i ise ve bir sonrasında a,e,ı,i değilse
                if (i < kelimeninSesliHarfleri.Count - 1 && duzUnluler.Contains(kelimeninSesliHarfleri[i]) && !duzUnluler.Contains(kelimeninSesliHarfleri[i + 1])) //a,e,ı,i ise
                    return false;
                // o,ö,u,ü ise ve bir sonrasında a,e,ı,i değilse
                if (i < kelimeninSesliHarfleri.Count - 1 && yuvarlakUnluler.Contains(kelimeninSesliHarfleri[i]) && !digerSonuclar.Contains(kelimeninSesliHarfleri[i + 1])) //o,ö,u,ü ise
                    return false;
            }
            return true;
        }
    }
}
