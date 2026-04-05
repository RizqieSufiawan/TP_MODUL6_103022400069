using System.Diagnostics;

namespace TP_MODUL6_103022400069
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "tidak boleh null");
            Debug.Assert(title.Length <= 100, "maksimal 100 karakter");

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "maksimal 10.000.000");
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"[Exception] Overflow terjadi: {e.Message}");
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}