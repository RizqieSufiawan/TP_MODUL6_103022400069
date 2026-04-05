namespace TP_MODUL6_103022400069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track = new SayaMusicTrack("Bunga Terakhir");
            track.IncreasePlayCount(500);
            track.PrintTrackDetails();
        }
    }
}